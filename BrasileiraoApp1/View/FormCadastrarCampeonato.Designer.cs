namespace BrasileiraoApp.View
{
    partial class FormCadastrarCampeonato
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
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.labelMensagem = new System.Windows.Forms.Label();
            this.groupBoxComplemento = new System.Windows.Forms.GroupBox();
            this.textBoxQtdeTimes = new System.Windows.Forms.TextBox();
            this.labelQtdeTitulos = new System.Windows.Forms.Label();
            this.textBoxHistoria = new System.Windows.Forms.TextBox();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.textBoxAno = new System.Windows.Forms.TextBox();
            this.labelFandacao = new System.Windows.Forms.Label();
            this.labelHistoria = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxComplemento.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Location = new System.Drawing.Point(93, 356);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(120, 23);
            this.buttonConfirmar.TabIndex = 12;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(237, 356);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(120, 23);
            this.buttonSair.TabIndex = 13;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.labelMensagem);
            this.groupBoxInfo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(424, 56);
            this.groupBoxInfo.TabIndex = 15;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Mensagem Sistema";
            // 
            // labelMensagem
            // 
            this.labelMensagem.Location = new System.Drawing.Point(6, 22);
            this.labelMensagem.Name = "labelMensagem";
            this.labelMensagem.Size = new System.Drawing.Size(412, 23);
            this.labelMensagem.TabIndex = 4;
            this.labelMensagem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBoxComplemento
            // 
            this.groupBoxComplemento.Controls.Add(this.textBoxQtdeTimes);
            this.groupBoxComplemento.Controls.Add(this.labelQtdeTitulos);
            this.groupBoxComplemento.Controls.Add(this.textBoxHistoria);
            this.groupBoxComplemento.Controls.Add(this.buttonPesquisar);
            this.groupBoxComplemento.Controls.Add(this.textBoxCodigo);
            this.groupBoxComplemento.Controls.Add(this.labelCodigo);
            this.groupBoxComplemento.Controls.Add(this.textBoxAno);
            this.groupBoxComplemento.Controls.Add(this.labelFandacao);
            this.groupBoxComplemento.Controls.Add(this.labelHistoria);
            this.groupBoxComplemento.Controls.Add(this.textBoxNome);
            this.groupBoxComplemento.Controls.Add(this.labelNome);
            this.groupBoxComplemento.Location = new System.Drawing.Point(12, 74);
            this.groupBoxComplemento.Name = "groupBoxComplemento";
            this.groupBoxComplemento.Size = new System.Drawing.Size(424, 270);
            this.groupBoxComplemento.TabIndex = 14;
            this.groupBoxComplemento.TabStop = false;
            this.groupBoxComplemento.Text = "Dados do Usuario";
            // 
            // textBoxQtdeTimes
            // 
            this.textBoxQtdeTimes.Location = new System.Drawing.Point(116, 109);
            this.textBoxQtdeTimes.MaxLength = 1000;
            this.textBoxQtdeTimes.Name = "textBoxQtdeTimes";
            this.textBoxQtdeTimes.Size = new System.Drawing.Size(114, 20);
            this.textBoxQtdeTimes.TabIndex = 6;
            // 
            // labelQtdeTitulos
            // 
            this.labelQtdeTitulos.AutoSize = true;
            this.labelQtdeTitulos.Location = new System.Drawing.Point(11, 114);
            this.labelQtdeTitulos.Name = "labelQtdeTitulos";
            this.labelQtdeTitulos.Size = new System.Drawing.Size(57, 13);
            this.labelQtdeTitulos.TabIndex = 23;
            this.labelQtdeTitulos.Text = "Qtde times";
            // 
            // textBoxHistoria
            // 
            this.textBoxHistoria.Location = new System.Drawing.Point(116, 135);
            this.textBoxHistoria.MaxLength = 250;
            this.textBoxHistoria.Multiline = true;
            this.textBoxHistoria.Name = "textBoxHistoria";
            this.textBoxHistoria.Size = new System.Drawing.Size(269, 100);
            this.textBoxHistoria.TabIndex = 7;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Enabled = false;
            this.buttonPesquisar.Location = new System.Drawing.Point(265, 28);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(120, 23);
            this.buttonPesquisar.TabIndex = 2;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Enabled = false;
            this.textBoxCodigo.Location = new System.Drawing.Point(116, 28);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(114, 20);
            this.textBoxCodigo.TabIndex = 1;
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(11, 34);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(40, 13);
            this.labelCodigo.TabIndex = 18;
            this.labelCodigo.Text = "Codigo";
            // 
            // textBoxAno
            // 
            this.textBoxAno.Location = new System.Drawing.Point(116, 83);
            this.textBoxAno.MaxLength = 4;
            this.textBoxAno.Name = "textBoxAno";
            this.textBoxAno.Size = new System.Drawing.Size(114, 20);
            this.textBoxAno.TabIndex = 4;
            // 
            // labelFandacao
            // 
            this.labelFandacao.AutoSize = true;
            this.labelFandacao.Location = new System.Drawing.Point(11, 88);
            this.labelFandacao.Name = "labelFandacao";
            this.labelFandacao.Size = new System.Drawing.Size(26, 13);
            this.labelFandacao.TabIndex = 12;
            this.labelFandacao.Text = "Ano";
            // 
            // labelHistoria
            // 
            this.labelHistoria.AutoSize = true;
            this.labelHistoria.Location = new System.Drawing.Point(11, 142);
            this.labelHistoria.Name = "labelHistoria";
            this.labelHistoria.Size = new System.Drawing.Size(42, 13);
            this.labelHistoria.TabIndex = 6;
            this.labelHistoria.Text = "Historia";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(116, 57);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(269, 20);
            this.textBoxNome.TabIndex = 3;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(11, 64);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 4;
            this.labelNome.Text = "Nome";
            // 
            // FormCadastrarCampeonato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 394);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.groupBoxComplemento);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(461, 433);
            this.MinimumSize = new System.Drawing.Size(461, 433);
            this.Name = "FormCadastrarCampeonato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastrarCampeonato";
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxComplemento.ResumeLayout(false);
            this.groupBoxComplemento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label labelMensagem;
        private System.Windows.Forms.GroupBox groupBoxComplemento;
        private System.Windows.Forms.TextBox textBoxQtdeTimes;
        private System.Windows.Forms.Label labelQtdeTitulos;
        private System.Windows.Forms.TextBox textBoxHistoria;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.TextBox textBoxAno;
        private System.Windows.Forms.Label labelFandacao;
        private System.Windows.Forms.Label labelHistoria;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelNome;
    }
}