namespace Zadanie1_Lab3
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        private void InitializeComponent()
        {
            this.comboBoxAlgorithm = new System.Windows.Forms.ComboBox();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.textBoxIV = new System.Windows.Forms.TextBox();
            this.buttonGenerateKeyIV = new System.Windows.Forms.Button();
            this.textBoxPlainTextASCII = new System.Windows.Forms.TextBox();
            this.textBoxPlainTextHex = new System.Windows.Forms.TextBox();
            this.textBoxCipherTextASCII = new System.Windows.Forms.TextBox();
            this.textBoxCipherTextHex = new System.Windows.Forms.TextBox();
            this.textBoxDecryptTime = new System.Windows.Forms.TextBox();
            this.textBoxEncryptTime = new System.Windows.Forms.TextBox();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonEncryptTime = new System.Windows.Forms.Button();
            this.buttonDecryptTime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxAlgorithm
            // 
            this.comboBoxAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlgorithm.FormattingEnabled = true;
            this.comboBoxAlgorithm.Location = new System.Drawing.Point(12, 12);
            this.comboBoxAlgorithm.Name = "comboBoxAlgorithm";
            this.comboBoxAlgorithm.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAlgorithm.TabIndex = 0;
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(150, 12);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(300, 20);
            this.textBoxKey.TabIndex = 1;
            // 
            // textBoxIV
            // 
            this.textBoxIV.Location = new System.Drawing.Point(150, 38);
            this.textBoxIV.Name = "textBoxIV";
            this.textBoxIV.Size = new System.Drawing.Size(300, 20);
            this.textBoxIV.TabIndex = 2;
            // 
            // buttonGenerateKeyIV
            // 
            this.buttonGenerateKeyIV.Location = new System.Drawing.Point(12, 39);
            this.buttonGenerateKeyIV.Name = "buttonGenerateKeyIV";
            this.buttonGenerateKeyIV.Size = new System.Drawing.Size(121, 23);
            this.buttonGenerateKeyIV.TabIndex = 3;
            this.buttonGenerateKeyIV.Text = "Generate Key and IV";
            this.buttonGenerateKeyIV.UseVisualStyleBackColor = true;
            this.buttonGenerateKeyIV.Click += new System.EventHandler(this.buttonGenerateKeyIV_Click);
            // 
            // textBoxPlainTextASCII
            // 
            this.textBoxPlainTextASCII.Location = new System.Drawing.Point(150, 67);
            this.textBoxPlainTextASCII.Name = "textBoxPlainTextASCII";
            this.textBoxPlainTextASCII.Size = new System.Drawing.Size(300, 20);
            this.textBoxPlainTextASCII.TabIndex = 4;
            // 
            // textBoxPlainTextHex
            // 
            this.textBoxPlainTextHex.Location = new System.Drawing.Point(150, 93);
            this.textBoxPlainTextHex.Name = "textBoxPlainTextHex";
            this.textBoxPlainTextHex.Size = new System.Drawing.Size(300, 20);
            this.textBoxPlainTextHex.TabIndex = 5;
            // 
            // textBoxCipherTextASCII
            // 
            this.textBoxCipherTextASCII.Location = new System.Drawing.Point(150, 119);
            this.textBoxCipherTextASCII.Name = "textBoxCipherTextASCII";
            this.textBoxCipherTextASCII.Size = new System.Drawing.Size(300, 20);
            this.textBoxCipherTextASCII.TabIndex = 6;
            // 
            // textBoxCipherTextHex
            // 
            this.textBoxCipherTextHex.Location = new System.Drawing.Point(150, 145);
            this.textBoxCipherTextHex.Name = "textBoxCipherTextHex";
            this.textBoxCipherTextHex.Size = new System.Drawing.Size(300, 20);
            this.textBoxCipherTextHex.TabIndex = 7;
            // 
            // textBoxDecryptTime
            // 
            this.textBoxDecryptTime.Location = new System.Drawing.Point(150, 197);
            this.textBoxDecryptTime.Name = "textBoxDecryptTime";
            this.textBoxDecryptTime.Size = new System.Drawing.Size(300, 20);
            this.textBoxDecryptTime.TabIndex = 8;
            // 
            // textBoxEncryptTime
            // 
            this.textBoxEncryptTime.Location = new System.Drawing.Point(150, 171);
            this.textBoxEncryptTime.Name = "textBoxEncryptTime";
            this.textBoxEncryptTime.Size = new System.Drawing.Size(300, 20);
            this.textBoxEncryptTime.TabIndex = 9;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(12, 68);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(121, 23);
            this.buttonEncrypt.TabIndex = 10;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(12, 94);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(121, 23);
            this.buttonDecrypt.TabIndex = 11;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // buttonEncryptTime
            // 
            this.buttonEncryptTime.Location = new System.Drawing.Point(12, 123);
            this.buttonEncryptTime.Name = "buttonEncryptTime";
            this.buttonEncryptTime.Size = new System.Drawing.Size(121, 23);
            this.buttonEncryptTime.TabIndex = 12;
            this.buttonEncryptTime.Text = "Encrypt Time";
            this.buttonEncryptTime.UseVisualStyleBackColor = true;
            this.buttonEncryptTime.Click += new System.EventHandler(this.buttonEncryptTime_Click);
            // 
            // buttonDecryptTime
            // 
            this.buttonDecryptTime.Location = new System.Drawing.Point(12, 149);
            this.buttonDecryptTime.Name = "buttonDecryptTime";
            this.buttonDecryptTime.Size = new System.Drawing.Size(121, 23);
            this.buttonDecryptTime.TabIndex = 13;
            this.buttonDecryptTime.Text = "Decrypt Time";
            this.buttonDecryptTime.UseVisualStyleBackColor = true;
            this.buttonDecryptTime.Click += new System.EventHandler(this.buttonDecryptTime_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(712, 400);
            this.Controls.Add(this.buttonDecryptTime);
            this.Controls.Add(this.buttonEncryptTime);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.textBoxEncryptTime);
            this.Controls.Add(this.textBoxDecryptTime);
            this.Controls.Add(this.textBoxCipherTextHex);
            this.Controls.Add(this.textBoxCipherTextASCII);
            this.Controls.Add(this.textBoxPlainTextHex);
            this.Controls.Add(this.textBoxPlainTextASCII);
            this.Controls.Add(this.buttonGenerateKeyIV);
            this.Controls.Add(this.textBoxIV);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.comboBoxAlgorithm);
            this.Name = "Form1";
            this.Text = "Symmetric Encryption";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAlgorithm;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.TextBox textBoxIV;
        private System.Windows.Forms.Button buttonGenerateKeyIV;
        private System.Windows.Forms.TextBox textBoxPlainTextASCII;
        private System.Windows.Forms.TextBox textBoxPlainTextHex;
        private System.Windows.Forms.TextBox textBoxCipherTextASCII;
        private System.Windows.Forms.TextBox textBoxCipherTextHex;
        private System.Windows.Forms.TextBox textBoxDecryptTime;
        private System.Windows.Forms.TextBox textBoxEncryptTime;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonEncryptTime;
        private System.Windows.Forms.Button buttonDecryptTime;
    }
}
