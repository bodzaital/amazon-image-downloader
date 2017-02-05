namespace amazon_image_downloader
{
    partial class Settings
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
            this.UIUserAgent = new System.Windows.Forms.TextBox();
            this.UIAccept = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UISave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "User-Agent request-header";
            // 
            // UIUserAgent
            // 
            this.UIUserAgent.Location = new System.Drawing.Point(15, 27);
            this.UIUserAgent.Name = "UIUserAgent";
            this.UIUserAgent.Size = new System.Drawing.Size(379, 23);
            this.UIUserAgent.TabIndex = 1;
            // 
            // UIAccept
            // 
            this.UIAccept.Location = new System.Drawing.Point(15, 89);
            this.UIAccept.Name = "UIAccept";
            this.UIAccept.Size = new System.Drawing.Size(379, 23);
            this.UIAccept.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Accept request-header";
            // 
            // UISave
            // 
            this.UISave.Location = new System.Drawing.Point(319, 134);
            this.UISave.Name = "UISave";
            this.UISave.Size = new System.Drawing.Size(75, 23);
            this.UISave.TabIndex = 4;
            this.UISave.Text = "Save";
            this.UISave.UseVisualStyleBackColor = true;
            this.UISave.Click += new System.EventHandler(this.UISave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Its not recommended you change these.";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(406, 163);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UISave);
            this.Controls.Add(this.UIAccept);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UIUserAgent);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UIUserAgent;
        private System.Windows.Forms.TextBox UIAccept;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UISave;
        private System.Windows.Forms.Label label3;
    }
}