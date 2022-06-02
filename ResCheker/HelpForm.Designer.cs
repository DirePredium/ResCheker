
namespace ResCheker
{
    partial class HelpForm
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
            this.emailText = new System.Windows.Forms.TextBox();
            this.messageText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailText
            // 
            this.emailText.AccessibleDescription = "";
            this.emailText.Location = new System.Drawing.Point(13, 13);
            this.emailText.Name = "emailText";
            this.emailText.PlaceholderText = "Ваша почта";
            this.emailText.Size = new System.Drawing.Size(100, 23);
            this.emailText.TabIndex = 0;
            // 
            // messageText
            // 
            this.messageText.Location = new System.Drawing.Point(13, 42);
            this.messageText.Multiline = true;
            this.messageText.Name = "messageText";
            this.messageText.PlaceholderText = "Сообщение...";
            this.messageText.Size = new System.Drawing.Size(261, 177);
            this.messageText.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Отправить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 233);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.messageText);
            this.Controls.Add(this.emailText);
            this.Name = "HelpForm";
            this.Text = "HelpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox messageText;
        private System.Windows.Forms.Button button1;
    }
}