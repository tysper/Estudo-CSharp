namespace TP_01
{
    partial class FRM_Calculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Calculo));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TXT_R1 = new System.Windows.Forms.TextBox();
            this.TXT_R3 = new System.Windows.Forms.TextBox();
            this.TXT_R2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LST_Resultados = new System.Windows.Forms.ListBox();
            this.BTN_Limpar = new System.Windows.Forms.Button();
            this.BTN_Calcular = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TXT_R1
            // 
            this.TXT_R1.Location = new System.Drawing.Point(243, 12);
            this.TXT_R1.Name = "TXT_R1";
            this.TXT_R1.Size = new System.Drawing.Size(35, 20);
            this.TXT_R1.TabIndex = 0;
            this.TXT_R1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeclasPermitidas);
            this.TXT_R1.Validating += new System.ComponentModel.CancelEventHandler(this.ValidarTextBox);
            // 
            // TXT_R3
            // 
            this.TXT_R3.Location = new System.Drawing.Point(243, 78);
            this.TXT_R3.Name = "TXT_R3";
            this.TXT_R3.Size = new System.Drawing.Size(35, 20);
            this.TXT_R3.TabIndex = 2;
            this.TXT_R3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeclasPermitidas);
            this.TXT_R3.Validating += new System.ComponentModel.CancelEventHandler(this.ValidarTextBox);
            // 
            // TXT_R2
            // 
            this.TXT_R2.Location = new System.Drawing.Point(243, 45);
            this.TXT_R2.Name = "TXT_R2";
            this.TXT_R2.Size = new System.Drawing.Size(35, 20);
            this.TXT_R2.TabIndex = 1;
            this.TXT_R2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeclasPermitidas);
            this.TXT_R2.Validating += new System.ComponentModel.CancelEventHandler(this.ValidarTextBox);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "R1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "R3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "R2";
            // 
            // LST_Resultados
            // 
            this.LST_Resultados.FormattingEnabled = true;
            this.LST_Resultados.Location = new System.Drawing.Point(12, 104);
            this.LST_Resultados.Name = "LST_Resultados";
            this.LST_Resultados.Size = new System.Drawing.Size(281, 108);
            this.LST_Resultados.TabIndex = 3;
            // 
            // BTN_Limpar
            // 
            this.BTN_Limpar.Location = new System.Drawing.Point(13, 219);
            this.BTN_Limpar.Name = "BTN_Limpar";
            this.BTN_Limpar.Size = new System.Drawing.Size(88, 23);
            this.BTN_Limpar.TabIndex = 4;
            this.BTN_Limpar.Text = "&Limpar";
            this.BTN_Limpar.UseVisualStyleBackColor = true;
            this.BTN_Limpar.Click += new System.EventHandler(this.BTN_Limpar_Click);
            // 
            // BTN_Calcular
            // 
            this.BTN_Calcular.Location = new System.Drawing.Point(205, 219);
            this.BTN_Calcular.Name = "BTN_Calcular";
            this.BTN_Calcular.Size = new System.Drawing.Size(88, 23);
            this.BTN_Calcular.TabIndex = 6;
            this.BTN_Calcular.Text = "&Calcular";
            this.BTN_Calcular.UseVisualStyleBackColor = true;
            this.BTN_Calcular.Click += new System.EventHandler(this.BTN_Calcular_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "&Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Fechar);
            // 
            // FRM_Calculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 250);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTN_Calcular);
            this.Controls.Add(this.BTN_Limpar);
            this.Controls.Add(this.LST_Resultados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_R2);
            this.Controls.Add(this.TXT_R3);
            this.Controls.Add(this.TXT_R1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Calculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular Equivalência";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TXT_R1;
        private System.Windows.Forms.TextBox TXT_R3;
        private System.Windows.Forms.TextBox TXT_R2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox LST_Resultados;
        private System.Windows.Forms.Button BTN_Limpar;
        private System.Windows.Forms.Button BTN_Calcular;
        private System.Windows.Forms.Button button1;
    }
}

