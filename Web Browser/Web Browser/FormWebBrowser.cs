using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Web_Browser
{
    public partial class FormWebBrowser : Form
    {
        public FormWebBrowser()
        {
            InitializeComponent();
            webBrowser.ScriptErrorsSuppressed = true;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(txtNavegar.Text);
        }

        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            txtNavegar.Text = webBrowser.Url.ToString();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void hToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate("http://google.com");
        }
    }
}
