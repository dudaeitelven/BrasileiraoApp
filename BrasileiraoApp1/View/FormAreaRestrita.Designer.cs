namespace BrasileiraoApp.View
{
    partial class FormAreaRestrita
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
            this.buttonCadastarTime = new System.Windows.Forms.Button();
            this.buttonVincularTimes = new System.Windows.Forms.Button();
            this.buttonResultadoRodadas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCadastrarCampeonato = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonGerarRodadas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCadastarTime
            // 
            this.buttonCadastarTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCadastarTime.Location = new System.Drawing.Point(15, 40);
            this.buttonCadastarTime.Name = "buttonCadastarTime";
            this.buttonCadastarTime.Size = new System.Drawing.Size(180, 40);
            this.buttonCadastarTime.TabIndex = 1;
            this.buttonCadastarTime.Text = "Times";
            this.buttonCadastarTime.UseVisualStyleBackColor = true;
            this.buttonCadastarTime.Click += new System.EventHandler(this.btnTimesCampeonatos_Click);
            // 
            // buttonVincularTimes
            // 
            this.buttonVincularTimes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonVincularTimes.Location = new System.Drawing.Point(15, 130);
            this.buttonVincularTimes.Name = "buttonVincularTimes";
            this.buttonVincularTimes.Size = new System.Drawing.Size(180, 40);
            this.buttonVincularTimes.TabIndex = 3;
            this.buttonVincularTimes.Text = "Vincular times";
            this.buttonVincularTimes.UseVisualStyleBackColor = true;
            this.buttonVincularTimes.Click += new System.EventHandler(this.buttonVincularTimes_Click);
            // 
            // buttonResultadoRodadas
            // 
            this.buttonResultadoRodadas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonResultadoRodadas.Location = new System.Drawing.Point(15, 217);
            this.buttonResultadoRodadas.Name = "buttonResultadoRodadas";
            this.buttonResultadoRodadas.Size = new System.Drawing.Size(180, 40);
            this.buttonResultadoRodadas.TabIndex = 5;
            this.buttonResultadoRodadas.Text = "Resultado de rodadas";
            this.buttonResultadoRodadas.UseVisualStyleBackColor = true;
            this.buttonResultadoRodadas.Click += new System.EventHandler(this.btnResultadoRodadas_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cadastros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gerenciamento do campeonato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Manutenção";
            // 
            // buttonCadastrarCampeonato
            // 
            this.buttonCadastrarCampeonato.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCadastrarCampeonato.Location = new System.Drawing.Point(201, 40);
            this.buttonCadastrarCampeonato.Name = "buttonCadastrarCampeonato";
            this.buttonCadastrarCampeonato.Size = new System.Drawing.Size(180, 40);
            this.buttonCadastrarCampeonato.TabIndex = 2;
            this.buttonCadastrarCampeonato.Text = "Campeonato";
            this.buttonCadastrarCampeonato.UseVisualStyleBackColor = true;
            this.buttonCadastrarCampeonato.Click += new System.EventHandler(this.btnCadastrarCampeonato_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSair.Location = new System.Drawing.Point(15, 292);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(180, 40);
            this.buttonSair.TabIndex = 6;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonGerarRodadas
            // 
            this.buttonGerarRodadas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonGerarRodadas.Location = new System.Drawing.Point(201, 130);
            this.buttonGerarRodadas.Name = "buttonGerarRodadas";
            this.buttonGerarRodadas.Size = new System.Drawing.Size(180, 40);
            this.buttonGerarRodadas.TabIndex = 4;
            this.buttonGerarRodadas.Text = "Gerar rodadas";
            this.buttonGerarRodadas.UseVisualStyleBackColor = true;
            this.buttonGerarRodadas.Click += new System.EventHandler(this.buttonGerarRodadas_Click);
            // 
            // FormAreaRestrita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(606, 372);
            this.Controls.Add(this.buttonGerarRodadas);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonCadastrarCampeonato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonResultadoRodadas);
            this.Controls.Add(this.buttonVincularTimes);
            this.Controls.Add(this.buttonCadastarTime);
            this.MaximizeBox = false;
            this.Name = "FormAreaRestrita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Área restrita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCadastarTime;
        private System.Windows.Forms.Button buttonVincularTimes;
        private System.Windows.Forms.Button buttonResultadoRodadas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCadastrarCampeonato;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonGerarRodadas;
    }
}