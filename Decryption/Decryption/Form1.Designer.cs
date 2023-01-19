namespace Decryption
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.userInput = new System.Windows.Forms.TextBox();
            this.decryptedOutputLabel = new System.Windows.Forms.TextBox();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userInput
            // 
            this.userInput.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userInput.ForeColor = System.Drawing.SystemColors.Highlight;
            this.userInput.Location = new System.Drawing.Point(44, 155);
            this.userInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userInput.Multiline = true;
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(368, 231);
            this.userInput.TabIndex = 5;
            // 
            // decryptedOutputLabel
            // 
            this.decryptedOutputLabel.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.decryptedOutputLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.decryptedOutputLabel.Location = new System.Drawing.Point(463, 155);
            this.decryptedOutputLabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.decryptedOutputLabel.Multiline = true;
            this.decryptedOutputLabel.Name = "decryptedOutputLabel";
            this.decryptedOutputLabel.Size = new System.Drawing.Size(383, 231);
            this.decryptedOutputLabel.TabIndex = 1;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEncrypt.Location = new System.Drawing.Point(309, 441);
            this.buttonEncrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(259, 98);
            this.buttonEncrypt.TabIndex = 2;
            this.buttonEncrypt.Text = "Start Decrypting";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(44, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter your encrypted message!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(463, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(405, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "This is your decrypted message!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 613);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.decryptedOutputLabel);
            this.Controls.Add(this.userInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Decryption App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox userInput;
        private TextBox decryptedOutputLabel;
        private Button buttonEncrypt;
        private Label label1;
        private Label label2;
    }
}