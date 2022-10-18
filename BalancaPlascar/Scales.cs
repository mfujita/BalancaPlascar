using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancaPlascar
{
    public class Scales
    {
        public bool statusOk { get; set; }
        public bool tara { get; set; }
        public bool movimento { get; set; }
        public bool erro { get; set; }

        public string entrada { get; set; }

        private byte[] letras;

        public Scales(string valorRecebido)
        {
            int cr = 13;

            entrada = valorRecebido;

            valorRecebido = valorRecebido + (char)cr;

            letras = Encoding.ASCII.GetBytes(valorRecebido);
        }

        public double GetWeight()
        {
            double peso = 0;
            if (statusOk)
            {
                double kg = Convert.ToDouble(entrada.Substring(1, 3));
                double gramas = Convert.ToDouble(entrada.Substring(5, 3))/1000;

                peso = Convert.ToDouble(kg) + Convert.ToDouble(gramas);
            }
            else
                peso = 0F;
            
            return peso;
        }

        public string ReturnInput()
        {
            return entrada;
        }

        public void SetVariables()
        {
            try
            {
                if (entrada[0].Equals('A') && letras.Length == 9 && letras[8] == (int)13)
                {
                    tara = true;
                    movimento = true;
                    erro = false;
                    statusOk = true;
                }
                else if (entrada[0].Equals('B') && letras.Length == 9 && letras[8] == (int)13)
                {
                    tara = false;
                    movimento = true;
                    erro = false;
                    statusOk = true;
                }
                else if (entrada[0].Equals('C') && letras.Length == 9 && letras[8] == (int)13)
                {
                    tara = true;
                    movimento = true;
                    erro = false;
                    statusOk = true;
                }
                else if (entrada[0].Equals('D') && letras.Length == 9 && letras[8] == (int)13)
                {
                    tara = false;
                    movimento = false;
                    erro = false;
                    statusOk = true;
                }
                else if (entrada[0].Equals('E') && letras.Length == 9 && letras[8] == (int)13)
                {
                    tara = true;
                    movimento = false;
                    erro = false;
                    statusOk = true;
                }
                else if (entrada[0].Equals('F') && letras.Length == 9 && letras[8] == (int)13)
                {
                    tara = false;
                    movimento = false;
                    erro = false;
                    statusOk = true;
                }
                else if (entrada[0].Equals('G') && letras.Length == 9 && letras[8] == (int)13)
                {
                    tara = true;
                    movimento = false;
                    erro = false;
                    statusOk = true;
                }
                else if (entrada[0].Equals('H') && letras.Length == 9 && letras[8] == (int)13)
                {
                    tara = false;
                    movimento = true;
                    erro = false;
                    statusOk = true;
                }
                else if (entrada[0].Equals('I') && letras.Length == 9 && letras[8] == (int)13)
                {
                    tara = true;
                    movimento = false;
                    erro = false;
                    statusOk = true;
                }
                else if (entrada[0].Equals('L') && letras.Length == 9 && letras[8] == (int)13)
                {
                    tara = false;
                    movimento = false;
                    erro = false;
                    statusOk = true;
                }
                else if (entrada[0].Equals('M') && letras.Length == 9 && letras[8] == (int)13)
                {
                    tara = true;
                    movimento = false;
                    erro = false;
                    statusOk = true;
                }
                else if (entrada[0].Equals('@') && letras.Length == 9 && letras[8] == (int)13)
                {
                    tara = false;
                    movimento = true;
                    erro = false;
                    statusOk = true;
                }
                else
                {
                    tara = false;
                    movimento = false;
                    erro = true;
                    statusOk = false;
                }
            }
            catch
            {
                tara = false;
                movimento = false;
                erro = true;
                statusOk = false;
            }
        }
    }
}
