using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace amazon_image_downloader
{
    public partial class Main : Form
    {
        private string userAgent, accept;

        public Main()
        {
            userAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/56.0.2924.87 Safari/537.36";
            accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";

            InitializeComponent();
        }

        private void UISnitch_Click(object sender, EventArgs e)
        {
            Text = "AID: Working...";

            string htmlSourceCode;

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", accept);
                client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", userAgent);

                using (HttpResponseMessage response = client.GetAsync(UIAmazonURL.Text).Result)
                {
                    using (HttpContent content = response.Content)
                    {
                        htmlSourceCode = content.ReadAsStringAsync().Result;
                    }
                }
            }

            string beginning = htmlSourceCode.Substring(htmlSourceCode.IndexOf("'colorImages'"));
            string endString = beginning.Substring(0, beginning.IndexOf("</script>"));

            Regex rule = new Regex("https?://([\\w+?\\.\\w+])+([a-zA-Z0-9\\~\\!\\@\\#\\$\\%\\^\\&amp;\\*\\(\\)_\\-\\=\\+\\\\\\/\\?\\.\\:\\;\\'\\,]*)?", RegexOptions.IgnoreCase);
            MatchCollection urls = rule.Matches(endString);

            Text = "AID: Ready";

            Selector mySelector1 = new Selector(urls);

            mySelector1.Show();
        }

        private void UISettings_Click(object sender, EventArgs e)
        {
            Settings mySettings1 = new Settings(userAgent, accept);

            mySettings1.ShowDialog();

            // Get the values from the settings dialog.
            if (mySettings1.DialogResult == DialogResult.OK)
            {
                userAgent = mySettings1.UserAgent;
                accept = mySettings1.Accept;
            }
        }
    }
}
