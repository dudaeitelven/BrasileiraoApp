namespace BrasileiraoApp1
{
    partial class FormInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.btnAreaRestrita = new System.Windows.Forms.Button();
            this.btnRodadas = new System.Windows.Forms.Button();
            this.btnEstatisticas = new System.Windows.Forms.Button();
            this.btnTabelaClassificacao = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAreaRestrita
            // 
            this.btnAreaRestrita.Location = new System.Drawing.Point(225, 41);
            this.btnAreaRestrita.Name = "btnAreaRestrita";
            this.btnAreaRestrita.Size = new System.Drawing.Size(180, 40);
            this.btnAreaRestrita.TabIndex = 0;
            this.btnAreaRestrita.Text = "Area restrita";
            this.btnAreaRestrita.UseVisualStyleBackColor = true;
            this.btnAreaRestrita.Click += new System.EventHandler(this.btnAreaRestrita_Click);
            // 
            // btnRodadas
            // 
            this.btnRodadas.Location = new System.Drawing.Point(225, 97);
            this.btnRodadas.Name = "btnRodadas";
            this.btnRodadas.Size = new System.Drawing.Size(180, 40);
            this.btnRodadas.TabIndex = 1;
            this.btnRodadas.Text = "Rodadas";
            this.btnRodadas.UseVisualStyleBackColor = true;
            this.btnRodadas.Click += new System.EventHandler(this.btnRodadas_Click);
            // 
            // btnEstatisticas
            // 
            this.btnEstatisticas.Location = new System.Drawing.Point(225, 152);
            this.btnEstatisticas.Name = "btnEstatisticas";
            this.btnEstatisticas.Size = new System.Drawing.Size(180, 40);
            this.btnEstatisticas.TabIndex = 2;
            this.btnEstatisticas.Text = "Estatisticas";
            this.btnEstatisticas.UseVisualStyleBackColor = true;
            this.btnEstatisticas.Click += new System.EventHandler(this.btnEstatisticas_Click);
            // 
            // btnTabelaClassificacao
            // 
            this.btnTabelaClassificacao.Location = new System.Drawing.Point(225, 207);
            this.btnTabelaClassificacao.Name = "btnTabelaClassificacao";
            this.btnTabelaClassificacao.Size = new System.Drawing.Size(180, 40);
            this.btnTabelaClassificacao.TabIndex = 3;
            this.btnTabelaClassificacao.Text = "Tabela de classificacao";
            this.btnTabelaClassificacao.UseVisualStyleBackColor = true;
            this.btnTabelaClassificacao.Click += new System.EventHandler(this.btnTabelaClassificacao_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(225, 309);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(180, 40);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(622, 411);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnTabelaClassificacao);
            this.Controls.Add(this.btnEstatisticas);
            this.Controls.Add(this.btnRodadas);
            this.Controls.Add(this.btnAreaRestrita);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Campeonato master";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAreaRestrita;
        private System.Windows.Forms.Button btnRodadas;
        private System.Windows.Forms.Button btnEstatisticas;
        private System.Windows.Forms.Button btnTabelaClassificacao;
        private System.Windows.Forms.Button btnSair;
    }
}

