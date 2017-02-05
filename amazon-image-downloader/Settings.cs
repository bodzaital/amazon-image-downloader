using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace amazon_image_downloader
{
    public partial class Settings : Form
    {
        private string userAgent;
        private string accept;

        /// <summary>
        /// Gets the custom user agent from the settings dialog.
        /// </summary>
        public string UserAgent
        {
            get
            {
                return userAgent;
            }
        }

        /// <summary>
        /// Gets the custom http accept header from the settings dialog.
        /// </summary>
        public string Accept
        {
            get
            {
                return accept;
            }
        }

        public Settings(string userAgent, string accept)
        {
            this.userAgent = userAgent;
            this.accept = accept;

            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            UIUserAgent.Text = userAgent;
            UIAccept.Text = accept;

            // Set the cursor at the start of the box so the user isn't confused.
            UIUserAgent.Select(0, 0);
        }

        private void UISave_Click(object sender, EventArgs e)
        {
            // Update the variables, send OK,  then close the form.
            userAgent = UIUserAgent.Text;
            accept = UIAccept.Text;
            DialogResult = DialogResult.OK;
            Dispose();
            Close();
        }
    }
}
