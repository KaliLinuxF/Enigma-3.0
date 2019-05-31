namespace Enigma_3._0
{
    partial class Symmetric_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Symmetric_Form));
            this.label_result = new System.Windows.Forms.Label();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.label_utext = new System.Windows.Forms.Label();
            this.textBox_utext = new System.Windows.Forms.TextBox();
            this.textBox_key = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_encrypt = new System.Windows.Forms.Button();
            this.button_decrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_result.Location = new System.Drawing.Point(506, 3);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(138, 27);
            this.label_result.TabIndex = 12;
            this.label_result.Text = "Результат";
            // 
            // textBox_result
            // 
            this.textBox_result.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_result.Location = new System.Drawing.Point(422, 33);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(309, 272);
            this.textBox_result.TabIndex = 7;
            // 
            // label_utext
            // 
            this.label_utext.AutoSize = true;
            this.label_utext.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_utext.Location = new System.Drawing.Point(57, 3);
            this.label_utext.Name = "label_utext";
            this.label_utext.Size = new System.Drawing.Size(194, 27);
            this.label_utext.TabIndex = 10;
            this.label_utext.Text = "Введите текст\r\n";
            // 
            // textBox_utext
            // 
            this.textBox_utext.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_utext.Location = new System.Drawing.Point(12, 33);
            this.textBox_utext.Multiline = true;
            this.textBox_utext.Name = "textBox_utext";
            this.textBox_utext.Size = new System.Drawing.Size(309, 272);
            this.textBox_utext.TabIndex = 1;
            // 
            // textBox_key
            // 
            this.textBox_key.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_key.Location = new System.Drawing.Point(326, 159);
            this.textBox_key.MaxLength = 5;
            this.textBox_key.Name = "textBox_key";
            this.textBox_key.Size = new System.Drawing.Size(94, 21);
            this.textBox_key.TabIndex = 4;
            this.textBox_key.Text = "Введите ключ";
            this.textBox_key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_key.Enter += new System.EventHandler(this.textBox_key_Enter);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Enigma_3._0.Properties.Resources.arrow2;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(347, 98);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 45);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.swap_button);
            // 
            // button_clear
            // 
            this.button_clear.BackgroundImage = global::Enigma_3._0.Properties.Resources.clear;
            this.button_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_clear.Location = new System.Drawing.Point(347, 195);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(48, 45);
            this.button_clear.TabIndex = 5;
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_encrypt
            // 
            this.button_encrypt.BackgroundImage = global::Enigma_3._0.Properties.Resources._lock;
            this.button_encrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_encrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_encrypt.Location = new System.Drawing.Point(337, 33);
            this.button_encrypt.Name = "button_encrypt";
            this.button_encrypt.Size = new System.Drawing.Size(70, 59);
            this.button_encrypt.TabIndex = 2;
            this.button_encrypt.UseVisualStyleBackColor = true;
            this.button_encrypt.Click += new System.EventHandler(this.encrypt_button);
            // 
            // button_decrypt
            // 
            this.button_decrypt.BackgroundImage = global::Enigma_3._0.Properties.Resources.unlock;
            this.button_decrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_decrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_decrypt.Location = new System.Drawing.Point(337, 246);
            this.button_decrypt.Name = "button_decrypt";
            this.button_decrypt.Size = new System.Drawing.Size(70, 59);
            this.button_decrypt.TabIndex = 6;
            this.button_decrypt.UseVisualStyleBackColor = true;
            this.button_decrypt.Click += new System.EventHandler(this.decrypt_button);
            // 
            // Symmetric_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 320);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox_key);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_encrypt);
            this.Controls.Add(this.button_decrypt);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.label_utext);
            this.Controls.Add(this.textBox_utext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Symmetric_Form";
            this.Text = "ENIGMA 3.0 // Симметрия";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Symmetric_Form_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_encrypt;
        private System.Windows.Forms.Button button_decrypt;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Label label_utext;
        private System.Windows.Forms.TextBox textBox_utext;
        private System.Windows.Forms.TextBox textBox_key;
        private System.Windows.Forms.Button button4;
    }
}