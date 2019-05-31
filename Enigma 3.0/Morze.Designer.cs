namespace Enigma_3._0
{
    partial class Morze
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Morze));
            this.label_result = new System.Windows.Forms.Label();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.label_text = new System.Windows.Forms.Label();
            this.textBox_utext = new System.Windows.Forms.TextBox();
            this.radioButton_rus = new System.Windows.Forms.RadioButton();
            this.radioButton_eng = new System.Windows.Forms.RadioButton();
            this.button_swap = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_encrypt = new System.Windows.Forms.Button();
            this.button_decrypt = new System.Windows.Forms.Button();
            this.panel_lang = new System.Windows.Forms.Panel();
            this.panel_lang.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_result.Location = new System.Drawing.Point(501, 3);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(138, 27);
            this.label_result.TabIndex = 32;
            this.label_result.Text = "Результат";
            // 
            // textBox_result
            // 
            this.textBox_result.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_result.Location = new System.Drawing.Point(417, 33);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(309, 285);
            this.textBox_result.TabIndex = 8;
            // 
            // label_text
            // 
            this.label_text.AutoSize = true;
            this.label_text.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_text.Location = new System.Drawing.Point(52, 3);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(194, 27);
            this.label_text.TabIndex = 30;
            this.label_text.Text = "Введите текст\r\n";
            // 
            // textBox_utext
            // 
            this.textBox_utext.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_utext.Location = new System.Drawing.Point(7, 33);
            this.textBox_utext.Multiline = true;
            this.textBox_utext.Name = "textBox_utext";
            this.textBox_utext.Size = new System.Drawing.Size(309, 285);
            this.textBox_utext.TabIndex = 1;
            // 
            // radioButton_rus
            // 
            this.radioButton_rus.AutoSize = true;
            this.radioButton_rus.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_rus.Location = new System.Drawing.Point(8, 3);
            this.radioButton_rus.Name = "radioButton_rus";
            this.radioButton_rus.Size = new System.Drawing.Size(74, 19);
            this.radioButton_rus.TabIndex = 4;
            this.radioButton_rus.Text = "Русский";
            this.radioButton_rus.UseVisualStyleBackColor = true;
            this.radioButton_rus.CheckedChanged += new System.EventHandler(this.radioButton_rus_CheckedChanged);
            // 
            // radioButton_eng
            // 
            this.radioButton_eng.AutoSize = true;
            this.radioButton_eng.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_eng.Location = new System.Drawing.Point(8, 24);
            this.radioButton_eng.Name = "radioButton_eng";
            this.radioButton_eng.Size = new System.Drawing.Size(74, 19);
            this.radioButton_eng.TabIndex = 5;
            this.radioButton_eng.Text = "English";
            this.radioButton_eng.UseVisualStyleBackColor = true;
            this.radioButton_eng.CheckedChanged += new System.EventHandler(this.radioButton_eng_CheckedChanged);
            // 
            // button_swap
            // 
            this.button_swap.BackgroundImage = global::Enigma_3._0.Properties.Resources.arrow2;
            this.button_swap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_swap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_swap.Location = new System.Drawing.Point(342, 98);
            this.button_swap.Name = "button_swap";
            this.button_swap.Size = new System.Drawing.Size(48, 45);
            this.button_swap.TabIndex = 3;
            this.button_swap.UseVisualStyleBackColor = true;
            this.button_swap.Click += new System.EventHandler(this.button_swap_Click);
            // 
            // button_clear
            // 
            this.button_clear.BackgroundImage = global::Enigma_3._0.Properties.Resources.clear;
            this.button_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_clear.Location = new System.Drawing.Point(342, 208);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(48, 45);
            this.button_clear.TabIndex = 6;
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_encrypt
            // 
            this.button_encrypt.BackgroundImage = global::Enigma_3._0.Properties.Resources._lock;
            this.button_encrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_encrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_encrypt.Location = new System.Drawing.Point(332, 33);
            this.button_encrypt.Name = "button_encrypt";
            this.button_encrypt.Size = new System.Drawing.Size(70, 59);
            this.button_encrypt.TabIndex = 2;
            this.button_encrypt.UseVisualStyleBackColor = true;
            this.button_encrypt.Click += new System.EventHandler(this.button_encrypt_Click);
            // 
            // button_decrypt
            // 
            this.button_decrypt.BackgroundImage = global::Enigma_3._0.Properties.Resources.unlock;
            this.button_decrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_decrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_decrypt.Location = new System.Drawing.Point(332, 259);
            this.button_decrypt.Name = "button_decrypt";
            this.button_decrypt.Size = new System.Drawing.Size(70, 59);
            this.button_decrypt.TabIndex = 7;
            this.button_decrypt.UseVisualStyleBackColor = true;
            this.button_decrypt.Click += new System.EventHandler(this.button_decrypt_Click);
            // 
            // panel_lang
            // 
            this.panel_lang.Controls.Add(this.radioButton_eng);
            this.panel_lang.Controls.Add(this.radioButton_rus);
            this.panel_lang.Location = new System.Drawing.Point(323, 152);
            this.panel_lang.Name = "panel_lang";
            this.panel_lang.Size = new System.Drawing.Size(87, 49);
            this.panel_lang.TabIndex = 40;
            // 
            // Morze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 330);
            this.Controls.Add(this.panel_lang);
            this.Controls.Add(this.button_swap);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_encrypt);
            this.Controls.Add(this.button_decrypt);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.label_text);
            this.Controls.Add(this.textBox_utext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Morze";
            this.Text = "ENIGMA 3.0 // Морзе";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Morze_FormClosed);
            this.panel_lang.ResumeLayout(false);
            this.panel_lang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_swap;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_encrypt;
        private System.Windows.Forms.Button button_decrypt;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Label label_text;
        private System.Windows.Forms.TextBox textBox_utext;
        private System.Windows.Forms.RadioButton radioButton_rus;
        private System.Windows.Forms.RadioButton radioButton_eng;
        private System.Windows.Forms.Panel panel_lang;
    }
}