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
        private Thread thread1; // Потік для операцій шифрування RC5
        private Thread thread2; // Потік для операцій хешування MD5
        private Thread thread3; // Потік для операцій шифрування Цезаря

        public Form1()
        {
            InitializeComponent();
        }

        #region RC5
        private void RC5()
        {
            try
            {
                string word = textBox1.Text; // Отримуємо текст для шифрування з текстового поля
                byte[] _key = GetKey("password"); // Генеруємо ключ для шифрування
                string encryptedWord = Encrypt(word, _key); // Шифруємо текст

                label1.Text = encryptedWord; // Відображаємо зашифрований текст
            }
            catch (Exception ex) { MessageBox.Show($"{ex.Message}"); } // Обробка помилок
        }

        private string Encrypt(string plaintext, byte[] _key)
        {
            byte[] plaintextBytes = Encoding.UTF8.GetBytes(plaintext); // Перетворення тексту в байти

            using (var rijndael = new RijndaelManaged()) // Використовуємо алгоритм шифрування Rijndael
            {
                rijndael.Key = _key; // Встановлюємо ключ
                rijndael.Mode = CipherMode.ECB; // Встановлюємо режим шифрування
                rijndael.Padding = PaddingMode.PKCS7; // Встановлюємо режим доповнення

                using (var encryptor = rijndael.CreateEncryptor()) // Створюємо шифратор
                {
                    byte[] ciphertextBytes = encryptor.TransformFinalBlock(plaintextBytes, 0, plaintextBytes.Length); // Застосовуємо шифрування
                    return Convert.ToBase64String(ciphertextBytes); // Повертаємо зашифрований текст у вигляді рядка Base64
                }
            }
        }

        private byte[] GetKey(string password)
        {
            using (var sha256 = SHA256.Create()) // Використовуємо алгоритм хешування SHA256 для отримання ключа
            {
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(password)); // Повертаємо хешований ключ
            }
        }
        #endregion

        #region MD3
        private void MD()
        {
            try
            {
                var md3 = MD5.Create(); // Створюємо об'єкт MD5
                var hash = md3.ComputeHash(Encoding.UTF8.GetBytes(textBox2.Text)); // Хешуємо введений текст
                string hashString = BitConverter.ToString(hash).Replace("-", "").ToLower(); // Перетворюємо хеш у рядок

                label2.Text = hashString; // Відображаємо хеш
            }
            catch (Exception ex) { MessageBox.Show($"{ex.Message}"); } // Обробка помилок
        }
        #endregion

        #region Cesar
        private void Cesar()
        {
            try
            {
                string key = "password"; // Задаємо ключ для шифрування
                char[] charArray = textBox3.Text.ToCharArray(); // Конвертуємо введений текст у масив символів

                for (int i = 0; i < charArray.Length; i++)
                {
                    if (char.IsLetter(charArray[i])) // Перевіряємо, чи символ - літера
                    {
                        char baseLetter = char.IsUpper(charArray[i]) ? 'A' : 'a'; // Визначаємо верхню чи нижню границю літери
                        int shift = key[i % key.Length] - 'A'; // Використовуємо символи ключа як зсув
                        charArray[i] = (char)(((charArray[i] + shift - baseLetter) % 26) + baseLetter); // Застосовуємо шифрування Цезаря
                    }
                }

                label3.Text = new string(charArray); // Відображаємо зашифрований текст
            }
            catch (Exception ex) { MessageBox.Show($"{ex.Message}"); } // Обробка помилок
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = string.Empty; // Очищуємо попередній результат

            thread1?.Interrupt(); // Зупиняємо попередній потік (якщо він існує)
            thread1 = new Thread(new ThreadStart(RC5)); // Створюємо новий потік для операцій шифрування RC5
            thread1.Start(); // Запускаємо потік
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = string.Empty; // Очищуємо попередній результат

            thread2?.Interrupt(); // Зупиняємо попередній потік (якщо він існує)
            thread2 = new Thread(new ThreadStart(MD)); // Створюємо новий потік для операцій хешування MD5
            thread2.Start(); // Запускаємо потік
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = string.Empty; // Очищуємо попередній результат

            thread3?.Interrupt(); // Зупиняємо попередній потік (якщо він існує)
            thread3 = new Thread(new ThreadStart(Cesar)); // Створюємо новий потік для операцій шифрування Цезаря
            thread3.Start(); // Запускаємо потік
        }

        private void button6_Click(object sender, EventArgs e)
        {
            thread3?.Interrupt(); // Зупиняємо потік для операцій шифрування Цезаря
        }

        private void button4_Click(object sender, EventArgs e)
        {
            thread1?.Interrupt(); // Зупиняємо потік для операцій шифрування RC5
        }

        private void button5_Click(object sender, EventArgs e)
        {
            thread2?.Interrupt(); // Зупиняємо потік для операцій хешування MD5
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Зупиняємо всі потоки
            thread1?.Interrupt();
            thread2?.Interrupt();
            thread3?.Interrupt();

            // Очищуємо всі результати
            label1.Text = string.Empty;
            label2.Text = string.Empty;
            label3.Text = string.Empty;

            // Створюємо нові потоки для кожної операції і запускаємо їх
            thread1 = new Thread(new ThreadStart(RC5));
            thread2 = new Thread(new ThreadStart(MD));
            thread3 = new Thread(new ThreadStart(Cesar));

            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Зупиняємо всі потоки
            thread1?.Interrupt();
            thread2?.Interrupt();
            thread3?.Interrupt();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Зупиняємо всі потоки при закритті форми
            thread1?.Abort();
            thread2?.Abort();
            thread3?.Abort();
        }
    }
}
