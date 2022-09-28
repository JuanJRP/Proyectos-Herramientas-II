using AxWMPLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Multimedia
{
    public partial class FormWMP : Form
    {
        string[] lista;
        List<string> Nombres = new List<string>();
        int count = 0, opc = 0;

        public FormWMP()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.Multiselect = true;
            if (open.ShowDialog() == DialogResult.OK)
            {
                StopToolStripMenuItem.Enabled = true;
                PreviusToolStripMenuItem.Enabled = true;
                advanceToolStripMenuItem.Enabled = true;
                removeToolStripMenuItem.Enabled = true;
                lista = open.FileNames;
                for (int i = 0; i < lista.Length; i++)
                {
                    Nombres.Add(lista[i]);
                    Lista.Items.Add(lista[i]);
                }
            }
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (opc)
            {
                case 1:
                    Player.Ctlcontrols.play();
                    StopToolStripMenuItem.Text = "Stop";
                    opc = 2;
                    break;
                case 2:
                    Player.Ctlcontrols.pause();
                    StopToolStripMenuItem.Text = "Play";
                    opc = 1;
                    break;
            }
        }

        private void delayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {
                Player.URL = Lista.Items[count - 1].ToString(); count--; Lista.SelectedIndex--;
            }
        }

        private void advanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Lista.Items.Count >= 0 && count < Lista.Items.Count - 1)
            {
                Player.URL = Lista.Items[count + 1].ToString(); count++; Lista.SelectedIndex++;
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
            if (Lista.SelectedIndex >= 0 && Lista.SelectedIndex <= Lista.Items.Count)
            {
                Nombres.RemoveAt(Lista.SelectedIndex);
                Lista.Items.RemoveAt(Lista.SelectedIndex);
            }
        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Lista.SelectedIndex >= 0)
            {
                Player.URL = Lista.Items[Lista.SelectedIndex].ToString();
                count = Lista.SelectedIndex;
                opc = 2;
            }
        }
    }
}