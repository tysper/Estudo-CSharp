using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_01
{
    public partial class FRM_Calculo : Form
    {
        #region Variáveis Globais
        TextBox[] resistencias = new TextBox[3];
        float[] rs = new float[3];
        float[] resultados = new float[3]; 
        #endregion

        #region Funções

        void AtualizarRs()
        {
            for(int i = 0; i < 3; i++)
            {
                if (resistencias[i].Text != "")
                {
                    try
                    {
                        rs[i] = float.Parse(resistencias[i].Text);
                    } catch
                    {
                        MessageBox.Show($"R{i+1} Inválida...");
                        resistencias[i].Clear();
                        resistencias[i].Focus();
                        break;
                    }
                };
            }
        }

        float Calcular(string R)
        {
            float somaR = (rs[0] + rs[1] + rs[2]);
            if (R == "r4")
            {
                return (rs[0] * rs[1]) / somaR;
            } else if(R == "r5")
            {
                return (rs[2] * rs[1]) / somaR;
            } else if(R == "r6")
            {
                return (rs[0] * rs[2]) / somaR;
            }
            return 0;
        }

        void AtualizarResultados()
        {
            for(int i = 0; i < 3; i++)
            {
                resultados[i] = Calcular($"r{i + 4}");
            }
        }

        void MostrarResultados()
        {
            for(int i = 0; i < 3; i++)
            {
                LST_Resultados.Items.Add($"R{i+4}: {resultados[i]}");
            }
        }

        void RotinaResultado()
        {
            AtualizarRs();
            AtualizarResultados();
            MostrarResultados();
        }
        #endregion

        #region Ações
        public FRM_Calculo()
        {
            InitializeComponent();

            resistencias[0] = TXT_R1;
            resistencias[1] = TXT_R2;
            resistencias[2] = TXT_R3;
        }

        public void Fechar(object o, EventArgs e)
        {
            if(MessageBox.Show("Você perderá todos os dados...", "Fechar controle", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes){
                this.Close();
            }
        }

        public void ValidarTextBox(object o, CancelEventArgs e)
        {
            int index = 0;
            for (int i = 0; i < 3; i++)
            {
                if (resistencias[i].GetHashCode() == o.GetHashCode())
                {
                    index = i;
                }
            }
            try
            {
                string[] str = o.ToString().Split(',');
                float res = 0; 
                for(int i = 0; i < str.Length; i++)
                {
                    str[i] = str[i].Trim();
                }

                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i].Substring(0, 5) == "Text:")
                    {
                        res = float.Parse(str[i].Substring(6));
                    }
                }

                if (res != 0)
                {
                    rs[index] = res;
                }
            } catch
            {
                AtualizarRs();
            }
        }
        private void TeclasPermitidas(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 8 || e.KeyChar == 13 || e.KeyChar == 46 || e.KeyChar == 44 || (e.KeyChar > 47 && e.KeyChar < 58))
            {
                if(e.KeyChar == 44)
                {
                    e.KeyChar = Convert.ToChar(46);
                } else {
                    e.KeyChar = e.KeyChar;
                }
            } else
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }
        private void BTN_Calcular_Click(object sender, EventArgs e)
        {
            RotinaResultado();
        }
        private void BTN_Limpar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Isso apagará todos os dados existentes..", "Limpar dados", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
            {
                for(int i = 0; i < 3; i++)
                {
                    resistencias[i].Clear();
                    rs[i] = 0;
                    resultados[i] = 0;
                    LST_Resultados.Items.Clear();
                }
                resistencias[0].Focus();
            }
        }

        #endregion


    }
}
