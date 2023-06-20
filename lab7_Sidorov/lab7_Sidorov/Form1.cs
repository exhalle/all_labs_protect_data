using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab7_Sidorov
{

    public partial class Form1 : Form
    {
        private byte[] aesKey;
        private byte[] aesIV;

        private byte[] tripleDesKey;
        private byte[] tripleDesIV;

        private Aes myAes = Aes.Create();
        private TripleDES my3Des = TripleDES.Create();



        public Form1()
        {
            InitializeComponent();
            cbKeySize.Text = "128";
            comboBox2.Text = "PBCS7";
            comboBox1.Text = "CBC - Cipher Block Chianing";
            toolTipGenBi.SetToolTip(buttonGIV, "Згенерувати BI");
            toolTipKeyGen.SetToolTip(buttonGKey, "Згенерувати ключ");
        }
        // Shannon entropy
        float shannon(byte[] data)
        {
            float[] dataCounter = new float[256];
            Array.Clear(dataCounter, 0, dataCounter.Length);
            float entropy = 0.0f;
            float dataLength = data.Length;

            foreach (byte b in data)
            {
                dataCounter[b]++;
            }

            foreach (float count in dataCounter)
            {
                float px = count / dataLength;

                if (px > 0)
                {
                    entropy -= px * (float)Math.Log(px, 2);
                }
            }

            return entropy / 8.0f;
        }

        private void bIn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileInpath = openFileDialog.FileName;
                    textInPath.Text = fileInpath;
                    if (File.Exists(fileInpath))
                    {
                        byte[] bytes = File.ReadAllBytes(fileInpath);
                        int fileInSize = bytes.Length;
                        textInFileSize.Text = fileInSize + " б";

                        textInFileEntropy.Text = shannon(bytes).ToString();
                    }
                }
            }
        }

        private void bOut_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileOutpath = openFileDialog.FileName;
                    textOutPath.Text = fileOutpath;
                    textOutFileSize.Text = "???";
                    textOutFileEntropy.Text = "???";
                }
            }
        }

        private void buttonGKey_Click(object sender, EventArgs e)
        {
            myAes.KeySize = Int16.Parse(cbKeySize.Text);
            aesKey = myAes.Key;

            tripleDesKey = my3Des.Key;
            StringBuilder sb = new StringBuilder();
            foreach (byte b in aesKey)
            {
                sb.Append(b.ToString("0000"));
                sb.Append("-");
            }
            sb.Length--;
            textKey.Text = sb.ToString();
        }

        private void buttonGIV_Click(object sender, EventArgs e)
        {
            myAes.GenerateIV();
            aesIV = myAes.IV;

            my3Des.GenerateIV();
            tripleDesIV = my3Des.IV;
            StringBuilder sb = new StringBuilder();

            if (radioButtonAes.Checked)
            {
                foreach (byte b in aesIV)
                {
                    sb.Append(b.ToString("0000"));
                    sb.Append("-");
                }
            }
            else if (radioButton3Des.Checked)
            {
                foreach (byte b in tripleDesIV)
                {
                    sb.Append(b.ToString("0000"));
                    sb.Append("-");
                }
            }
            sb.Length--;
            textIV.Text = sb.ToString();
        }

        private void checkBoxIV0_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIV0.Checked)
            {
                StringBuilder sb = new StringBuilder();
                if (radioButtonAes.Checked)
                {
                    buttonGIV.Enabled = false;
                    aesIV = new byte[16] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                    foreach (byte b in aesIV)
                    {
                        sb.Append(b.ToString("0000"));
                        sb.Append("-");
                    }
                }
                else if (radioButton3Des.Checked)
                {
                    buttonGIV.Enabled = false;
                    tripleDesIV = new byte[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
                    foreach (byte b in tripleDesIV)
                    {
                        sb.Append(b.ToString("0000"));
                        sb.Append("-");
                    }
                }
                sb.Length--;
                textIV.Text = sb.ToString();
            }
            else
            {
                buttonGIV.Enabled = true;
            }
        }

        private void radioButtonAes_CheckedChanged(object sender, EventArgs e)
        {
            textKey.Text = "";
            textIV.Text = "";
            checkBoxIV0.Checked = false;
            cbKeySize.Enabled = true;
        }

        private void radioButton3Des_CheckedChanged(object sender, EventArgs e)
        {
            textKey.Text = "";
            textIV.Text = "";
            checkBoxIV0.Checked = false;
            cbKeySize.Enabled = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                string fileSavePath = "";
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileSavePath = openFileDialog.FileName;
                }
                if (File.Exists(fileSavePath))
                {
                    File.WriteAllText(fileSavePath, textKey.Text + "\n" + textIV.Text);
                    MessageBox.Show("Ключ збережено");
                }
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                string fileLoadPath = "";
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileLoadPath = openFileDialog.FileName;
                }
                if (File.Exists(fileLoadPath))
                {
                    string loadText = File.ReadAllText(fileLoadPath);
                    string[] strings = loadText.Split('\n');
                    string[] key_s = strings[0].Split('-');
                    string[] IV_s = strings[1].Split('-');

                    byte[] newKey = new byte[key_s.Length];
                    int i = 0;
                    foreach (string s in key_s)
                    {
                        newKey[i++] = byte.Parse(s);
                    }
                    aesKey = newKey;

                    byte[] newIV = new byte[IV_s.Length];
                    i = 0;
                    foreach (string s in IV_s)
                    {
                        newIV[i++] = byte.Parse(s);
                    }
                    aesIV = newIV;

                    textKey.Text = strings[0];
                    textIV.Text = strings[1];
                    MessageBox.Show("Key: " + strings[0] + "\n" + "IV: " + strings[1]);
                }
            }
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            string fileInPath = textInPath.Text;
            string fileOutPath = textOutPath.Text;
            if (File.Exists(fileInPath) && File.Exists(fileOutPath))
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                string inText = File.ReadAllText(fileInPath);

                byte[] encrypted = { 0 };
                if (radioButtonAes.Checked)
                {
                    encrypted = EncryptStringToBytes_Aes(inText, aesKey, aesIV);
                }
                else if (radioButton3Des.Checked)
                {
                    encrypted = EncryptStringToBytes_3Des(inText, tripleDesKey, tripleDesIV);
                }
                int fileOutSize = encrypted.Length;
                textOutFileSize.Text = fileOutSize + " б";
                textOutFileEntropy.Text = shannon(encrypted).ToString();
                File.WriteAllBytes(fileOutPath, encrypted);

                stopwatch.Stop();
                textTime.Text = stopwatch.Elapsed.ToString(@"mm\:ss\.fff");
            }
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            string fileInPath = textInPath.Text;
            string fileOutPath = textOutPath.Text;
            if (File.Exists(fileInPath) && File.Exists(fileOutPath))
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                byte[] inBytes = File.ReadAllBytes(fileInPath);
                string plainText = "";
                try
                {
                    if (radioButtonAes.Checked)
                    {
                        plainText = DecryptStringFromBytes_Aes(inBytes, aesKey, aesIV);
                    }
                    else if (radioButton3Des.Checked)
                    {
                        plainText = DecryptStringFromBytes_3Des(inBytes, tripleDesKey, tripleDesIV);
                    }
                    File.WriteAllText(fileOutPath, plainText);
                }
                catch
                {
                    MessageBox.Show("Не вдалося розшифрувати файл");
                }

                stopwatch.Stop();
                textTime.Text = stopwatch.Elapsed.ToString(@"mm\:ss\.fff");
            }
        }

        static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }
        static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }

        static byte[] EncryptStringToBytes_3Des(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            // Create an Aes object
            // with the specified key and IV.
            using (TripleDES TripleDesAlg = TripleDES.Create())
            {
                TripleDesAlg.Key = Key;
                TripleDesAlg.IV = IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = TripleDesAlg.CreateEncryptor(TripleDesAlg.Key, TripleDesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }
        static string DecryptStringFromBytes_3Des(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an Aes object
            // with the specified key and IV.
            using (TripleDES TripleDesAlg = TripleDES.Create())
            {
                TripleDesAlg.Key = Key;
                TripleDesAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = TripleDesAlg.CreateDecryptor(TripleDesAlg.Key, TripleDesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
