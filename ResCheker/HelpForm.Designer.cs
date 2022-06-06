
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.emailText = new System.Windows.Forms.TextBox();
            this.messageText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(145, 63);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Отослать";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(23, 63);
            this.emailText.Name = "emailText";
            this.emailText.PlaceholderText = "email";
            this.emailText.Size = new System.Drawing.Size(116, 23);
            this.emailText.TabIndex = 1;
            // 
            // messageText
            // 
            this.messageText.Location = new System.Drawing.Point(23, 92);
            this.messageText.Multiline = true;
            this.messageText.Name = "messageText";
            this.messageText.PlaceholderText = "Message...";
            this.messageText.Size = new System.Drawing.Size(197, 182);
            this.messageText.TabIndex = 2;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 293);
            this.Controls.Add(this.messageText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.metroButton1);
            this.Name = "HelpForm";
            this.Text = "Помощь";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox messageText;
    }
}