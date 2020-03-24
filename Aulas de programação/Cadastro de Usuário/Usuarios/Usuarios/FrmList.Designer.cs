namespace Usuarios
{
    partial class FrmList
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
            this.LblNivel = new System.Windows.Forms.Label();
            this.LblEndereco = new System.Windows.Forms.Label();
            this.LblNascimento = new System.Windows.Forms.Label();
            this.LblSexo = new System.Windows.Forms.Label();
            this.BtnAnterior = new System.Windows.Forms.Button();
            this.BtnProximo = new System.Windows.Forms.Button();
            this.LblIndice = new System.Windows.Forms.Label();
            this.LblId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblNome.Location = new System.Drawing.Point(12, 9);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(64, 25);
            this.LblNome.TabIndex = 0;
            this.LblNome.Text = "label1";
            // 
            // LblNivel
            // 
            this.LblNivel.AutoSize = true;
            this.LblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblNivel.Location = new System.Drawing.Point(12, 56);
            this.LblNivel.Name = "LblNivel";
            this.LblNivel.Size = new System.Drawing.Size(64, 25);
            this.LblNivel.TabIndex = 1;
            this.LblNivel.Text = "label2";
            // 
            // LblEndereco
            // 
            this.LblEndereco.AutoSize = true;
            this.LblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblEndereco.Location = new System.Drawing.Point(12, 162);
            this.LblEndereco.Name = "LblEndereco";
            this.LblEndereco.Size = new System.Drawing.Size(64, 25);
            this.LblEndereco.TabIndex = 2;
            this.LblEndereco.Text = "label3";
            // 
            // LblNascimento
            // 
            this.LblNascimento.AutoSize = true;
            this.LblNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblNascimento.Location = new System.Drawing.Point(227, 56);
            this.LblNascimento.Name = "LblNascimento";
            this.LblNascimento.Size = new System.Drawing.Size(64, 25);
            this.LblNascimento.TabIndex = 3;
            this.LblNascimento.Text = "label4";
            // 
            // LblSexo
            // 
            this.LblSexo.AutoSize = true;
            this.LblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblSexo.Location = new System.Drawing.Point(12, 112);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(64, 25);
            this.LblSexo.TabIndex = 4;
            this.LblSexo.Text = "label5";
            // 
            // BtnAnterior
            // 
            this.BtnAnterior.Location = new System.Drawing.Point(17, 295);
            this.BtnAnterior.Name = "BtnAnterior";
            this.BtnAnterior.Size = new System.Drawing.Size(75, 23);
            this.BtnAnterior.TabIndex = 5;
            this.BtnAnterior.Text = "<";
            this.BtnAnterior.UseVisualStyleBackColor = true;
            this.BtnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click);
            // 
            // BtnProximo
            // 
            this.BtnProximo.Location = new System.Drawing.Point(500, 295);
            this.BtnProximo.Name = "BtnProximo";
            this.BtnProximo.Size = new System.Drawing.Size(75, 23);
            this.BtnProximo.TabIndex = 6;
            this.BtnProximo.Text = ">";
            this.BtnProximo.UseVisualStyleBackColor = true;
            this.BtnProximo.Click += new System.EventHandler(this.BtnProximo_Click);
            // 
            // LblIndice
            // 
            this.LblIndice.AutoSize = true;
            this.LblIndice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblIndice.Location = new System.Drawing.Point(267, 295);
            this.LblIndice.Name = "LblIndice";
            this.LblIndice.Size = new System.Drawing.Size(64, 25);
            this.LblIndice.TabIndex = 7;
            this.LblIndice.Text = "label1";
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblId.Location = new System.Drawing.Point(365, 112);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(64, 25);
            this.LblId.TabIndex = 8;
            this.LblId.Text = "label1";
            // 
            // FrmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 330);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.LblIndice);
            this.Controls.Add(this.BtnProximo);
            this.Controls.Add(this.BtnAnterior);
            this.Controls.Add(this.LblSexo);
            this.Controls.Add(this.LblNascimento);
            this.Controls.Add(this.LblEndereco);
            this.Controls.Add(this.LblNivel);
            this.Controls.Add(this.LblNome);
            this.Name = "FrmList";
            this.Text = "Lista de Usuários";
            this.Load += new System.EventHandler(this.FrmList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblNivel;
        private System.Windows.Forms.Label LblEndereco;
        private System.Windows.Forms.Label LblNascimento;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.Button BtnAnterior;
        private System.Windows.Forms.Button BtnProximo;
        private System.Windows.Forms.Label LblIndice;
        private System.Windows.Forms.Label LblId;
    }
}