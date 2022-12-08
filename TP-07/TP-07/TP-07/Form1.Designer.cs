namespace TP_07
{
    partial class FRM_Labirinto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Labirinto));
            this.PCT_Labirinto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_Time = new System.Windows.Forms.Label();
            this.TMR_TempoRestante = new System.Windows.Forms.Timer(this.components);
            this.TMR_Personagem = new System.Windows.Forms.Timer(this.components);
            this.PCT_Personagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_Labirinto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_Personagem)).BeginInit();
            this.SuspendLayout();
            // 
            // PCT_Labirinto
            // 
            this.PCT_Labirinto.Image = ((System.Drawing.Image)(resources.GetObject("PCT_Labirinto.Image")));
            this.PCT_Labirinto.Location = new System.Drawing.Point(13, 13);
            this.PCT_Labirinto.Name = "PCT_Labirinto";
            this.PCT_Labirinto.Size = new System.Drawing.Size(762, 550);
            this.PCT_Labirinto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCT_Labirinto.TabIndex = 0;
            this.PCT_Labirinto.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 578);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tempo Restante:";
            // 
            // LBL_Time
            // 
            this.LBL_Time.AutoSize = true;
            this.LBL_Time.Location = new System.Drawing.Point(422, 578);
            this.LBL_Time.Name = "LBL_Time";
            this.LBL_Time.Size = new System.Drawing.Size(29, 13);
            this.LBL_Time.TabIndex = 2;
            this.LBL_Time.Text = "XX s";
            // 
            // TMR_TempoRestante
            // 
            this.TMR_TempoRestante.Tick += new System.EventHandler(this.TMR_TempoRestante_Tick);
            // 
            // TMR_Personagem
            // 
            this.TMR_Personagem.Enabled = true;
            this.TMR_Personagem.Tick += new System.EventHandler(this.TMR_Personagem_Tick);
            // 
            // PCT_Personagem
            // 
            this.PCT_Personagem.Image = ((System.Drawing.Image)(resources.GetObject("PCT_Personagem.Image")));
            this.PCT_Personagem.Location = new System.Drawing.Point(41, 30);
            this.PCT_Personagem.Name = "PCT_Personagem";
            this.PCT_Personagem.Size = new System.Drawing.Size(30, 30);
            this.PCT_Personagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCT_Personagem.TabIndex = 3;
            this.PCT_Personagem.TabStop = false;
            // 
            // FRM_Labirinto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(789, 600);
            this.Controls.Add(this.PCT_Personagem);
            this.Controls.Add(this.LBL_Time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PCT_Labirinto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Labirinto";
            this.Text = "Jogo Labirinto";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FRM_Labirinto_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.PCT_Labirinto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_Personagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PCT_Labirinto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_Time;
        private System.Windows.Forms.Timer TMR_TempoRestante;
        private System.Windows.Forms.Timer TMR_Personagem;
        private System.Windows.Forms.PictureBox PCT_Personagem;
    }
}

