using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_07
{
    public partial class FRM_Labirinto : Form
    {

        #region Variáveis Globais
        static string[,] path = new string[23, 31]{
            {"1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1"},
            {"1","1","1","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","1"},
            {"1","1","1","0","1","1","1","0","1","1","1","1","1","1","1","0","1","1","1","1","1","0","1","1","1","1","1","1","1","0","1"},
            {"1","1","1","0","1","0","1","0","1","0","0","0","0","0","1","0","1","0","0","0","1","0","1","0","0","0","0","0","1","0","1"},
            {"1","1","1","0","1","0","1","0","1","0","1","1","1","0","1","0","1","1","1","0","1","0","1","0","1","1","1","1","1","0","1"},
            {"1","0","1","0","1","0","1","0","1","0","1","0","1","0","1","0","0","0","0","0","1","0","1","0","0","0","0","0","0","0","1"},
            {"1","0","1","0","1","0","1","0","1","0","1","0","1","0","1","1","1","1","1","1","1","0","1","1","1","1","1","1","1","1","1"},
            {"1","0","1","0","1","0","1","0","1","0","1","0","0","0","0","0","1","0","0","0","0","0","1","0","0","0","0","0","0","0","1"},
            {"1","0","1","1","1","0","1","0","1","0","1","0","1","1","1","0","1","1","1","1","1","1","1","0","1","1","1","1","1","1","1"},
            {"1","0","0","0","0","0","0","0","1","0","1","0","1","0","1","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
            {"1","1","1","1","1","1","1","0","1","0","1","1","1","0","1","1","1","1","1","1","1","1","1","0","1","1","1","1","1","1","1"},
            {"0","0","0","0","0","0","1","0","1","0","0","0","0","0","0","0","0","0","0","0","0","0","1","0","1","0","0","0","0","0","1"},
            {"1","1","1","1","1","0","1","0","1","1","1","1","1","1","1","1","1","1","1","1","1","0","1","0","1","0","1","1","1","0","1"},
            {"1","0","0","0","1","0","1","0","0","0","0","0","0","0","0","0","0","0","1","0","1","0","1","0","1","0","1","0","1","0","1"},
            {"1","1","1","0","1","0","1","0","1","1","1","1","1","1","1","1","1","1","1","0","1","0","1","0","1","0","1","0","1","0","1"},
            {"1","0","1","0","1","0","1","0","0","0","0","0","0","0","0","0","0","0","0","0","1","0","1","0","1","0","1","0","1","0","1"},
            {"1","0","1","0","1","0","1","1","1","1","1","1","1","1","1","1","1","0","1","1","1","0","1","0","1","0","1","0","1","0","1"},
            {"1","0","1","0","1","0","0","0","0","0","0","0","0","0","0","0","0","0","1","0","1","0","1","0","1","0","1","0","0","0","1"},
            {"1","0","1","0","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","0","1","0","1","0","1","0","1","0","1","1","1"},
            {"1","0","1","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","1","0","1","0","1","0","1","0","1","0","1","1","1"},
            {"1","0","1","0","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","0","1","1","1","0","1","0","1","0","1","1","1"},
            {"1","0","1","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","1","0","1","0","1","1","1"},
            {"1","0","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","0","1","1","1"},
            };
        int posX = 0, posY = 0;
        bool jogoFinalizado = false;
        #endregion

        #region Funções
        void ReiniciarJogo()
        {
            posX = 0; 
            posY = 0;
            jogoFinalizado = false;
            PCT_Personagem.Location = new Point(41, 30);
        }
        #endregion
        public FRM_Labirinto()
        {
            InitializeComponent();
        }

        private void TMR_TempoRestante_Tick(object sender, EventArgs e)
        {

        }

        private void TMR_Personagem_Tick(object sender, EventArgs e)
        {
            
        }

        private void FRM_Labirinto_KeyPress(object sender, KeyPressEventArgs e)
        {
            int locationX = PCT_Personagem.Location.X;
            int locationY = PCT_Personagem.Location.Y;
            try
            {

                if ((e.KeyChar.ToString().ToUpper() == "W" || e.KeyChar.ToString().ToUpper() == "A" || e.KeyChar.ToString().ToUpper() == "S" || e.KeyChar.ToString().ToUpper() == "D") && !jogoFinalizado)
                {
                   
                    if(e.KeyChar.ToString().ToUpper() == "W" && posY-1 > -1)
                    {
                        if(path[posY - 1, posX] == "1")
                        {
                            posY--;
                            PCT_Personagem.Location = new Point(locationX, locationY - 22);
                        }
                    }
                    if (e.KeyChar.ToString().ToUpper() == "S")
                    {
                        if (path[posY + 1, posX] == "1" && posY+1 < 23 )
                        {
                            posY++;
                            PCT_Personagem.Location = new Point(locationX, locationY + 22);
                        }
                    }
                    if(e.KeyChar.ToString().ToUpper() == "A")
                    {
                        if (path[posY, posX-1] == "1" && posX-1 > -1)
                        {
                            posX--;
                            PCT_Personagem.Location = new Point(locationX - 22, locationY);
                        }
                    }
                    if(e.KeyChar.ToString().ToUpper() == "D")
                    {
                        if (path[posY, posX+1] == "1" && posX+1 < 31)
                        {
                            posX++;
                            PCT_Personagem.Location = new Point(locationX + 22, locationY);
                        }
                    }
                    if (posY == 22 && posX == 30)
                    {
                        jogoFinalizado = true;
                        if (MessageBox.Show("Você ganhou, deseja jogar novamente?", "Jogo finalizado", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                            ReiniciarJogo();
                        } else
                        {
                            this.Close();
                        };
                    }
                }
            } catch
            {
                e.KeyChar = Convert.ToChar(0);
            };
        }
    }
}
