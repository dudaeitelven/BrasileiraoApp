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
            this.SuspendLayout();
            // 
            // btnTimesCampeonatos
            // 
            this.btnTimesCampeonatos.Location = new System.Drawing.Point(210, 93);
            this.btnTimesCampeonatos.Name = "btnTimesCampeonatos";
            this.btnTimesCampeonatos.Size = new System.Drawing.Size(180, 40);
            this.btnTimesCampeonatos.TabIndex = 1;
            this.btnTimesCampeonatos.Text = "Times e campeonatos";
            this.btnTimesCampeonatos.UseVisualStyleBackColor = true;
            // 
            // btnCampeonatoRodadas
            // 
            this.btnCampeonatoRodadas.Location = new System.Drawing.Point(210, 157);
            this.btnCampeonatoRodadas.Name = "btnCampeonatoRodadas";
            this.btnCampeonatoRodadas.Size = new System.Drawing.Size(180, 40);
            this.btnCampeonatoRodadas.TabIndex = 2;
            this.btnCampeonatoRodadas.Text = "Campeonatos/gerar rodadas";
            this.btnCampeonatoRodadas.UseVisualStyleBackColor = true;
            // 
            // btnResultadoRodadas
            // 
            this.btnResultadoRodadas.Location = new System.Drawing.Point(210, 225);
            this.btnResultadoRodadas.Name = "btnResultadoRodadas";
            this.btnResultadoRodadas.Size = new System.Drawing.Size(180, 40);
            this.btnResultadoRodadas.TabIndex = 3;
            this.btnResultadoRodadas.Text = "Resultado de rodadas";
            this.btnResultadoRodadas.UseVisualStyleBackColor = true;
            // 
            // FormAreaRestrita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 372);
            this.Controls.Add(this.btnResultadoRodadas);
            this.Controls.Add(this.btnCampeonatoRodadas);
            this.Controls.Add(this.btnTimesCampeonatos);
            this.Name = "FormAreaRestrita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAreaRestrita";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTimesCampeonatos;
        private System.Windows.Forms.Button btnCampeonatoRodadas;
        private System.Windows.Forms.Button btnResultadoRodadas;
    }
}