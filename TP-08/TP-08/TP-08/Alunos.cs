using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_08
{
    public partial class FRM_Alunos : Form
    {
        TextBox[] notas = new TextBox[4];

        public FRM_Alunos()
        {
            InitializeComponent();
            notas[0] = TXT_Nb1;
            notas[1] = TXT_Nb2;
            notas[2] = TXT_Nb3;
            notas[3] = TXT_Nb4;
        }

        #region Exportar
        public void ExportarCSV(object sender, EventArgs e)
        {
            SFD_Exportar.Filter = "Arquivos CSV|*.csv";
            if(SFD_Exportar.ShowDialog() == DialogResult.OK)
            {
                StreamWriter file = new StreamWriter(SFD_Exportar.FileName);
                file.WriteLine("Disciplina,Matricula,Serie,B1,B2,B3,B4,Media,Conceito");
                for (int i = 0; i < DTS_Alunos.Tables["Alunos"].Rows.Count; i++)
                {
                    string line = "";
                    for(int x = 0; x < 9; x++)
                    {
                        if(x < 8)
                        {
                            line += $"{DTG_Alunos.Rows[i].Cells[x].Value},";
                        } else
                        {
                            line += $"{DTG_Alunos.Rows[i].Cells[x].Value}";
                        }
                    }
                    file.WriteLine(line);
                }
                file.Dispose();
            }
        }

        public void ExportarTXT(object sender, EventArgs e)
        {
            SFD_Exportar.Filter = "Arquivos de Texto|*.txt";
            if(SFD_Exportar.ShowDialog() == DialogResult.OK)
            {
                StreamWriter file = new StreamWriter(SFD_Exportar.FileName);
                for(int i = 0; i < DTS_Alunos.Tables["Alunos"].Rows.Count; i++)
                {
                    for(int x = 0; x < 9; x++)
                    {
                        file.WriteLine($"{DTG_Alunos.Rows[i].Cells[x].Value}");
                    }
                    file.WriteLine(String.Empty);
                }
                file.Dispose();
            }
        }
        #endregion
        #region Cadastrar

        public void Cadastrar(object sender, EventArgs e)
        {
            bool aprovado = true;
            TextBox[] fields = new TextBox[7]
            {
                TXT_Disciplina, TXT_Matricula, TXT_Serie, TXT_Nb1, TXT_Nb2, TXT_Nb3, TXT_Nb4
            };

            for(int i = 0; i < fields.Length; i++)
            {
                if (fields[i].Text == "")
                {
                    MessageBox.Show("Nenhum campo pode estar vazio...", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    fields[i].Clear();
                    fields[i].Focus();
                    aprovado = false;
                    break;
                }
            }

            if(aprovado)
            {
                float mediaTotal = 0;

                for(int i = 3; i < 7; i++)
                {
                    mediaTotal += float.Parse(fields[i].Text);
                }

                mediaTotal = mediaTotal/4;

                DTG_Alunos.Enabled = true;
                DataRow linha = DTS_Alunos.Tables["Alunos"].NewRow();
                linha["disciplina"] = TXT_Disciplina.Text.ToString();
                linha["matrícula"] = TXT_Matricula.Text.ToString();
                linha["série"] = TXT_Serie.Text.ToString();
                linha["b1"] = TXT_Nb1.Text.ToString();
                linha["b2"] = TXT_Nb2.Text.ToString();
                linha["b3"] = TXT_Nb3.Text.ToString();
                linha["b4"] = TXT_Nb4.Text.ToString();
                linha["média"] = mediaTotal.ToString();
                linha["conceito"] = mediaTotal > 5 ? "Aprovado" : "Reprovado";
                DTS_Alunos.Tables[0].Rows.Add(linha);
                for(int i = 0; i < 7; i++)
                {
                    fields[i].Clear();
                }
            }
        }
        #endregion
        #region Validação
        public void ValidarMatricula(object sender, CancelEventArgs e)
        {
            string txt = TXT_Matricula.Text;
            if(txt != "")
            {
                if (txt.Length < 6 || txt.Length > 6)
                {
                    MessageBox.Show("Tamanho fora do padrão, a matrícula deve ser composta de seis números sem nenhum caractere especial.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TXT_Matricula.Clear();
                    TXT_Matricula.Focus();
                }
            }
        }

        public void ValidarSerie(object sender, CancelEventArgs e)
        {
            if(TXT_Serie.Text != "")
            {
                try
                {
                    int serie = int.Parse(TXT_Serie.Text);
                    if(serie < 1 || serie > 9)
                    {
                        MessageBox.Show("A série deve ser entre o 1° e 9° Ano", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TXT_Serie.Clear();
                        TXT_Serie.Focus();
                    }
                } catch
                {
                    MessageBox.Show("A série deve ser um número inteiro de 1 a 9", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TXT_Serie.Clear();
                    TXT_Serie.Focus();
                }
            }
        }

        public void ValidarNota(object sender, CancelEventArgs e)
        {
            int index = 0;
            for(int i = 0; i < 4; i++)
            {
                if (sender.Equals(notas[i]))
                {
                    break;
                }
                index++;
            }

            if (notas[index].Text != "")
            {
                try
                {
                    float nota = float.Parse(notas[index].Text);
                    if(nota < 0 || nota > 10)
                    {
                        MessageBox.Show("A nota deve ser de 0.0 à 10.0", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        notas[index].Clear();
                        notas[index].Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("A nota ser um número de 0 a 10", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    notas[index].Clear();
                    notas[index].Focus();
                }
            }
        }
        #endregion
        #region Teclas Permitidas
        public void TeclasPermitidas(object sender, KeyPressEventArgs e)
        {
            if (sender.GetHashCode() == TXT_Disciplina.GetHashCode())
            {
                if (e.KeyChar == 13 || e.KeyChar == 32 || e.KeyChar == 8 || e.KeyChar > 64 && e.KeyChar < 123)
                {
                    e.KeyChar = e.KeyChar;
                }
                else
                {
                    e.KeyChar = Convert.ToChar(0);
                }
            }
            else
            {
                if(e.KeyChar == 13 || e.KeyChar == 8 || e.KeyChar > 47 && e.KeyChar < 58 || e.KeyChar == 46)
                {
                    if(sender.GetHashCode() != TXT_Matricula.GetHashCode() && sender.GetHashCode() != TXT_Serie.GetHashCode())
                    {
                        e.KeyChar = e.KeyChar;
                    } else
                    {
                        if(e.KeyChar == 46)
                        {
                            e.KeyChar = Convert.ToChar(0);
                        }
                        else
                        {
                            e.KeyChar = e.KeyChar;
                        }
                    }
                }
                else
                {
                    e.KeyChar = Convert.ToChar(0);
                }
            }
        }

        #endregion
        #region Filtro
        public void Filtrar(object sender, EventArgs e)
        {
            switch(CMB_Filtro.Text)
            {
                case "Matrícula":
                    BDS_Alunos.Filter = $"Matrícula like '%{TXT_Pesquisa.Text}%'";
                    break;
                case "Disciplina":
                    BDS_Alunos.Filter = $"Disciplina like '%{TXT_Pesquisa.Text}%'";
                    break;
                case "Série":
                    BDS_Alunos.Filter = $"Série like '%{TXT_Pesquisa.Text}%'";
                    break;
                case "B1":
                    BDS_Alunos.Filter = $"B1 like '%{TXT_Pesquisa.Text}%'";
                    break;
                case "B2":
                    BDS_Alunos.Filter = $"B2 like '%{TXT_Pesquisa.Text}%'";
                    break;
                case "B3":
                    BDS_Alunos.Filter = $"B3 like '%{TXT_Pesquisa.Text}%'";
                    break;
                case "B4":
                    BDS_Alunos.Filter = $"B4 like '%{TXT_Pesquisa.Text}%'";
                    break;
                case "Média":
                    BDS_Alunos.Filter = $"Média like '%{TXT_Pesquisa.Text}%'";
                    break;
                case "Conceito":
                    BDS_Alunos.Filter = $"Conceito like '%{TXT_Pesquisa.Text}%'";
                    break;
                default:
                    TXT_Pesquisa.Clear();
                    MessageBox.Show("Escolha alguma opção na lista");
                    CMB_Filtro.Focus();
                    break;
            }
        }
        #endregion

    }
}
