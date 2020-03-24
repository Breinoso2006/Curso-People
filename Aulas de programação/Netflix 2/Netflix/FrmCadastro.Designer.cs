namespace Netflix
{
    partial class FrmCadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblDuracao = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TbNome = new System.Windows.Forms.TextBox();
            this.TbSinopse = new System.Windows.Forms.TextBox();
            this.CbClassificacao = new System.Windows.Forms.ComboBox();
            this.TbDuracao = new System.Windows.Forms.TrackBar();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.TbLancamento = new System.Windows.Forms.TextBox();
            this.CbTerror = new System.Windows.Forms.CheckBox();
            this.CbAventura = new System.Windows.Forms.CheckBox();
            this.CbComedia = new System.Windows.Forms.CheckBox();
            this.CbAcao = new System.Windows.Forms.CheckBox();
            this.CbRomance = new System.Windows.Forms.CheckBox();
            this.CbSuspense = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.TbDuracao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sinopse: ";
            // 
            // LblDuracao
            // 
            this.LblDuracao.AutoSize = true;
            this.LblDuracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblDuracao.Location = new System.Drawing.Point(12, 314);
            this.LblDuracao.Name = "LblDuracao";
            this.LblDuracao.Size = new System.Drawing.Size(97, 25);
            this.LblDuracao.TabIndex = 3;
            this.LblDuracao.Text = "Duração: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(12, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ano de lançamento: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(12, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gênero: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(12, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Classificação Indicativa: ";
            // 
            // TbNome
            // 
            this.TbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TbNome.Location = new System.Drawing.Point(82, 20);
            this.TbNome.Name = "TbNome";
            this.TbNome.Size = new System.Drawing.Size(677, 30);
            this.TbNome.TabIndex = 1;
            this.TbNome.TextChanged += new System.EventHandler(this.TbNome_TextChanged);
            // 
            // TbSinopse
            // 
            this.TbSinopse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TbSinopse.Location = new System.Drawing.Point(98, 61);
            this.TbSinopse.Multiline = true;
            this.TbSinopse.Name = "TbSinopse";
            this.TbSinopse.Size = new System.Drawing.Size(661, 96);
            this.TbSinopse.TabIndex = 2;
            this.TbSinopse.TextChanged += new System.EventHandler(this.TbSinopse_TextChanged);
            // 
            // CbClassificacao
            // 
            this.CbClassificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CbClassificacao.FormattingEnabled = true;
            this.CbClassificacao.Items.AddRange(new object[] {
            "0",
            "10",
            "12",
            "14",
            "16",
            "18"});
            this.CbClassificacao.Location = new System.Drawing.Point(246, 270);
            this.CbClassificacao.Name = "CbClassificacao";
            this.CbClassificacao.Size = new System.Drawing.Size(180, 33);
            this.CbClassificacao.TabIndex = 10;
            // 
            // TbDuracao
            // 
            this.TbDuracao.Location = new System.Drawing.Point(105, 342);
            this.TbDuracao.Maximum = 300;
            this.TbDuracao.Name = "TbDuracao";
            this.TbDuracao.Size = new System.Drawing.Size(348, 45);
            this.TbDuracao.TabIndex = 11;
            this.TbDuracao.Scroll += new System.EventHandler(this.TbDuracao_Scroll);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnSalvar.Location = new System.Drawing.Point(636, 290);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(80, 30);
            this.BtnSalvar.TabIndex = 12;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.EnabledChanged += new System.EventHandler(this.TbNome_TextChanged);
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnLimpar.Location = new System.Drawing.Point(636, 342);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(80, 30);
            this.BtnLimpar.TabIndex = 13;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // TbLancamento
            // 
            this.TbLancamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TbLancamento.Location = new System.Drawing.Point(210, 171);
            this.TbLancamento.Name = "TbLancamento";
            this.TbLancamento.Size = new System.Drawing.Size(211, 30);
            this.TbLancamento.TabIndex = 3;
            this.TbLancamento.TextChanged += new System.EventHandler(this.TbLancamento_TextChanged);
            this.TbLancamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbLancamento_KeyPress);
            // 
            // CbTerror
            // 
            this.CbTerror.AutoSize = true;
            this.CbTerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CbTerror.Location = new System.Drawing.Point(98, 227);
            this.CbTerror.Name = "CbTerror";
            this.CbTerror.Size = new System.Drawing.Size(67, 21);
            this.CbTerror.TabIndex = 4;
            this.CbTerror.Text = "Terror";
            this.CbTerror.UseVisualStyleBackColor = true;
            // 
            // CbAventura
            // 
            this.CbAventura.AutoSize = true;
            this.CbAventura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CbAventura.Location = new System.Drawing.Point(171, 227);
            this.CbAventura.Name = "CbAventura";
            this.CbAventura.Size = new System.Drawing.Size(84, 21);
            this.CbAventura.TabIndex = 5;
            this.CbAventura.Text = "Aventura";
            this.CbAventura.UseVisualStyleBackColor = true;
            // 
            // CbComedia
            // 
            this.CbComedia.AutoSize = true;
            this.CbComedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CbComedia.Location = new System.Drawing.Point(261, 228);
            this.CbComedia.Name = "CbComedia";
            this.CbComedia.Size = new System.Drawing.Size(82, 21);
            this.CbComedia.TabIndex = 6;
            this.CbComedia.Text = "Comédia";
            this.CbComedia.UseVisualStyleBackColor = true;
            // 
            // CbAcao
            // 
            this.CbAcao.AutoSize = true;
            this.CbAcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CbAcao.Location = new System.Drawing.Point(349, 228);
            this.CbAcao.Name = "CbAcao";
            this.CbAcao.Size = new System.Drawing.Size(59, 21);
            this.CbAcao.TabIndex = 7;
            this.CbAcao.Text = "Ação";
            this.CbAcao.UseVisualStyleBackColor = true;
            // 
            // CbRomance
            // 
            this.CbRomance.AutoSize = true;
            this.CbRomance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CbRomance.Location = new System.Drawing.Point(414, 228);
            this.CbRomance.Name = "CbRomance";
            this.CbRomance.Size = new System.Drawing.Size(87, 21);
            this.CbRomance.TabIndex = 8;
            this.CbRomance.Text = "Romance";
            this.CbRomance.UseVisualStyleBackColor = true;
            // 
            // CbSuspense
            // 
            this.CbSuspense.AutoSize = true;
            this.CbSuspense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CbSuspense.Location = new System.Drawing.Point(507, 228);
            this.CbSuspense.Name = "CbSuspense";
            this.CbSuspense.Size = new System.Drawing.Size(90, 21);
            this.CbSuspense.TabIndex = 9;
            this.CbSuspense.Text = "Suspense";
            this.CbSuspense.UseVisualStyleBackColor = true;
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 459);
            this.Controls.Add(this.CbSuspense);
            this.Controls.Add(this.CbRomance);
            this.Controls.Add(this.CbAcao);
            this.Controls.Add(this.CbComedia);
            this.Controls.Add(this.CbAventura);
            this.Controls.Add(this.CbTerror);
            this.Controls.Add(this.TbLancamento);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.TbDuracao);
            this.Controls.Add(this.CbClassificacao);
            this.Controls.Add(this.TbSinopse);
            this.Controls.Add(this.TbNome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblDuracao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Filme";
            this.Load += new System.EventHandler(this.FrmCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TbDuracao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblDuracao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbNome;
        private System.Windows.Forms.TextBox TbSinopse;
        private System.Windows.Forms.ComboBox CbClassificacao;
        private System.Windows.Forms.TrackBar TbDuracao;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.TextBox TbLancamento;
        private System.Windows.Forms.CheckBox CbTerror;
        private System.Windows.Forms.CheckBox CbAventura;
        private System.Windows.Forms.CheckBox CbComedia;
        private System.Windows.Forms.CheckBox CbAcao;
        private System.Windows.Forms.CheckBox CbRomance;
        private System.Windows.Forms.CheckBox CbSuspense;
    }
}