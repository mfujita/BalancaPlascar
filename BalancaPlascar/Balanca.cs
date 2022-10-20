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
            Location = new Point(Screen.PrimaryScreen.Bounds.Width - Width, Screen.PrimaryScreen.Bounds.Height-Height);

            foreach (var item in gbSaida.Controls.OfType<Label>())
            {
                if (item.Name.Contains("Resp"))
                    item.Visible = false;
            }

            
            SetupTime();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Executar(CommunicationState.NONE);
        }

        private void SetupTime()
        {
            timer1.Tick += Timer1_Tick;
            timer1.Start();
            timer1.Enabled = true;
            timer1.Interval = 10000;
        }

        private void Executar(CommunicationState state)
        {
            
            Scales scales = null;

            foreach (var item in gbSaida.Controls.OfType<Label>())
            {
                if (item.Name.Contains("Resp"))
                    item.Visible = true;
            }

            switch (state)
            {
                case CommunicationState.NONE:
                    goto case CommunicationState.INICIA_CLASSE;

                case CommunicationState.INICIA_CLASSE:
                    scales = new Scales();
                    goto case CommunicationState.INICIA_COMUNICACAO;

                case CommunicationState.INICIA_COMUNICACAO:

                    scales.StartCommunication();

                    goto case CommunicationState.COLETA_DADOS;

                case CommunicationState.COLETA_DADOS:

                    if (txtEntrada.Text != string.Empty)
                    {
                        scales.WriteData(txtEntrada.Text);
                        lblRespValorRecebido.Text = scales.ReturnInput();
                        scales.SetVariables();
                        lblRespTara.Text = scales.Tara.ToString();
                        lblRespMovimento.Text = scales.Movimento.ToString();
                        lblRespErro.Text = scales.Erro.ToString();
                        lblRespPeso.Text = scales.GetWeight().ToString();

                        goto case CommunicationState.TERMINA_COMUNICACAO;
                    }
                    else
                        goto case CommunicationState.INICIA_COMUNICACAO;

                case CommunicationState.TERMINA_COMUNICACAO:
                    scales.CloseCommunication();
                    timer1.Enabled = false;
                    SetupTime();
                    break;
            }
        }
    }
}
