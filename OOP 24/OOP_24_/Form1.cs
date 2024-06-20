using System;
using System.Drawing;
using System.Drawing.Text;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace OOP_24_
{
    public partial class Form1 : Form
    {
        private Thread thread1; // ���� ��� �������� ���������� RC5
        private Thread thread2; // ���� ��� �������� ��������� MD5
        private Thread thread3; // ���� ��� �������� ���������� ������

        public Form1()
        {
            InitializeComponent();
        }

        #region RC5
        private void RC5()
        {
            try
            {
                string word = textBox1.Text; // �������� ����� ��� ���������� � ���������� ����
                byte[] _key = GetKey("password"); // �������� ���� ��� ����������
                string encryptedWord = Encrypt(word, _key); // ������� �����

                label1.Text = encryptedWord; // ³��������� ������������ �����
            }
            catch (Exception ex) { MessageBox.Show($"{ex.Message}"); } // ������� �������
        }

        private string Encrypt(string plaintext, byte[] _key)
        {
            byte[] plaintextBytes = Encoding.UTF8.GetBytes(plaintext); // ������������ ������ � �����

            using (var rijndael = new RijndaelManaged()) // ������������� �������� ���������� Rijndael
            {
                rijndael.Key = _key; // ������������ ����
                rijndael.Mode = CipherMode.ECB; // ������������ ����� ����������
                rijndael.Padding = PaddingMode.PKCS7; // ������������ ����� ����������

                using (var encryptor = rijndael.CreateEncryptor()) // ��������� ��������
                {
                    byte[] ciphertextBytes = encryptor.TransformFinalBlock(plaintextBytes, 0, plaintextBytes.Length); // ����������� ����������
                    return Convert.ToBase64String(ciphertextBytes); // ��������� ������������ ����� � ������ ����� Base64
                }
            }
        }

        private byte[] GetKey(string password)
        {
            using (var sha256 = SHA256.Create()) // ������������� �������� ��������� SHA256 ��� ��������� �����
            {
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(password)); // ��������� ��������� ����
            }
        }
        #endregion

        #region MD3
        private void MD()
        {
            try
            {
                var md3 = MD5.Create(); // ��������� ��'��� MD5
                var hash = md3.ComputeHash(Encoding.UTF8.GetBytes(textBox2.Text)); // ������ �������� �����
                string hashString = BitConverter.ToString(hash).Replace("-", "").ToLower(); // ������������ ��� � �����

                label2.Text = hashString; // ³��������� ���
            }
            catch (Exception ex) { MessageBox.Show($"{ex.Message}"); } // ������� �������
        }
        #endregion

        #region Cesar
        private void Cesar()
        {
            try
            {
                string key = "password"; // ������ ���� ��� ����������
                char[] charArray = textBox3.Text.ToCharArray(); // ���������� �������� ����� � ����� �������

                for (int i = 0; i < charArray.Length; i++)
                {
                    if (char.IsLetter(charArray[i])) // ����������, �� ������ - �����
                    {
                        char baseLetter = char.IsUpper(charArray[i]) ? 'A' : 'a'; // ��������� ������ �� ����� ������� �����
                        int shift = key[i % key.Length] - 'A'; // ������������� ������� ����� �� ����
                        charArray[i] = (char)(((charArray[i] + shift - baseLetter) % 26) + baseLetter); // ����������� ���������� ������
                    }
                }

                label3.Text = new string(charArray); // ³��������� ������������ �����
            }
            catch (Exception ex) { MessageBox.Show($"{ex.Message}"); } // ������� �������
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = string.Empty; // ������� ��������� ���������

            thread1?.Interrupt(); // ��������� ��������� ���� (���� �� ����)
            thread1 = new Thread(new ThreadStart(RC5)); // ��������� ����� ���� ��� �������� ���������� RC5
            thread1.Start(); // ��������� ����
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = string.Empty; // ������� ��������� ���������

            thread2?.Interrupt(); // ��������� ��������� ���� (���� �� ����)
            thread2 = new Thread(new ThreadStart(MD)); // ��������� ����� ���� ��� �������� ��������� MD5
            thread2.Start(); // ��������� ����
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = string.Empty; // ������� ��������� ���������

            thread3?.Interrupt(); // ��������� ��������� ���� (���� �� ����)
            thread3 = new Thread(new ThreadStart(Cesar)); // ��������� ����� ���� ��� �������� ���������� ������
            thread3.Start(); // ��������� ����
        }

        private void button6_Click(object sender, EventArgs e)
        {
            thread3?.Interrupt(); // ��������� ���� ��� �������� ���������� ������
        }

        private void button4_Click(object sender, EventArgs e)
        {
            thread1?.Interrupt(); // ��������� ���� ��� �������� ���������� RC5
        }

        private void button5_Click(object sender, EventArgs e)
        {
            thread2?.Interrupt(); // ��������� ���� ��� �������� ��������� MD5
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // ��������� �� ������
            thread1?.Interrupt();
            thread2?.Interrupt();
            thread3?.Interrupt();

            // ������� �� ����������
            label1.Text = string.Empty;
            label2.Text = string.Empty;
            label3.Text = string.Empty;

            // ��������� ��� ������ ��� ����� �������� � ��������� ��
            thread1 = new Thread(new ThreadStart(RC5));
            thread2 = new Thread(new ThreadStart(MD));
            thread3 = new Thread(new ThreadStart(Cesar));

            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // ��������� �� ������
            thread1?.Interrupt();
            thread2?.Interrupt();
            thread3?.Interrupt();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // ��������� �� ������ ��� ������� �����
            thread1?.Abort();
            thread2?.Abort();
            thread3?.Abort();
        }
    }
}
