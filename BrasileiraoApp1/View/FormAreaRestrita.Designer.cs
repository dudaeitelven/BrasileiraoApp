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
            this.btnTimesCampeonatos = new System.Windows.Forms.Button();
            this.btnCampeonatoRodadas = new System.Windows.Forms.Button();
            this.btnResultadoRodadas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTimesCampeonatos
            // 
            this.btnTimesCampeonatos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimesCampeonatos.Location = new System.Drawing.Point(210, 93);
            this.btnTimesCampeonatos.Name = "btnTimesCampeonatos";
            this.btnTimesCampeonatos.Size = new System.Drawing.Size(180, 40);
            this.btnTimesCampeonatos.TabIndex = 1;
            this.btnTimesCampeonatos.Text = "Times e campeonatos";
            this.btnTimesCampeonatos.UseVisualStyleBackColor = true;
            this.btnTimesCampeonatos.Click += new System.EventHandler(this.btnTimesCampeonatos_Click);
            // 
            // btnCampeonatoRodadas
            // 
            this.btnCampeonatoRodadas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCampeonatoRodadas.Location = new System.Drawing.Point(210, 157);
            this.btnCampeonatoRodadas.Name = "btnCampeonatoRodadas";
            this.btnCampeonatoRodadas.Size = new System.Drawing.Size(180, 40);
            this.btnCampeonatoRodadas.TabIndex = 2;
            this.btnCampeonatoRodadas.Text = "Campeonatos/gerar rodadas";
            this.btnCampeonatoRodadas.UseVisualStyleBackColor = true;
            // 
            // btnResultadoRodadas
            // 
            this.btnResultadoRodadas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnResultadoRodadas.Location = new System.Drawing.Point(210, 225);
            this.btnResultadoRodadas.Name = "btnResultadoRodadas";
            this.btnResultadoRodadas.Size = new System.Drawing.Size(180, 40);
            this.btnResultadoRodadas.TabIndex = 3;
            this.btnResultadoRodadas.Text = "Resultado de rodadas";
            this.btnResultadoRodadas.UseVisualStyleBackColor = true;
            this.btnResultadoRodadas.Click += new System.EventHandler(this.btnResultadoRodadas_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cadastros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gerenciamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Manutenção";
            // 
            // FormAreaRestrita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 372);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnResultadoRodadas);
            this.Controls.Add(this.btnCampeonatoRodadas);
            this.Controls.Add(this.btnTimesCampeonatos);
            this.Name = "FormAreaRestrita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAreaRestrita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimesCampeonatos;
        private System.Windows.Forms.Button btnCampeonatoRodadas;
        private System.Windows.Forms.Button btnResultadoRodadas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}