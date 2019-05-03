namespace BootSorteio
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btGerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.chkBEuquero = new System.Windows.Forms.CheckBox();
            this.chkbVouganhar = new System.Windows.Forms.CheckBox();
            this.chkbJaganhei = new System.Windows.Forms.CheckBox();
            this.chkbEstados = new System.Windows.Forms.CheckBox();
            this.chkbPaises = new System.Windows.Forms.CheckBox();
            this.chkbCidades = new System.Windows.Forms.CheckBox();
            this.chbEscolhe = new System.Windows.Forms.CheckBox();
            this.txtbEscolhe = new System.Windows.Forms.TextBox();
            this.chbMarcar = new System.Windows.Forms.CheckBox();
            this.txtbMarcar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btGerar
            // 
            this.btGerar.Location = new System.Drawing.Point(206, 306);
            this.btGerar.Name = "btGerar";
            this.btGerar.Size = new System.Drawing.Size(75, 23);
            this.btGerar.TabIndex = 0;
            this.btGerar.Text = "Gerar";
            this.btGerar.UseVisualStyleBackColor = true;
            this.btGerar.Click += new System.EventHandler(this.btGerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.AcceptsTab = true;
            this.txtEmail.Location = new System.Drawing.Point(70, 22);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(211, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "URL:";
            // 
            // txtUrl
            // 
            this.txtUrl.AcceptsTab = true;
            this.txtUrl.Location = new System.Drawing.Point(70, 102);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(211, 20);
            this.txtUrl.TabIndex = 6;
            // 
            // txtSenha
            // 
            this.txtSenha.AcceptsTab = true;
            this.txtSenha.Location = new System.Drawing.Point(70, 62);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(211, 20);
            this.txtSenha.TabIndex = 5;
            // 
            // chkBEuquero
            // 
            this.chkBEuquero.AutoSize = true;
            this.chkBEuquero.Location = new System.Drawing.Point(20, 163);
            this.chkBEuquero.Name = "chkBEuquero";
            this.chkBEuquero.Size = new System.Drawing.Size(72, 17);
            this.chkBEuquero.TabIndex = 7;
            this.chkBEuquero.Text = "Eu quero!";
            this.chkBEuquero.UseVisualStyleBackColor = true;
            // 
            // chkbVouganhar
            // 
            this.chkbVouganhar.AutoSize = true;
            this.chkbVouganhar.Location = new System.Drawing.Point(106, 163);
            this.chkbVouganhar.Name = "chkbVouganhar";
            this.chkbVouganhar.Size = new System.Drawing.Size(84, 17);
            this.chkbVouganhar.TabIndex = 8;
            this.chkbVouganhar.Text = "Vou ganhar!";
            this.chkbVouganhar.UseVisualStyleBackColor = true;
            // 
            // chkbJaganhei
            // 
            this.chkbJaganhei.AutoSize = true;
            this.chkbJaganhei.Location = new System.Drawing.Point(206, 163);
            this.chkbJaganhei.Name = "chkbJaganhei";
            this.chkbJaganhei.Size = new System.Drawing.Size(75, 17);
            this.chkbJaganhei.TabIndex = 9;
            this.chkbJaganhei.Text = "Já ganhei!";
            this.chkbJaganhei.UseVisualStyleBackColor = true;
            // 
            // chkbEstados
            // 
            this.chkbEstados.AutoSize = true;
            this.chkbEstados.Location = new System.Drawing.Point(106, 186);
            this.chkbEstados.Name = "chkbEstados";
            this.chkbEstados.Size = new System.Drawing.Size(64, 17);
            this.chkbEstados.TabIndex = 10;
            this.chkbEstados.Text = "Estados";
            this.chkbEstados.UseVisualStyleBackColor = true;
            // 
            // chkbPaises
            // 
            this.chkbPaises.AutoSize = true;
            this.chkbPaises.Location = new System.Drawing.Point(206, 186);
            this.chkbPaises.Name = "chkbPaises";
            this.chkbPaises.Size = new System.Drawing.Size(57, 17);
            this.chkbPaises.TabIndex = 11;
            this.chkbPaises.Text = "Paises";
            this.chkbPaises.UseVisualStyleBackColor = true;
            // 
            // chkbCidades
            // 
            this.chkbCidades.AutoSize = true;
            this.chkbCidades.Location = new System.Drawing.Point(20, 186);
            this.chkbCidades.Name = "chkbCidades";
            this.chkbCidades.Size = new System.Drawing.Size(64, 17);
            this.chkbCidades.TabIndex = 12;
            this.chkbCidades.Text = "Cidades";
            this.chkbCidades.UseVisualStyleBackColor = true;
            // 
            // chbEscolhe
            // 
            this.chbEscolhe.AutoSize = true;
            this.chbEscolhe.Location = new System.Drawing.Point(20, 140);
            this.chbEscolhe.Name = "chbEscolhe";
            this.chbEscolhe.Size = new System.Drawing.Size(102, 17);
            this.chbEscolhe.TabIndex = 13;
            this.chbEscolhe.Text = "Escolher a frase";
            this.chbEscolhe.UseVisualStyleBackColor = true;
            this.chbEscolhe.CheckedChanged += new System.EventHandler(this.valida);
            // 
            // txtbEscolhe
            // 
            this.txtbEscolhe.AcceptsTab = true;
            this.txtbEscolhe.Location = new System.Drawing.Point(39, 163);
            this.txtbEscolhe.Name = "txtbEscolhe";
            this.txtbEscolhe.Size = new System.Drawing.Size(211, 20);
            this.txtbEscolhe.TabIndex = 14;
            this.txtbEscolhe.Visible = false;
            // 
            // chbMarcar
            // 
            this.chbMarcar.AutoSize = true;
            this.chbMarcar.Location = new System.Drawing.Point(128, 140);
            this.chbMarcar.Name = "chbMarcar";
            this.chbMarcar.Size = new System.Drawing.Size(95, 17);
            this.chbMarcar.TabIndex = 15;
            this.chbMarcar.Text = "Marcar amigos";
            this.chbMarcar.UseVisualStyleBackColor = true;
            this.chbMarcar.CheckedChanged += new System.EventHandler(this.valida);
            // 
            // txtbMarcar
            // 
            this.txtbMarcar.AcceptsTab = true;
            this.txtbMarcar.Location = new System.Drawing.Point(229, 140);
            this.txtbMarcar.Name = "txtbMarcar";
            this.txtbMarcar.Size = new System.Drawing.Size(52, 20);
            this.txtbMarcar.TabIndex = 16;
            this.txtbMarcar.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 355);
            this.Controls.Add(this.txtbMarcar);
            this.Controls.Add(this.chbMarcar);
            this.Controls.Add(this.txtbEscolhe);
            this.Controls.Add(this.chbEscolhe);
            this.Controls.Add(this.chkbCidades);
            this.Controls.Add(this.chkbPaises);
            this.Controls.Add(this.chkbEstados);
            this.Controls.Add(this.chkbJaganhei);
            this.Controls.Add(this.chkbVouganhar);
            this.Controls.Add(this.chkBEuquero);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btGerar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.CheckBox chkBEuquero;
        private System.Windows.Forms.CheckBox chkbVouganhar;
        private System.Windows.Forms.CheckBox chkbJaganhei;
        private System.Windows.Forms.CheckBox chkbEstados;
        private System.Windows.Forms.CheckBox chkbPaises;
        private System.Windows.Forms.CheckBox chkbCidades;
        private System.Windows.Forms.CheckBox chbEscolhe;
        private System.Windows.Forms.TextBox txtbEscolhe;
        private System.Windows.Forms.CheckBox chbMarcar;
        private System.Windows.Forms.TextBox txtbMarcar;
    }
}

