namespace Enigma_3._0
{
    partial class Ceaser_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ceaser_Form));
            this.button_swap = new System.Windows.Forms.Button();
            this.textBox_key = new System.Windows.Forms.TextBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_encrypt = new System.Windows.Forms.Button();
            this.button_decrypt = new System.Windows.Forms.Button();
            this.label_result = new System.Windows.Forms.Label();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.label_text = new System.Windows.Forms.Label();
            this.textBox_utext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_swap
            // 
            this.button_swap.BackgroundImage = global::Enigma_3._0.Properties.Resources.arrow2;
            this.button_swap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_swap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_swap.Location = new System.Drawing.Point(347, 97);
            this.button_swap.Name = "button_swap";
            this.button_swap.Size = new System.Drawing.Size(48, 45);
            this.button_swap.TabIndex = 3;
            this.button_swap.UseVisualStyleBackColor = true;
            this.button_swap.Click += new System.EventHandler(this.swap_button);
            // 
            // textBox_key
            // 
            this.textBox_key.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_key.Location = new System.Drawing.Point(326, 158);
            this.textBox_key.MaxLength = 2;
            this.textBox_key.Name = "textBox_key";
            this.textBox_key.Size = new System.Drawing.Size(94, 21);
            this.textBox_key.TabIndex = 4;
            this.textBox_key.Text = "Введите ключ";
            this.textBox_key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_key.Enter += new System.EventHandler(this.textBox_result_Enter);
            // 
            // button_clear
            // 
            this.button_clear.BackgroundImage = global::Enigma_3._0.Properties.Resources.clear;
            this.button_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_clear.Location = new System.Drawing.Point(347, 194);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(48, 45);
            this.button_clear.TabIndex = 5;
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.Clear_button);
            // 
            // button_encrypt
            // 
            this.button_encrypt.BackgroundImage = global::Enigma_3._0.Properties.Resources._lock;
            this.button_encrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_encrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_encrypt.Location = new System.Drawing.Point(337, 32);
            this.button_encrypt.Name = "button_encrypt";
            this.button_encrypt.Size = new System.Drawing.Size(70, 59);
            this.button_encrypt.TabIndex = 2;
            this.button_encrypt.UseVisualStyleBackColor = true;
            this.button_encrypt.Click += new System.EventHandler(this.Encrypt_button);
            // 
            // button_decrypt
            // 
            this.button_decrypt.BackgroundImage = global::Enigma_3._0.Properties.Resources.unlock;
            this.button_decrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_decrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_decrypt.Location = new System.Drawing.Point(337, 245);
            this.button_decrypt.Name = "button_decrypt";
            this.button_decrypt.Size = new System.Drawing.Size(70, 59);
            this.button_decrypt.TabIndex = 6;
            this.button_decrypt.UseVisualStyleBackColor = true;
            this.button_decrypt.Click += new System.EventHandler(this.decrypt_button);
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_result.Location = new System.Drawing.Point(506, 2);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(138, 27);
            this.label_result.TabIndex = 23;
            this.label_result.Text = "Результат";
            // 
            // textBox_result
            // 
            this.textBox_result.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_result.Location = new System.Drawing.Point(422, 32);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(309, 272);
            this.textBox_result.TabIndex = 7;
            this.textBox_result.Enter += new System.EventHandler(this.textBox_result_Enter);
            // 
            // label_text
            // 
            this.label_text.AutoSize = true;
            this.label_text.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_text.Location = new System.Drawing.Point(57, 2);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(194, 27);
            this.label_text.TabIndex = 21;
            this.label_text.Text = "Введите текст\r\n";
            // 
            // textBox_utext
            // 
            this.textBox_utext.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_utext.Location = new System.Drawing.Point(12, 32);
            this.textBox_utext.Multiline = true;
            this.textBox_utext.Name = "textBox_utext";
            this.textBox_utext.Size = new System.Drawing.Size(309, 272);
            this.textBox_utext.TabIndex = 1;
            // 
            // Ceaser_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 317);
            this.Controls.Add(this.button_swap);
            this.Controls.Add(this.textBox_key);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_encrypt);
            this.Controls.Add(this.button_decrypt);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.label_text);
            this.Controls.Add(this.textBox_utext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ceaser_Form";
            this.Text = "ENIGMA 3.0 // Цезарь";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ceaser_Form_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_swap;
        private System.Windows.Forms.TextBox textBox_key;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_encrypt;
        private System.Windows.Forms.Button button_decrypt;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Label label_text;
        private System.Windows.Forms.TextBox textBox_utext;
    }
}

