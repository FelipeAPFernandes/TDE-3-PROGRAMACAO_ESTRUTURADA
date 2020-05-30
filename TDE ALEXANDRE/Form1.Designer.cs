namespace TDE_ALEXANDRE
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minecraft", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(1, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "TELA DE CADASTROS";
            // 
            // mtbCPF
            // 
            this.mtbCPF.BackColor = System.Drawing.SystemColors.MenuText;
            this.mtbCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbCPF.Font = new System.Drawing.Font("Minecraft", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCPF.ForeColor = System.Drawing.Color.Beige;
            this.mtbCPF.Location = new System.Drawing.Point(29, 237);
            this.mtbCPF.Mask = "000/000/000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(185, 28);
            this.mtbCPF.TabIndex = 2;
            this.mtbCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbCPF_MaskInputRejected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minecraft", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(25, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Minecraft", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(232, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sobrenome:";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtSobrenome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSobrenome.Font = new System.Drawing.Font("Minecraft", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobrenome.ForeColor = System.Drawing.Color.Beige;
            this.txtSobrenome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtSobrenome.Location = new System.Drawing.Point(236, 168);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(248, 28);
            this.txtSobrenome.TabIndex = 5;
            this.txtSobrenome.TextChanged += new System.EventHandler(this.txtSobrenome_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Minecraft", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.Beige;
            this.txtNome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtNome.Location = new System.Drawing.Point(29, 168);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(185, 28);
            this.txtNome.TabIndex = 6;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Minecraft", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(25, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "CPF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Minecraft", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Goldenrod;
            this.label5.Location = new System.Drawing.Point(263, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Confirmar Senha:";
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtConfirmarSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmarSenha.Font = new System.Drawing.Font("Minecraft", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarSenha.ForeColor = System.Drawing.Color.Beige;
            this.txtConfirmarSenha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtConfirmarSenha.Location = new System.Drawing.Point(267, 306);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.PasswordChar = '*';
            this.txtConfirmarSenha.Size = new System.Drawing.Size(217, 28);
            this.txtConfirmarSenha.TabIndex = 9;
            this.txtConfirmarSenha.TextChanged += new System.EventHandler(this.txtConfirmarSenha_TextChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Font = new System.Drawing.Font("Minecraft", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.Beige;
            this.txtSenha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtSenha.Location = new System.Drawing.Point(29, 306);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(219, 28);
            this.txtSenha.TabIndex = 10;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Minecraft", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Goldenrod;
            this.label6.Location = new System.Drawing.Point(25, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Senha:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Minecraft", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Beige;
            this.txtEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtEmail.Location = new System.Drawing.Point(236, 237);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(248, 28);
            this.txtEmail.TabIndex = 12;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Minecraft", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Goldenrod;
            this.label7.Location = new System.Drawing.Point(232, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "E-mail:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Font = new System.Drawing.Font("Minecraft", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalvar.Location = new System.Drawing.Point(109, 362);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(129, 50);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Font = new System.Drawing.Font("Minecraft", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpar.Location = new System.Drawing.Point(275, 362);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(129, 50);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(517, 454);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtConfirmarSenha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtbCPF);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TelaDeCadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

