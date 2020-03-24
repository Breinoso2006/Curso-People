namespace Netflix
{
    partial class Lista
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
            this.LblNome = new System.Windows.Forms.Label();
            this.LblSinopse = new System.Windows.Forms.Label();
            this.LnlLancamento = new System.Windows.Forms.Label();
            this.LblDuracao = new System.Windows.Forms.Label();
            this.LblGenero = new System.Windows.Forms.Label();
            this.LblClassificacao = new System.Windows.Forms.Label();
            this.LblId = new System.Windows.Forms.Label();
            this.BtnAnterior = new System.Windows.Forms.Button();
            this.BtnProximo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(12, 9);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(35, 13);
            this.LblNome.TabIndex = 0;
            this.LblNome.Text = "label1";
            // 
            // LblSinopse
            // 
            this.LblSinopse.AutoSize = true;
            this.LblSinopse.Location = new System.Drawing.Point(12, 59);
            this.LblSinopse.Name = "LblSinopse";
            this.LblSinopse.Size = new System.Drawing.Size(35, 13);
            this.LblSinopse.TabIndex = 1;
            this.LblSinopse.Text = "label2";
            // 
            // LnlLancamento
            // 
            this.LnlLancamento.AutoSize = true;
            this.LnlLancamento.Location = new System.Drawing.Point(12, 111);
            this.LnlLancamento.Name = "LnlLancamento";
            this.LnlLancamento.Size = new System.Drawing.Size(35, 13);
            this.LnlLancamento.TabIndex = 2;
            this.LnlLancamento.Text = "label3";
            // 
            // LblDuracao
            // 
            this.LblDuracao.AutoSize = true;
            this.LblDuracao.Location = new System.Drawing.Point(12, 160);
            this.LblDuracao.Name = "LblDuracao";
            this.LblDuracao.Size = new System.Drawing.Size(35, 13);
            this.LblDuracao.TabIndex = 3;
            this.LblDuracao.Text = "label4";
            // 
            // LblGenero
            // 
            this.LblGenero.AutoSize = true;
            this.LblGenero.Location = new System.Drawing.Point(12, 202);
            this.LblGenero.Name = "LblGenero";
            this.LblGenero.Size = new System.Drawing.Size(35, 13);
            this.LblGenero.TabIndex = 4;
            this.LblGenero.Text = "label5";
            // 
            // LblClassificacao
            // 
            this.LblClassificacao.AutoSize = true;
            this.LblClassificacao.Location = new System.Drawing.Point(345, 202);
            this.LblClassificacao.Name = "LblClassificacao";
            this.LblClassificacao.Size = new System.Drawing.Size(35, 13);
            this.LblClassificacao.TabIndex = 5;
            this.LblClassificacao.Text = "label6";
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(259, 302);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(35, 13);
            this.LblId.TabIndex = 6;
            this.LblId.Text = "label7";
            // 
            // BtnAnterior
            // 
            this.BtnAnterior.Location = new System.Drawing.Point(12, 302);
            this.BtnAnterior.Name = "BtnAnterior";
            this.BtnAnterior.Size = new System.Drawing.Size(75, 23);
            this.BtnAnterior.TabIndex = 7;
            this.BtnAnterior.Text = "<";
            this.BtnAnterior.UseVisualStyleBackColor = true;
            // 
            // BtnProximo
            // 
            this.BtnProximo.Location = new System.Drawing.Point(484, 302);
            this.BtnProximo.Name = "BtnProximo";
            this.BtnProximo.Size = new System.Drawing.Size(75, 23);
            this.BtnProximo.TabIndex = 8;
            this.BtnProximo.Text = ">";
            this.BtnProximo.UseVisualStyleBackColor = true;
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 337);
            this.Controls.Add(this.BtnProximo);
            this.Controls.Add(this.BtnAnterior);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.LblClassificacao);
            this.Controls.Add(this.LblGenero);
            this.Controls.Add(this.LblDuracao);
            this.Controls.Add(this.LnlLancamento);
            this.Controls.Add(this.LblSinopse);
            this.Controls.Add(this.LblNome);
            this.Name = "Lista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblSinopse;
        private System.Windows.Forms.Label LnlLancamento;
        private System.Windows.Forms.Label LblDuracao;
        private System.Windows.Forms.Label LblGenero;
        private System.Windows.Forms.Label LblClassificacao;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Button BtnAnterior;
        private System.Windows.Forms.Button BtnProximo;
    }
}