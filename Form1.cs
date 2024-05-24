using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Zadanie1_Lab3
{
    public partial class Form1 : Form
    {
        private byte[] key;
        private byte[] iv;

        public Form1()
        {
            InitializeComponent();
            comboBoxAlgorithm.Items.AddRange(new string[] { "Aes", "DES", "RC2", "Rijndael", "TripleDES" });
            comboBoxAlgorithm.SelectedIndex = 0;
        }

        private void buttonGenerateKeyIV_Click(object sender, EventArgs e)
        {
            using (SymmetricAlgorithm algorithm = GetSelectedAlgorithm())
            {
                // Klucz
                algorithm.GenerateKey();
                algorithm.GenerateIV();

                key = algorithm.Key;
                iv = algorithm.IV;

                string keyHex = BitConverter.ToString(algorithm.Key).Replace("-", "");
                string ivHex = BitConverter.ToString(algorithm.IV).Replace("-", "");

                // Wyświetlanie klucza
                textBoxKey.Text = keyHex;
                textBoxIV.Text = ivHex;
            }
        }

        private SymmetricAlgorithm GetSelectedAlgorithm()
        {
            switch (comboBoxAlgorithm.SelectedItem.ToString())
            {
                case "Aes":
                    return Aes.Create();
                case "DES":
                    return DES.Create();
                case "RC2":
                    return RC2.Create();
                case "Rijndael":
                    return Rijndael.Create();
                case "TripleDES":
                    return TripleDES.Create();
                default:
                    throw new ArgumentException("Nieznany algorytm szyfrowania.");
            }
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            using (SymmetricAlgorithm algorithm = GetSelectedAlgorithm())
            {
                try
                {
                    algorithm.Key = key;
                    algorithm.IV = iv;

                    // Konwersacja tekstu jawnego na byte array
                    byte[] plaintextBytes = Encoding.UTF8.GetBytes(textBoxPlainTextASCII.Text);

                    // Tekst jawny
                    byte[] encryptedBytes = algorithm.CreateEncryptor().TransformFinalBlock(plaintextBytes, 0, plaintextBytes.Length);

                    // Wyśiwetlanie w postaci ASCII
                    textBoxCipherTextASCII.Text = Encoding.ASCII.GetString(encryptedBytes);

                    // Konwertujemy zaszyfrowany tekst na format HEX
                    string encryptedHex = BitConverter.ToString(encryptedBytes).Replace("-", "");

                    // Wyświetlanie w postaci HEX
                    textBoxCipherTextHex.Text = encryptedHex;
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show($"Błąd szyfrowania: {ex.Message}");
                }
            }
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            using (SymmetricAlgorithm algorithm = GetSelectedAlgorithm())
            {
                try
                {
                    algorithm.Key = key;
                    algorithm.IV = iv;

                    // Zaszyfrowany tekst hexBox na byte array
                    byte[] encryptedBytes = HexStringToByteArray(textBoxCipherTextHex.Text);

                    byte[] decryptedBytes = algorithm.CreateDecryptor().TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);

                    // Odszyfrowany tekst na string
                    string decryptedText = Encoding.UTF8.GetString(decryptedBytes);

                    textBoxPlainTextASCII.Text = decryptedText;

                    textBoxPlainTextHex.Text = textBoxCipherTextHex.Text;
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show($"Błąd deszyfrowania: {ex.Message}");
                }
            }
        }

        private void buttonEncryptTime_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            buttonEncrypt_Click(sender, e);

            stopwatch.Stop();
            textBoxEncryptTime.Text = stopwatch.Elapsed.TotalMilliseconds.ToString() + " ms";
        }

        private void buttonDecryptTime_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            buttonDecrypt_Click(sender, e);

            stopwatch.Stop();
            textBoxDecryptTime.Text = stopwatch.Elapsed.TotalMilliseconds.ToString() + " ms";
        }

        private byte[] HexStringToByteArray(string hex)
        {
            int length = hex.Length / 2;
            byte[] bytes = new byte[length];
            for (int i = 0; i < length; i++)
            {
                bytes[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            return bytes;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
