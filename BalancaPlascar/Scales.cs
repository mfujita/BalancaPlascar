using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancaPlascar
{
    public class Scales
    {
        public bool StatusOk { get; set; }
        public bool Tara { get; set; }
        public bool Movimento { get; set; }
        public bool Erro { get; set; }

        public string Entrada { get; set; }

        private byte[] letras;

        public Scales(string valorRecebido)
        {
            int cr = 13;

            Entrada = valorRecebido;

            valorRecebido = valorRecebido + (char)cr;

            letras = Encoding.ASCII.GetBytes(valorRecebido);
        }

        public double GetWeight()
        {
            double peso = 0;
            if (StatusOk)
            {
                if (Entrada[0].Equals('A') || Entrada[0].Equals('B') || Entrada[0].Equals('C') || Entrada[0].Equals('D') ||
                    Entrada[0].Equals('E') || Entrada[0].Equals('G') || Entrada[0].Equals('H') || Entrada[0].Equals('I') ||
                    Entrada[0].Equals('L') || Entrada[0].Equals('M') || Entrada[0].Equals('@'))
                {
                    double kg = Convert.ToDouble(Entrada.Substring(1, 3));
                    double gramas = Convert.ToDouble(Entrada.Substring(5, 3)) / 1000;

                    peso = Convert.ToDouble(kg) + Convert.ToDouble(gramas);
                }
                else
                    peso = 0F;
            }
            else
                peso = 0F;
            
            return peso;
        }

        public string ReturnInput()
        {
            return Entrada;
        }

        public void SetVariables()
        {
            try
            {
                if (letras.Length != 9 || letras[8] != (int)0x0D)
                {
                    //TODO: PREENCHER O ERRO
                    Tara = false;
                    Movimento = false;
                    Erro = true;
                    StatusOk = false;
                    return;
                }
                else
                {
                    char primeiraLetra = Entrada[0];

                    switch (primeiraLetra)
                    {
                        case 'A':
                            Tara = true;
                            Movimento = true;
                            Erro = false;
                            StatusOk = true;
                            break;
                        case 'B':
                            Tara = false;
                            Movimento = true;
                            Erro = false;
                            StatusOk = true;
                            break;
                        case 'C':
                            Tara = true;
                            Movimento = true;
                            Erro = false;
                            StatusOk = true;
                            break;
                        case 'D':
                            Tara = false;
                            Movimento = false;
                            Erro = false;
                            StatusOk = true;
                            break;
                        case 'E':
                            Tara = true;
                            Movimento = false;
                            Erro = false;
                            StatusOk = true;
                            break;
                        case 'F':
                            Tara = false;
                            Movimento = false;
                            Erro = false;
                            StatusOk = true;
                            break;
                        case 'G':
                            Tara = true;
                            Movimento = false;
                            Erro = false;
                            StatusOk = true;
                            break;
                        case 'H':
                            Tara = false;
                            Movimento = true;
                            Erro = false;
                            StatusOk = true;
                            break;
                        case 'I':
                            Tara = true;
                            Movimento = false;
                            Erro = false;
                            StatusOk = true;
                            break;
                        case 'L':
                            Tara = false;
                            Movimento = false;
                            Erro = false;
                            StatusOk = true;
                            break;
                        case 'M':
                            Tara = true;
                            Movimento = false;
                            Erro = false;
                            StatusOk = true;
                            break;
                        case '@':
                            Tara = false;
                            Movimento = true;
                            Erro = false;
                            StatusOk = true;
                            break;
                        default:
                            Tara = false;
                            Movimento = false;
                            Erro = true;
                            StatusOk = false;
                            break;
                    }
                }
            }
            catch
            {
                Tara = false;
                Movimento = false;
                Erro = true;
                StatusOk = false;
            }
        }
    }
}
