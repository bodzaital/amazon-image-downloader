namespace amazon_image_downloader
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.UIAmazonURL = new System.Windows.Forms.TextBox();
            this.UISnitch = new System.Windows.Forms.Button();
            this.UISettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amazon URL:";
            // 
            // UIAmazonURL
            // 
            this.UIAmazonURL.Location = new System.Drawing.Point(95, 12);
            this.UIAmazonURL.Name = "UIAmazonURL";
            this.UIAmazonURL.Size = new System.Drawing.Size(434, 23);
            this.UIAmazonURL.TabIndex = 1;
            // 
            // UISnitch
            // 
            this.UISnitch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UISnitch.Location = new System.Drawing.Point(454, 41);
            this.UISnitch.Name = "UISnitch";
            this.UISnitch.Size = new System.Drawing.Size(75, 23);
            this.UISnitch.TabIndex = 2;
            this.UISnitch.Text = "Snitch";
            this.UISnitch.UseVisualStyleBackColor = true;
            this.UISnitch.Click += new System.EventHandler(this.UISnitch_Click);
            // 
            // UISettings
            // 
            this.UISettings.Location = new System.Drawing.Point(373, 41);
            this.UISettings.Name = "UISettings";
            this.UISettings.Size = new System.Drawing.Size(75, 23);
            this.UISettings.TabIndex = 3;
            this.UISettings.Text = "Settings";
            this.UISettings.UseVisualStyleBackColor = true;
            this.UISettings.Click += new System.EventHandler(this.UISettings_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(541, 74);
            this.Controls.Add(this.UISettings);
            this.Controls.Add(this.UISnitch);
            this.Controls.Add(this.UIAmazonURL);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AID: Ready";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UIAmazonURL;
        private System.Windows.Forms.Button UISnitch;
        private System.Windows.Forms.Button UISettings;
    }
}

