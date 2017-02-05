namespace amazon_image_downloader
{
    partial class Selector
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
            this.UIDisplayImage = new System.Windows.Forms.PictureBox();
            this.UIPrevious = new System.Windows.Forms.Button();
            this.UINext = new System.Windows.Forms.Button();
            this.UIDownload = new System.Windows.Forms.Button();
            this.UIDownloadName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UIDescription = new System.Windows.Forms.Label();
            this.UILargest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UIDisplayImage)).BeginInit();
            this.SuspendLayout();
            // 
            // UIDisplayImage
            // 
            this.UIDisplayImage.Location = new System.Drawing.Point(12, 12);
            this.UIDisplayImage.Name = "UIDisplayImage";
            this.UIDisplayImage.Size = new System.Drawing.Size(375, 375);
            this.UIDisplayImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UIDisplayImage.TabIndex = 0;
            this.UIDisplayImage.TabStop = false;
            // 
            // UIPrevious
            // 
            this.UIPrevious.Location = new System.Drawing.Point(393, 12);
            this.UIPrevious.Name = "UIPrevious";
            this.UIPrevious.Size = new System.Drawing.Size(75, 23);
            this.UIPrevious.TabIndex = 1;
            this.UIPrevious.Text = "Previous";
            this.UIPrevious.UseVisualStyleBackColor = true;
            this.UIPrevious.Click += new System.EventHandler(this.UIPrevious_Click);
            // 
            // UINext
            // 
            this.UINext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UINext.Location = new System.Drawing.Point(515, 12);
            this.UINext.Name = "UINext";
            this.UINext.Size = new System.Drawing.Size(75, 23);
            this.UINext.TabIndex = 2;
            this.UINext.Text = "Next";
            this.UINext.UseVisualStyleBackColor = true;
            this.UINext.Click += new System.EventHandler(this.UINext_Click);
            // 
            // UIDownload
            // 
            this.UIDownload.Location = new System.Drawing.Point(515, 100);
            this.UIDownload.Name = "UIDownload";
            this.UIDownload.Size = new System.Drawing.Size(75, 23);
            this.UIDownload.TabIndex = 3;
            this.UIDownload.Text = "Download";
            this.UIDownload.UseVisualStyleBackColor = true;
            this.UIDownload.Click += new System.EventHandler(this.UIDownload_Click);
            // 
            // UIDownloadName
            // 
            this.UIDownloadName.Location = new System.Drawing.Point(393, 100);
            this.UIDownloadName.Name = "UIDownloadName";
            this.UIDownloadName.Size = new System.Drawing.Size(116, 23);
            this.UIDownloadName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Download name";
            // 
            // UIDescription
            // 
            this.UIDescription.AutoSize = true;
            this.UIDescription.Location = new System.Drawing.Point(393, 155);
            this.UIDescription.Name = "UIDescription";
            this.UIDescription.Size = new System.Drawing.Size(67, 15);
            this.UIDescription.TabIndex = 6;
            this.UIDescription.Text = "Description";
            // 
            // UILargest
            // 
            this.UILargest.AutoSize = true;
            this.UILargest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UILargest.ForeColor = System.Drawing.Color.Green;
            this.UILargest.Location = new System.Drawing.Point(393, 126);
            this.UILargest.Name = "UILargest";
            this.UILargest.Size = new System.Drawing.Size(180, 15);
            this.UILargest.TabIndex = 7;
            this.UILargest.Text = "This image is may be the largest!";
            // 
            // Selector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(602, 399);
            this.Controls.Add(this.UILargest);
            this.Controls.Add(this.UIDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UIDownloadName);
            this.Controls.Add(this.UIDownload);
            this.Controls.Add(this.UINext);
            this.Controls.Add(this.UIPrevious);
            this.Controls.Add(this.UIDisplayImage);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Selector";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select image";
            this.Load += new System.EventHandler(this.Selector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UIDisplayImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox UIDisplayImage;
        private System.Windows.Forms.Button UIPrevious;
        private System.Windows.Forms.Button UINext;
        private System.Windows.Forms.Button UIDownload;
        private System.Windows.Forms.TextBox UIDownloadName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UIDescription;
        private System.Windows.Forms.Label UILargest;
    }
}