using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_de_Multas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_calcular_Click(object sender, EventArgs e)
        {
            DateTime fechaDePago, hoy;
            fechaDePago = dtp_pago.Value;
            hoy = dtp_hoy.Value;
            if (String.IsNullOrWhiteSpace(tb_feriados.Text))
            {
                MessageBox.Show("Favor llene correctamente todos los campos");
            }
            else {
                int feriados = int.Parse(tb_feriados.Text);

                int dias = (int)GetBusinessDays(fechaDePago, hoy) - 5 - feriados;

                if (dias > 0)
                {
                    int multa = (int)(int.Parse(tb_alquiler.Text) * 0.01 * dias);
                    int total = int.Parse(tb_alquiler.Text) + int.Parse(tb_expensas.Text) + multa;
                    tb_dias.Text = dias.ToString();
                    tb_mora.Text = multa.ToString();
                    tb_total.Text = total.ToString();
                }
                else
                {
                    int total2 = int.Parse(tb_alquiler.Text) + int.Parse(tb_expensas.Text);
                    tb_dias.Text = "0";
                    tb_mora.Text = "0";
                    tb_total.Text = tb_alquiler.Text;

                }
            }
        }


        public static double GetBusinessDays(DateTime startD, DateTime endD)
        {
            double calcBusinessDays =
                1 + ((endD - startD).TotalDays * 5 -
                (startD.DayOfWeek - endD.DayOfWeek) * 2) / 7;

            if (endD.DayOfWeek == DayOfWeek.Saturday) calcBusinessDays--;
            if (startD.DayOfWeek == DayOfWeek.Sunday) calcBusinessDays--;

            return calcBusinessDays;
        }
    }
}
