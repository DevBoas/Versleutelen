namespace Versleutelen
{
    partial class Form1
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
            this.TxtBox_User_Input = new System.Windows.Forms.TextBox();
            this.Btn_Encrypt = new System.Windows.Forms.Button();
            this.Btn_Decrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBox_User_Input
            // 
            this.TxtBox_User_Input.Location = new System.Drawing.Point(27, 12);
            this.TxtBox_User_Input.Multiline = true;
            this.TxtBox_User_Input.Name = "TxtBox_User_Input";
            this.TxtBox_User_Input.Size = new System.Drawing.Size(356, 127);
            this.TxtBox_User_Input.TabIndex = 0;
            // 
            // Btn_Encrypt
            // 
            this.Btn_Encrypt.Location = new System.Drawing.Point(27, 145);
            this.Btn_Encrypt.Name = "Btn_Encrypt";
            this.Btn_Encrypt.Size = new System.Drawing.Size(75, 23);
            this.Btn_Encrypt.TabIndex = 1;
            this.Btn_Encrypt.Text = "Encrypt";
            this.Btn_Encrypt.UseVisualStyleBackColor = true;
            this.Btn_Encrypt.Click += new System.EventHandler(this.Btn_Encrypt_Click);
            // 
            // Btn_Decrypt
            // 
            this.Btn_Decrypt.Location = new System.Drawing.Point(308, 145);
            this.Btn_Decrypt.Name = "Btn_Decrypt";
            this.Btn_Decrypt.Size = new System.Drawing.Size(75, 23);
            this.Btn_Decrypt.TabIndex = 2;
            this.Btn_Decrypt.Text = "Decrypt";
            this.Btn_Decrypt.UseVisualStyleBackColor = true;
            this.Btn_Decrypt.Click += new System.EventHandler(this.Btn_Decrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 189);
            this.Controls.Add(this.Btn_Decrypt);
            this.Controls.Add(this.Btn_Encrypt);
            this.Controls.Add(this.TxtBox_User_Input);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Versleutelen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBox_User_Input;
        private System.Windows.Forms.Button Btn_Encrypt;
        private System.Windows.Forms.Button Btn_Decrypt;
    }
}

