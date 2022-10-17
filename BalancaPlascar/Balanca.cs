using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalancaPlascar
{
    public partial class Balanca : Form
    {
        public Balanca()
        {
            InitializeComponent();
        }

        private void Balanca_Load(object sender, EventArgs e)
        {
            Location = new Point(Screen.PrimaryScreen.Bounds.Width - Width, 0);

            foreach (var item in gbSaida.Controls.OfType<Label>())
            {
                if (item.Name.Contains("Resp"))
                    item.Visible = false;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string entrada = txtEntrada.Text;

            foreach (var item in gbSaida.Controls.OfType<Label>())
            {
                if (item.Name.Contains("Resp"))
                    item.Visible = true;
            }

            if (entrada != string.Empty)
            {
                Scales scales = new Scales(entrada);
                lblRespValorRecebido.Text = scales.ReturnInput();
                scales.SetVariables();
                lblRespTara.Text = scales.tara.ToString();
                lblRespMovimento.Text = scales.movimento.ToString();
                lblRespErro.Text = scales.erro.ToString();
                lblRespPeso.Text = scales.GetWeight().ToString();
            }
        }
    }
}
