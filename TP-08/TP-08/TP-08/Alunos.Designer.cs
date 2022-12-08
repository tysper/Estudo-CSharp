namespace TP_08
{
    partial class FRM_Alunos
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_Cadastrar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TXT_Nb3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TXT_Nb4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TXT_Nb2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_Nb1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_Serie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_Matricula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_Disciplina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TXT_Pesquisa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CMB_Filtro = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DTG_Alunos = new System.Windows.Forms.DataGridView();
            this.disciplinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matrículaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sérieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.médiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conceitoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BDS_Alunos = new System.Windows.Forms.BindingSource(this.components);
            this.DTS_Alunos = new System.Data.DataSet();
            this.Alunos = new System.Data.DataTable();
            this.disciplina = new System.Data.DataColumn();
            this.matricula = new System.Data.DataColumn();
            this.serie = new System.Data.DataColumn();
            this.nb1 = new System.Data.DataColumn();
            this.nb2 = new System.Data.DataColumn();
            this.nb3 = new System.Data.DataColumn();
            this.nb4 = new System.Data.DataColumn();
            this.media = new System.Data.DataColumn();
            this.conceito = new System.Data.DataColumn();
            this.MNS_Menu = new System.Windows.Forms.MenuStrip();
            this.BTN_Exportar = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_Linha = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_Coluna = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_Sobre = new System.Windows.Forms.ToolStripMenuItem();
            this.SFD_Exportar = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_Alunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDS_Alunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTS_Alunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alunos)).BeginInit();
            this.MNS_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_Cadastrar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TXT_Nb3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TXT_Nb4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TXT_Nb2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TXT_Nb1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TXT_Serie);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TXT_Matricula);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TXT_Disciplina);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 410);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulário de Cadastro";
            // 
            // BTN_Cadastrar
            // 
            this.BTN_Cadastrar.Location = new System.Drawing.Point(6, 356);
            this.BTN_Cadastrar.Name = "BTN_Cadastrar";
            this.BTN_Cadastrar.Size = new System.Drawing.Size(188, 48);
            this.BTN_Cadastrar.TabIndex = 8;
            this.BTN_Cadastrar.Text = "Cadastrar";
            this.BTN_Cadastrar.UseVisualStyleBackColor = true;
            this.BTN_Cadastrar.Click += new System.EventHandler(this.Cadastrar);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "B3:";
            // 
            // TXT_Nb3
            // 
            this.TXT_Nb3.Location = new System.Drawing.Point(47, 264);
            this.TXT_Nb3.Name = "TXT_Nb3";
            this.TXT_Nb3.Size = new System.Drawing.Size(35, 20);
            this.TXT_Nb3.TabIndex = 6;
            this.TXT_Nb3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeclasPermitidas);
            this.TXT_Nb3.Validating += new System.ComponentModel.CancelEventHandler(this.ValidarNota);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "B4:";
            // 
            // TXT_Nb4
            // 
            this.TXT_Nb4.Location = new System.Drawing.Point(142, 264);
            this.TXT_Nb4.Name = "TXT_Nb4";
            this.TXT_Nb4.Size = new System.Drawing.Size(35, 20);
            this.TXT_Nb4.TabIndex = 7;
            this.TXT_Nb4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeclasPermitidas);
            this.TXT_Nb4.Validating += new System.ComponentModel.CancelEventHandler(this.ValidarNota);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "B2:";
            // 
            // TXT_Nb2
            // 
            this.TXT_Nb2.Location = new System.Drawing.Point(142, 230);
            this.TXT_Nb2.Name = "TXT_Nb2";
            this.TXT_Nb2.Size = new System.Drawing.Size(35, 20);
            this.TXT_Nb2.TabIndex = 5;
            this.TXT_Nb2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeclasPermitidas);
            this.TXT_Nb2.Validating += new System.ComponentModel.CancelEventHandler(this.ValidarNota);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "B1:";
            // 
            // TXT_Nb1
            // 
            this.TXT_Nb1.Location = new System.Drawing.Point(47, 230);
            this.TXT_Nb1.Name = "TXT_Nb1";
            this.TXT_Nb1.Size = new System.Drawing.Size(35, 20);
            this.TXT_Nb1.TabIndex = 4;
            this.TXT_Nb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeclasPermitidas);
            this.TXT_Nb1.Validating += new System.ComponentModel.CancelEventHandler(this.ValidarNota);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Notas:";
            // 
            // TXT_Serie
            // 
            this.TXT_Serie.Location = new System.Drawing.Point(17, 161);
            this.TXT_Serie.Name = "TXT_Serie";
            this.TXT_Serie.Size = new System.Drawing.Size(177, 20);
            this.TXT_Serie.TabIndex = 3;
            this.TXT_Serie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeclasPermitidas);
            this.TXT_Serie.Validating += new System.ComponentModel.CancelEventHandler(this.ValidarSerie);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Série:";
            // 
            // TXT_Matricula
            // 
            this.TXT_Matricula.Location = new System.Drawing.Point(17, 105);
            this.TXT_Matricula.Name = "TXT_Matricula";
            this.TXT_Matricula.Size = new System.Drawing.Size(177, 20);
            this.TXT_Matricula.TabIndex = 2;
            this.TXT_Matricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeclasPermitidas);
            this.TXT_Matricula.Validating += new System.ComponentModel.CancelEventHandler(this.ValidarMatricula);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Matrícula:";
            // 
            // TXT_Disciplina
            // 
            this.TXT_Disciplina.Location = new System.Drawing.Point(17, 53);
            this.TXT_Disciplina.Name = "TXT_Disciplina";
            this.TXT_Disciplina.Size = new System.Drawing.Size(177, 20);
            this.TXT_Disciplina.TabIndex = 1;
            this.TXT_Disciplina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeclasPermitidas);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Disciplina:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TXT_Pesquisa);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.CMB_Filtro);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.DTG_Alunos);
            this.groupBox2.Location = new System.Drawing.Point(219, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(541, 410);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tabela de Dados";
            // 
            // TXT_Pesquisa
            // 
            this.TXT_Pesquisa.Location = new System.Drawing.Point(391, 11);
            this.TXT_Pesquisa.Name = "TXT_Pesquisa";
            this.TXT_Pesquisa.Size = new System.Drawing.Size(143, 20);
            this.TXT_Pesquisa.TabIndex = 1;
            this.TXT_Pesquisa.TextChanged += new System.EventHandler(this.Filtrar);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(332, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Pesquisa:";
            // 
            // CMB_Filtro
            // 
            this.CMB_Filtro.FormattingEnabled = true;
            this.CMB_Filtro.Items.AddRange(new object[] {
            "Disciplina",
            "Matrícula",
            "Série",
            "B1",
            "B2",
            "B3",
            "B4",
            "Media",
            "Conceito"});
            this.CMB_Filtro.Location = new System.Drawing.Point(204, 11);
            this.CMB_Filtro.Name = "CMB_Filtro";
            this.CMB_Filtro.Size = new System.Drawing.Size(121, 21);
            this.CMB_Filtro.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(146, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Filtrar por:";
            // 
            // DTG_Alunos
            // 
            this.DTG_Alunos.AutoGenerateColumns = false;
            this.DTG_Alunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG_Alunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.disciplinaDataGridViewTextBoxColumn,
            this.matrículaDataGridViewTextBoxColumn,
            this.sérieDataGridViewTextBoxColumn,
            this.b1DataGridViewTextBoxColumn,
            this.b2DataGridViewTextBoxColumn,
            this.b3DataGridViewTextBoxColumn,
            this.b4DataGridViewTextBoxColumn,
            this.médiaDataGridViewTextBoxColumn,
            this.conceitoDataGridViewTextBoxColumn});
            this.DTG_Alunos.DataSource = this.BDS_Alunos;
            this.DTG_Alunos.Location = new System.Drawing.Point(24, 44);
            this.DTG_Alunos.Name = "DTG_Alunos";
            this.DTG_Alunos.Size = new System.Drawing.Size(529, 366);
            this.DTG_Alunos.TabIndex = 2;
            this.DTG_Alunos.VirtualMode = true;
            // 
            // disciplinaDataGridViewTextBoxColumn
            // 
            this.disciplinaDataGridViewTextBoxColumn.DataPropertyName = "Disciplina";
            this.disciplinaDataGridViewTextBoxColumn.HeaderText = "Disciplina";
            this.disciplinaDataGridViewTextBoxColumn.Name = "disciplinaDataGridViewTextBoxColumn";
            this.disciplinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matrículaDataGridViewTextBoxColumn
            // 
            this.matrículaDataGridViewTextBoxColumn.DataPropertyName = "Matrícula";
            this.matrículaDataGridViewTextBoxColumn.HeaderText = "Matrícula";
            this.matrículaDataGridViewTextBoxColumn.Name = "matrículaDataGridViewTextBoxColumn";
            this.matrículaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sérieDataGridViewTextBoxColumn
            // 
            this.sérieDataGridViewTextBoxColumn.DataPropertyName = "Série";
            this.sérieDataGridViewTextBoxColumn.HeaderText = "Série";
            this.sérieDataGridViewTextBoxColumn.Name = "sérieDataGridViewTextBoxColumn";
            this.sérieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // b1DataGridViewTextBoxColumn
            // 
            this.b1DataGridViewTextBoxColumn.DataPropertyName = "B1";
            this.b1DataGridViewTextBoxColumn.HeaderText = "B1";
            this.b1DataGridViewTextBoxColumn.Name = "b1DataGridViewTextBoxColumn";
            this.b1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // b2DataGridViewTextBoxColumn
            // 
            this.b2DataGridViewTextBoxColumn.DataPropertyName = "B2";
            this.b2DataGridViewTextBoxColumn.HeaderText = "B2";
            this.b2DataGridViewTextBoxColumn.Name = "b2DataGridViewTextBoxColumn";
            this.b2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // b3DataGridViewTextBoxColumn
            // 
            this.b3DataGridViewTextBoxColumn.DataPropertyName = "B3";
            this.b3DataGridViewTextBoxColumn.HeaderText = "B3";
            this.b3DataGridViewTextBoxColumn.Name = "b3DataGridViewTextBoxColumn";
            this.b3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // b4DataGridViewTextBoxColumn
            // 
            this.b4DataGridViewTextBoxColumn.DataPropertyName = "B4";
            this.b4DataGridViewTextBoxColumn.HeaderText = "B4";
            this.b4DataGridViewTextBoxColumn.Name = "b4DataGridViewTextBoxColumn";
            this.b4DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // médiaDataGridViewTextBoxColumn
            // 
            this.médiaDataGridViewTextBoxColumn.DataPropertyName = "Média";
            this.médiaDataGridViewTextBoxColumn.HeaderText = "Média";
            this.médiaDataGridViewTextBoxColumn.Name = "médiaDataGridViewTextBoxColumn";
            this.médiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conceitoDataGridViewTextBoxColumn
            // 
            this.conceitoDataGridViewTextBoxColumn.DataPropertyName = "Conceito";
            this.conceitoDataGridViewTextBoxColumn.HeaderText = "Conceito";
            this.conceitoDataGridViewTextBoxColumn.Name = "conceitoDataGridViewTextBoxColumn";
            this.conceitoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BDS_Alunos
            // 
            this.BDS_Alunos.DataMember = "Alunos";
            this.BDS_Alunos.DataSource = this.DTS_Alunos;
            // 
            // DTS_Alunos
            // 
            this.DTS_Alunos.DataSetName = "NewDataSet";
            this.DTS_Alunos.Tables.AddRange(new System.Data.DataTable[] {
            this.Alunos});
            // 
            // Alunos
            // 
            this.Alunos.Columns.AddRange(new System.Data.DataColumn[] {
            this.disciplina,
            this.matricula,
            this.serie,
            this.nb1,
            this.nb2,
            this.nb3,
            this.nb4,
            this.media,
            this.conceito});
            this.Alunos.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "Matrícula"}, false)});
            this.Alunos.TableName = "Alunos";
            // 
            // disciplina
            // 
            this.disciplina.ColumnName = "Disciplina";
            this.disciplina.ReadOnly = true;
            // 
            // matricula
            // 
            this.matricula.ColumnName = "Matrícula";
            this.matricula.ReadOnly = true;
            // 
            // serie
            // 
            this.serie.ColumnName = "Série";
            this.serie.ReadOnly = true;
            // 
            // nb1
            // 
            this.nb1.ColumnName = "B1";
            this.nb1.ReadOnly = true;
            // 
            // nb2
            // 
            this.nb2.ColumnName = "B2";
            this.nb2.ReadOnly = true;
            // 
            // nb3
            // 
            this.nb3.ColumnName = "B3";
            this.nb3.ReadOnly = true;
            // 
            // nb4
            // 
            this.nb4.ColumnName = "B4";
            this.nb4.ReadOnly = true;
            // 
            // media
            // 
            this.media.ColumnName = "Média";
            this.media.ReadOnly = true;
            // 
            // conceito
            // 
            this.conceito.ColumnName = "Conceito";
            this.conceito.ReadOnly = true;
            // 
            // MNS_Menu
            // 
            this.MNS_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTN_Exportar,
            this.BTN_Sobre});
            this.MNS_Menu.Location = new System.Drawing.Point(0, 0);
            this.MNS_Menu.Name = "MNS_Menu";
            this.MNS_Menu.Size = new System.Drawing.Size(772, 24);
            this.MNS_Menu.TabIndex = 2;
            this.MNS_Menu.Text = "menuStrip1";
            // 
            // BTN_Exportar
            // 
            this.BTN_Exportar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTN_Linha,
            this.BTN_Coluna});
            this.BTN_Exportar.Name = "BTN_Exportar";
            this.BTN_Exportar.Size = new System.Drawing.Size(63, 20);
            this.BTN_Exportar.Text = "Exportar";
            // 
            // BTN_Linha
            // 
            this.BTN_Linha.Name = "BTN_Linha";
            this.BTN_Linha.Size = new System.Drawing.Size(180, 22);
            this.BTN_Linha.Text = "Por Linha";
            this.BTN_Linha.Click += new System.EventHandler(this.ExportarTXT);
            // 
            // BTN_Coluna
            // 
            this.BTN_Coluna.Name = "BTN_Coluna";
            this.BTN_Coluna.Size = new System.Drawing.Size(180, 22);
            this.BTN_Coluna.Text = "Por Coluna";
            this.BTN_Coluna.Click += new System.EventHandler(this.ExportarCSV);
            // 
            // BTN_Sobre
            // 
            this.BTN_Sobre.Name = "BTN_Sobre";
            this.BTN_Sobre.Size = new System.Drawing.Size(49, 20);
            this.BTN_Sobre.Text = "Sobre";
            // 
            // FRM_Alunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MNS_Menu);
            this.MainMenuStrip = this.MNS_Menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Alunos";
            this.Text = "Cadastro de Alunos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_Alunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDS_Alunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTS_Alunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alunos)).EndInit();
            this.MNS_Menu.ResumeLayout(false);
            this.MNS_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_Cadastrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TXT_Nb3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXT_Nb4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXT_Nb2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_Nb1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_Serie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_Matricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_Disciplina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DTG_Alunos;
        private System.Data.DataSet DTS_Alunos;
        private System.Data.DataTable Alunos;
        private System.Data.DataColumn disciplina;
        private System.Data.DataColumn matricula;
        private System.Data.DataColumn serie;
        private System.Data.DataColumn nb1;
        private System.Data.DataColumn nb2;
        private System.Data.DataColumn nb3;
        private System.Data.DataColumn nb4;
        private System.Data.DataColumn media;
        private System.Data.DataColumn conceito;
        private System.Windows.Forms.BindingSource BDS_Alunos;
        private System.Windows.Forms.TextBox TXT_Pesquisa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CMB_Filtro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip MNS_Menu;
        private System.Windows.Forms.ToolStripMenuItem BTN_Exportar;
        private System.Windows.Forms.ToolStripMenuItem BTN_Linha;
        private System.Windows.Forms.ToolStripMenuItem BTN_Coluna;
        private System.Windows.Forms.ToolStripMenuItem BTN_Sobre;
        private System.Windows.Forms.DataGridViewTextBoxColumn disciplinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matrículaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sérieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn b1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn b2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn b3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn b4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn médiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conceitoDataGridViewTextBoxColumn;
        private System.Windows.Forms.SaveFileDialog SFD_Exportar;
    }
}

