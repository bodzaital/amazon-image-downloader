using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace amazon_image_downloader
{
    public partial class Selector : Form
    {

        MatchCollection urls;
        int pointer = 1;

        enum Direction
        {
            Up,
            Down
        }

        public Selector(MatchCollection urls)
        {
            this.urls = urls;

            InitializeComponent();
        }

        private void Selector_Load(object sender, EventArgs e)
        {
            Count(Direction.Down);
        }

        private void UINext_Click(object sender, EventArgs e)
        {
            Count(Direction.Up);
        }

        private void UIDownload_Click(object sender, EventArgs e)
        {
            if (UIDownloadName.Text.IndexOfAny(new char[] {'<', '>', ':', '"', '/', '\\', '|', '?', '*' }) != -1 || UIDownloadName.Text == "")
            {
                // The user wanted to input illegal character in filename.
                MessageBox.Show("The filename contains invalid characters (<, >, :, \", /, \\, |, ?, *).", "User error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile(urls[pointer].Value, UIDownloadName.Text + ".png");
            }
        }

        private void UIPrevious_Click(object sender, EventArgs e)
        {
            Count(Direction.Down);
        }

        private void Count(Direction direction)
        {
            UIDownloadName.Text = "";

            if (direction == Direction.Up)
            {
                if (pointer == urls.Count - 1)
                {
                    pointer = 0;
                }
                else
                {
                    pointer++;
                }
            }

            if (direction == Direction.Down)
            {
                if (pointer == 0)
                {
                    pointer = urls.Count - 1;
                }
                else
                {
                    pointer--;
                }
            }

            UIDisplayImage.ImageLocation = urls[pointer].Value;

            byte[] imageData = new WebClient().DownloadData(urls[pointer].Value);
            Image img = Image.FromStream(new MemoryStream(imageData));

            UIDescription.Text = (pointer + 1).ToString() + "/" + urls.Count + "\n\nImage data:\n" + "Width: " + img.Width + "\n" + "Height: " + img.Height;

            if (img.Height >= 1480)
            {
                UILargest.Show();
            }
            else
            {
                UILargest.Hide();
            }
        }
    }
}
