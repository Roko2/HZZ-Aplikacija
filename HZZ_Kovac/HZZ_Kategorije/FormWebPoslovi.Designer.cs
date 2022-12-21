
namespace HZZ_Kategorije
{
    partial class FormWebPoslovi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWebPoslovi));
            this.webPoslovi = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webPoslovi
            // 
            this.webPoslovi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webPoslovi.Location = new System.Drawing.Point(0, 0);
            this.webPoslovi.MinimumSize = new System.Drawing.Size(20, 20);
            this.webPoslovi.Name = "webPoslovi";
            this.webPoslovi.ScriptErrorsSuppressed = true;
            this.webPoslovi.Size = new System.Drawing.Size(1493, 690);
            this.webPoslovi.TabIndex = 0;
            // 
            // FormWebPoslovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 690);
            this.Controls.Add(this.webPoslovi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormWebPoslovi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Web stranica radnog mjesta";
            this.Load += new System.EventHandler(this.FormWebPoslovi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webPoslovi;
    }
}