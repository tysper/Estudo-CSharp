namespace TP_10
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Validar = new System.Windows.Forms.Button();
            this.LBL_Resultado = new System.Windows.Forms.Label();
            this.TXT_Titulo = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo do Eleitor:";
            // 
            // BTN_Validar
            // 
            this.BTN_Validar.Location = new System.Drawing.Point(11, 36);
            this.BTN_Validar.Name = "BTN_Validar";
            this.BTN_Validar.Size = new System.Drawing.Size(309, 59);
            this.BTN_Validar.TabIndex = 2;
            this.BTN_Validar.Text = "Validar";
            this.BTN_Validar.UseVisualStyleBackColor = true;
            this.BTN_Validar.Click += new System.EventHandler(this.BTN_Validar_Click);
            // 
            // LBL_Resultado
            // 
            this.LBL_Resultado.AutoSize = true;
            this.LBL_Resultado.Location = new System.Drawing.Point(99, 105);
            this.LBL_Resultado.Name = "LBL_Resultado";
            this.LBL_Resultado.Size = new System.Drawing.Size(61, 13);
            this.LBL_Resultado.TabIndex = 3;
            this.LBL_Resultado.Text = "Resultado: ";
            // 
            // TXT_Titulo
            // 
            this.TXT_Titulo.Location = new System.Drawing.Point(102, 10);
            this.TXT_Titulo.Mask = "0000.0000.00-00";
            this.TXT_Titulo.Name = "TXT_Titulo";
            this.TXT_Titulo.Size = new System.Drawing.Size(90, 20);
            this.TXT_Titulo.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 131);
            this.Controls.Add(this.TXT_Titulo);
            this.Controls.Add(this.LBL_Resultado);
            this.Controls.Add(this.BTN_Validar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Validar;
        private System.Windows.Forms.Label LBL_Resultado;
        private System.Windows.Forms.MaskedTextBox TXT_Titulo;
    }
}

