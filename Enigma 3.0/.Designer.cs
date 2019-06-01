namespace Enigma_3._0
{
    partial class menu_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_form));
            this.name_label = new System.Windows.Forms.Label();
            this.button_morze = new System.Windows.Forms.Button();
            this.button_symmetric = new System.Windows.Forms.Button();
            this.button_ceaser = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_label.Location = new System.Drawing.Point(103, 29);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(117, 33);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "ENIGMA";
            // 
            // button_morze
            // 
            this.button_morze.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_morze.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_morze.Location = new System.Drawing.Point(86, 209);
            this.button_morze.Name = "button_morze";
            this.button_morze.Size = new System.Drawing.Size(150, 40);
            this.button_morze.TabIndex = 3;
            this.button_morze.Text = "Азбука Морзе";
            this.button_morze.UseVisualStyleBackColor = true;
            this.button_morze.Click += new System.EventHandler(this.Morze);
            // 
            // button_symmetric
            // 
            this.button_symmetric.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_symmetric.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_symmetric.Location = new System.Drawing.Point(86, 144);
            this.button_symmetric.Name = "button_symmetric";
            this.button_symmetric.Size = new System.Drawing.Size(150, 40);
            this.button_symmetric.TabIndex = 2;
            this.button_symmetric.Text = "Симметрическое";
            this.button_symmetric.UseVisualStyleBackColor = true;
            this.button_symmetric.Click += new System.EventHandler(this.Symmetric);
            // 
            // button_ceaser
            // 
            this.button_ceaser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ceaser.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ceaser.Location = new System.Drawing.Point(86, 80);
            this.button_ceaser.Name = "button_ceaser";
            this.button_ceaser.Size = new System.Drawing.Size(150, 40);
            this.button_ceaser.TabIndex = 1;
            this.button_ceaser.Text = "Шифр Цезаря";
            this.button_ceaser.UseVisualStyleBackColor = true;
            this.button_ceaser.Click += new System.EventHandler(this.Ceaser);
            // 
            // exit
            // 
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Location = new System.Drawing.Point(86, 278);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(150, 40);
            this.exit.TabIndex = 4;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // menu_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 354);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.button_symmetric);
            this.Controls.Add(this.button_morze);
            this.Controls.Add(this.button_ceaser);
            this.Controls.Add(this.name_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "menu_form";
            this.Text = "Меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Button button_morze;
        private System.Windows.Forms.Button button_symmetric;
        private System.Windows.Forms.Button button_ceaser;
        private System.Windows.Forms.Button exit;
    }
}