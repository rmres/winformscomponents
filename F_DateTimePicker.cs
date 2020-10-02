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
    public partial class F_DateTimePicker : Form
    {
        public F_DateTimePicker()
        {
            InitializeComponent();
        }

        private void btn_getdate_Click(object sender, EventArgs e)
        {
            txt_data.Text = dtp_data.Text;

            txt_dia.Text = dtp_data.Value.Day.ToString();
            txt_mes.Text = dtp_data.Value.Month.ToString();
            txt_ano.Text = dtp_data.Value.Year.ToString();
        }

        private void btn_setdate_Click(object sender, EventArgs e)
        {
            try
            {
                int dia, mes, ano;
                dia = Convert.ToInt32(txt_dia.Text);
                mes = Convert.ToInt32(txt_mes.Text);
                ano = Convert.ToInt32(txt_ano.Text);

                DateTime dt = new DateTime(ano, mes, dia);

                dtp_data.Value = dt;
            }
            catch {
                //
            }
        }

        private void btn_today_Click(object sender, EventArgs e)
        {
            dtp_data.Value = DateTime.Today;
        }
    }
}
