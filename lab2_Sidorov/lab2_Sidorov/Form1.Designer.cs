namespace lab2_Sidorov
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_XOR_Click = new System.Windows.Forms.Button();
            this.groupBox1_Xor_encoder = new System.Windows.Forms.GroupBox();
            this.textBox_C = new System.Windows.Forms.TextBox();
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.textBox_P = new System.Windows.Forms.TextBox();
            this.label_C = new System.Windows.Forms.Label();
            this.label_Key = new System.Windows.Forms.Label();
            this.label_P = new System.Windows.Forms.Label();
            this.button_Clear = new System.Windows.Forms.Button();
            this.label_P_hex = new System.Windows.Forms.Label();
            this.label_P_10 = new System.Windows.Forms.Label();
            this.label_P_2 = new System.Windows.Forms.Label();
            this.label_key_2 = new System.Windows.Forms.Label();
            this.label_key_10 = new System.Windows.Forms.Label();
            this.label_key_hex = new System.Windows.Forms.Label();
            this.label_C_2 = new System.Windows.Forms.Label();
            this.label_C_10 = new System.Windows.Forms.Label();
            this.label_C_hex = new System.Windows.Forms.Label();
            this.textBox_C_OUT = new System.Windows.Forms.TextBox();
            this.textBox_Key_OUT = new System.Windows.Forms.TextBox();
            this.textBox_P_OUT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1_Xor_encoder.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_XOR_Click
            // 
            this.button_XOR_Click.Location = new System.Drawing.Point(155, 235);
            this.button_XOR_Click.Name = "button_XOR_Click";
            this.button_XOR_Click.Size = new System.Drawing.Size(75, 23);
            this.button_XOR_Click.TabIndex = 0;
            this.button_XOR_Click.Text = "XOR";
            this.button_XOR_Click.UseVisualStyleBackColor = true;
            this.button_XOR_Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1_Xor_encoder
            // 
            this.groupBox1_Xor_encoder.Controls.Add(this.label3);
            this.groupBox1_Xor_encoder.Controls.Add(this.label2);
            this.groupBox1_Xor_encoder.Controls.Add(this.label1);
            this.groupBox1_Xor_encoder.Controls.Add(this.textBox_P_OUT);
            this.groupBox1_Xor_encoder.Controls.Add(this.textBox_Key_OUT);
            this.groupBox1_Xor_encoder.Controls.Add(this.textBox_C_OUT);
            this.groupBox1_Xor_encoder.Controls.Add(this.label_C_2);
            this.groupBox1_Xor_encoder.Controls.Add(this.label_C_10);
            this.groupBox1_Xor_encoder.Controls.Add(this.label_C_hex);
            this.groupBox1_Xor_encoder.Controls.Add(this.label_key_2);
            this.groupBox1_Xor_encoder.Controls.Add(this.label_key_10);
            this.groupBox1_Xor_encoder.Controls.Add(this.label_key_hex);
            this.groupBox1_Xor_encoder.Controls.Add(this.label_P_2);
            this.groupBox1_Xor_encoder.Controls.Add(this.label_P_10);
            this.groupBox1_Xor_encoder.Controls.Add(this.label_P_hex);
            this.groupBox1_Xor_encoder.Controls.Add(this.textBox_C);
            this.groupBox1_Xor_encoder.Controls.Add(this.textBox_Key);
            this.groupBox1_Xor_encoder.Controls.Add(this.textBox_P);
            this.groupBox1_Xor_encoder.Controls.Add(this.label_C);
            this.groupBox1_Xor_encoder.Controls.Add(this.label_Key);
            this.groupBox1_Xor_encoder.Controls.Add(this.label_P);
            this.groupBox1_Xor_encoder.Controls.Add(this.button_Clear);
            this.groupBox1_Xor_encoder.Controls.Add(this.button_XOR_Click);
            this.groupBox1_Xor_encoder.Location = new System.Drawing.Point(12, 21);
            this.groupBox1_Xor_encoder.Name = "groupBox1_Xor_encoder";
            this.groupBox1_Xor_encoder.Size = new System.Drawing.Size(600, 278);
            this.groupBox1_Xor_encoder.TabIndex = 1;
            this.groupBox1_Xor_encoder.TabStop = false;
            this.groupBox1_Xor_encoder.Text = "XOR Encoder";
            // 
            // textBox_C
            // 
            this.textBox_C.Location = new System.Drawing.Point(130, 183);
            this.textBox_C.Name = "textBox_C";
            this.textBox_C.Size = new System.Drawing.Size(100, 22);
            this.textBox_C.TabIndex = 7;
            this.textBox_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_Key
            // 
            this.textBox_Key.Location = new System.Drawing.Point(130, 101);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.Size = new System.Drawing.Size(100, 22);
            this.textBox_Key.TabIndex = 6;
            this.textBox_Key.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_P
            // 
            this.textBox_P.Location = new System.Drawing.Point(130, 37);
            this.textBox_P.Name = "textBox_P";
            this.textBox_P.Size = new System.Drawing.Size(100, 22);
            this.textBox_P.TabIndex = 5;
            this.textBox_P.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_C
            // 
            this.label_C.AutoSize = true;
            this.label_C.Location = new System.Drawing.Point(50, 186);
            this.label_C.Name = "label_C";
            this.label_C.Size = new System.Drawing.Size(26, 16);
            this.label_C.TabIndex = 4;
            this.label_C.Text = "C =";
            // 
            // label_Key
            // 
            this.label_Key.AutoSize = true;
            this.label_Key.Location = new System.Drawing.Point(50, 107);
            this.label_Key.Name = "label_Key";
            this.label_Key.Size = new System.Drawing.Size(40, 16);
            this.label_Key.TabIndex = 3;
            this.label_Key.Text = "Key =";
            // 
            // label_P
            // 
            this.label_P.AutoSize = true;
            this.label_P.Location = new System.Drawing.Point(50, 43);
            this.label_P.Name = "label_P";
            this.label_P.Size = new System.Drawing.Size(26, 16);
            this.label_P.TabIndex = 2;
            this.label_P.Text = "P =";
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(261, 235);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_Clear.TabIndex = 1;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // label_P_hex
            // 
            this.label_P_hex.AutoSize = true;
            this.label_P_hex.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label_P_hex.Location = new System.Drawing.Point(258, 18);
            this.label_P_hex.Name = "label_P_hex";
            this.label_P_hex.Size = new System.Drawing.Size(28, 16);
            this.label_P_hex.TabIndex = 8;
            this.label_P_hex.Text = "hex";
            this.label_P_hex.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_P_10
            // 
            this.label_P_10.AutoSize = true;
            this.label_P_10.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label_P_10.Location = new System.Drawing.Point(258, 37);
            this.label_P_10.Name = "label_P_10";
            this.label_P_10.Size = new System.Drawing.Size(30, 16);
            this.label_P_10.TabIndex = 9;
            this.label_P_10.Text = "dec";
            this.label_P_10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_P_2
            // 
            this.label_P_2.AutoSize = true;
            this.label_P_2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label_P_2.Location = new System.Drawing.Point(258, 57);
            this.label_P_2.Name = "label_P_2";
            this.label_P_2.Size = new System.Drawing.Size(25, 16);
            this.label_P_2.TabIndex = 10;
            this.label_P_2.Text = "bin";
            this.label_P_2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_key_2
            // 
            this.label_key_2.AutoSize = true;
            this.label_key_2.Location = new System.Drawing.Point(258, 129);
            this.label_key_2.Name = "label_key_2";
            this.label_key_2.Size = new System.Drawing.Size(25, 16);
            this.label_key_2.TabIndex = 13;
            this.label_key_2.Text = "bin";
            this.label_key_2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_key_10
            // 
            this.label_key_10.AutoSize = true;
            this.label_key_10.Location = new System.Drawing.Point(258, 109);
            this.label_key_10.Name = "label_key_10";
            this.label_key_10.Size = new System.Drawing.Size(30, 16);
            this.label_key_10.TabIndex = 12;
            this.label_key_10.Text = "dec";
            this.label_key_10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_key_hex
            // 
            this.label_key_hex.AutoSize = true;
            this.label_key_hex.Location = new System.Drawing.Point(258, 90);
            this.label_key_hex.Name = "label_key_hex";
            this.label_key_hex.Size = new System.Drawing.Size(28, 16);
            this.label_key_hex.TabIndex = 11;
            this.label_key_hex.Text = "hex";
            this.label_key_hex.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_C_2
            // 
            this.label_C_2.AutoSize = true;
            this.label_C_2.Location = new System.Drawing.Point(258, 203);
            this.label_C_2.Name = "label_C_2";
            this.label_C_2.Size = new System.Drawing.Size(25, 16);
            this.label_C_2.TabIndex = 16;
            this.label_C_2.Text = "bin";
            this.label_C_2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_C_10
            // 
            this.label_C_10.AutoSize = true;
            this.label_C_10.Location = new System.Drawing.Point(258, 183);
            this.label_C_10.Name = "label_C_10";
            this.label_C_10.Size = new System.Drawing.Size(30, 16);
            this.label_C_10.TabIndex = 15;
            this.label_C_10.Text = "dec";
            this.label_C_10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_C_hex
            // 
            this.label_C_hex.AutoSize = true;
            this.label_C_hex.Location = new System.Drawing.Point(258, 164);
            this.label_C_hex.Name = "label_C_hex";
            this.label_C_hex.Size = new System.Drawing.Size(28, 16);
            this.label_C_hex.TabIndex = 14;
            this.label_C_hex.Text = "hex";
            this.label_C_hex.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox_C_OUT
            // 
            this.textBox_C_OUT.Location = new System.Drawing.Point(423, 43);
            this.textBox_C_OUT.Name = "textBox_C_OUT";
            this.textBox_C_OUT.Size = new System.Drawing.Size(100, 22);
            this.textBox_C_OUT.TabIndex = 17;
            // 
            // textBox_Key_OUT
            // 
            this.textBox_Key_OUT.Location = new System.Drawing.Point(423, 101);
            this.textBox_Key_OUT.Name = "textBox_Key_OUT";
            this.textBox_Key_OUT.Size = new System.Drawing.Size(100, 22);
            this.textBox_Key_OUT.TabIndex = 18;
            // 
            // textBox_P_OUT
            // 
            this.textBox_P_OUT.Location = new System.Drawing.Point(423, 177);
            this.textBox_P_OUT.Name = "textBox_P_OUT";
            this.textBox_P_OUT.Size = new System.Drawing.Size(100, 22);
            this.textBox_P_OUT.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "= С";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "= Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "= P";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 325);
            this.Controls.Add(this.groupBox1_Xor_encoder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1_Xor_encoder.ResumeLayout(false);
            this.groupBox1_Xor_encoder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_XOR_Click;
        private System.Windows.Forms.GroupBox groupBox1_Xor_encoder;
        private System.Windows.Forms.TextBox textBox_C;
        private System.Windows.Forms.TextBox textBox_Key;
        private System.Windows.Forms.TextBox textBox_P;
        private System.Windows.Forms.Label label_C;
        private System.Windows.Forms.Label label_Key;
        private System.Windows.Forms.Label label_P;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Label label_C_2;
        private System.Windows.Forms.Label label_C_10;
        private System.Windows.Forms.Label label_C_hex;
        private System.Windows.Forms.Label label_key_2;
        private System.Windows.Forms.Label label_key_10;
        private System.Windows.Forms.Label label_key_hex;
        private System.Windows.Forms.Label label_P_2;
        private System.Windows.Forms.Label label_P_10;
        private System.Windows.Forms.Label label_P_hex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_P_OUT;
        private System.Windows.Forms.TextBox textBox_Key_OUT;
        private System.Windows.Forms.TextBox textBox_C_OUT;
    }
}

