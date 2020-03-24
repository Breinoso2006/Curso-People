namespace Usuarios
{
    partial class FrmCadUsuario
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TbNome = new System.Windows.Forms.TextBox();
            this.RbMasculino = new System.Windows.Forms.RadioButton();
            this.RbFeminino = new System.Windows.Forms.RadioButton();
            this.DtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.TbEndereco = new System.Windows.Forms.TextBox();
            this.TbNivel = new System.Windows.Forms.TextBox();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.LblId = new System.Windows.Forms.Label();
            this.TbID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(24, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nível:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(238, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Endereço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(15, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nascimento: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(24, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sexo: ";
            // 
            // TbNome
            // 
            this.TbNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TbNome.Location = new System.Drawing.Point(118, 17);
            this.TbNome.Margin = new System.Windows.Forms.Padding(6);
            this.TbNome.Name = "TbNome";
            this.TbNome.Size = new System.Drawing.Size(681, 30);
            this.TbNome.TabIndex = 5;
            this.TbNome.TextChanged += new System.EventHandler(this.TbNome_TextChanged);
            // 
            // RbMasculino
            // 
            this.RbMasculino.AutoSize = true;
            this.RbMasculino.Location = new System.Drawing.Point(118, 133);
            this.RbMasculino.Name = "RbMasculino";
            this.RbMasculino.Size = new System.Drawing.Size(119, 29);
            this.RbMasculino.TabIndex = 6;
            this.RbMasculino.TabStop = true;
            this.RbMasculino.Text = "Masculino";
            this.RbMasculino.UseVisualStyleBackColor = true;
            this.RbMasculino.CheckedChanged += new System.EventHandler(this.RbMasculino_CheckedChanged);
            // 
            // RbFeminino
            // 
            this.RbFeminino.AutoSize = true;
            this.RbFeminino.Location = new System.Drawing.Point(118, 168);
            this.RbFeminino.Name = "RbFeminino";
            this.RbFeminino.Size = new System.Drawing.Size(110, 29);
            this.RbFeminino.TabIndex = 7;
            this.RbFeminino.TabStop = true;
            this.RbFeminino.Text = "Feminino";
            this.RbFeminino.UseVisualStyleBackColor = true;
            this.RbFeminino.CheckedChanged += new System.EventHandler(this.RbFeminino_CheckedChanged);
            // 
            // DtpNascimento
            // 
            this.DtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpNascimento.Location = new System.Drawing.Point(150, 224);
            this.DtpNascimento.Name = "DtpNascimento";
            this.DtpNascimento.Size = new System.Drawing.Size(143, 30);
            this.DtpNascimento.TabIndex = 8;
            this.DtpNascimento.Value = new System.DateTime(2017, 7, 20, 0, 0, 0, 0);
            // 
            // TbEndereco
            // 
            this.TbEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TbEndereco.Location = new System.Drawing.Point(337, 76);
            this.TbEndereco.Multiline = true;
            this.TbEndereco.Name = "TbEndereco";
            this.TbEndereco.Size = new System.Drawing.Size(462, 110);
            this.TbEndereco.TabIndex = 9;
            this.TbEndereco.TextChanged += new System.EventHandler(this.TbEndereco_TextChanged);
            // 
            // TbNivel
            // 
            this.TbNivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TbNivel.Location = new System.Drawing.Point(118, 73);
            this.TbNivel.Margin = new System.Windows.Forms.Padding(6);
            this.TbNivel.Name = "TbNivel";
            this.TbNivel.Size = new System.Drawing.Size(110, 30);
            this.TbNivel.TabIndex = 10;
            this.TbNivel.TextChanged += new System.EventHandler(this.TbNivel_TextChanged);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(20, 274);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(85, 35);
            this.BtnLimpar.TabIndex = 11;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(599, 274);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(85, 35);
            this.BtnSalvar.TabIndex = 12;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblId.Location = new System.Drawing.Point(392, 224);
            this.LblId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(34, 25);
            this.LblId.TabIndex = 13;
            this.LblId.Text = "Id:";
            // 
            // TbID
            // 
            this.TbID.BackColor = System.Drawing.Color.White;
            this.TbID.Enabled = false;
            this.TbID.Location = new System.Drawing.Point(438, 221);
            this.TbID.Margin = new System.Windows.Forms.Padding(6);
            this.TbID.Name = "TbID";
            this.TbID.Size = new System.Drawing.Size(361, 30);
            this.TbID.TabIndex = 14;
            this.TbID.Text = "Fornecido pelo sistema";
            // 
            // FrmCadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 334);
            this.Controls.Add(this.TbID);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.TbNivel);
            this.Controls.Add(this.TbEndereco);
            this.Controls.Add(this.DtpNascimento);
            this.Controls.Add(this.RbFeminino);
            this.Controls.Add(this.RbMasculino);
            this.Controls.Add(this.TbNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmCadUsuario";
            this.Text = "Cadastro de Usuário";
            this.Load += new System.EventHandler(this.FrmCadUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbNome;
        private System.Windows.Forms.RadioButton RbMasculino;
        private System.Windows.Forms.RadioButton RbFeminino;
        private System.Windows.Forms.DateTimePicker DtpNascimento;
        private System.Windows.Forms.TextBox TbEndereco;
        private System.Windows.Forms.TextBox TbNivel;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.TextBox TbID;
    }
}