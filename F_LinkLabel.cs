using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class F_LinkLabel : Form
    {
        public F_LinkLabel()
        {
            InitializeComponent();

            llb_multiplos.Links.Add(0, 6, "www.google.com.br");
            llb_multiplos.Links.Add(9, 7, "https://www.youtube.com/");
            llb_multiplos.Links.Add(19, 7, "www.twitter.com");
        }

        private void llb_yt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txt_nome.Text != null) {
                System.Diagnostics.Process.Start($"https://www.youtube.com/results?search_query={txt_nome.Text}");
            }
            else
            {
                System.Diagnostics.Process.Start($"https://www.youtube.com/");
            }

            LinkLabel ll = (LinkLabel)sender;

            ll.LinkVisited = true;
        }

        private void llb_calc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void llb_multiplos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());

            e.Link.Visited = true;
        }
    }
}
