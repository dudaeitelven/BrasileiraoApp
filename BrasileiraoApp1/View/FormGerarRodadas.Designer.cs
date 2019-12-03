namespace BrasileiraoApp.View
{
    partial class FormGerarRodadas
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
            this.components = new System.ComponentModel.Container();
            this.grCampeonato = new System.Windows.Forms.GroupBox();
            this.cbCampeonato = new System.Windows.Forms.ComboBox();
            this.cAMPEONATOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCAMPEONATOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCAMPEONATOS = new BrasileiraoApp.DataSetCAMPEONATOS();
            this.cAMPEONATOTableAdapter = new BrasileiraoApp.DataSetCAMPEONATOSTableAdapters.CAMPEONATOTableAdapter();
            this.buttonGerarRodadas = new System.Windows.Forms.Button();
            this.dateTimePickerNascimento = new System.Windows.Forms.DateTimePicker();
            this.groupBoxDataInicial = new System.Windows.Forms.GroupBox();
            this.groupBoxRodadas = new System.Windows.Forms.GroupBox();
            this.checkBoxDuasRodadasSemana = new System.Windows.Forms.CheckBox();
            this.grCampeonato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cAMPEONATOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCAMPEONATOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCAMPEONATOS)).BeginInit();
            this.groupBoxDataInicial.SuspendLayout();
            this.groupBoxRodadas.SuspendLayout();
            this.SuspendLayout();
            // 
            // grCampeonato
            // 
            this.grCampeonato.Controls.Add(this.cbCampeonato);
            this.grCampeonato.Location = new System.Drawing.Point(12, 12);
            this.grCampeonato.Name = "grCampeonato";
            this.grCampeonato.Size = new System.Drawing.Size(200, 46);
            this.grCampeonato.TabIndex = 4;
            this.grCampeonato.TabStop = false;
            this.grCampeonato.Text = "Selecione campeonato";
            // 
            // cbCampeonato
            // 
            this.cbCampeonato.AutoCompleteCustomSource.AddRange(new string[] {
            "\'1\'",
            "\'2\'",
            "\'3\'",
            "\'4\'",
            "\'5\'"});
            this.cbCampeonato.DataSource = this.cAMPEONATOBindingSource;
            this.cbCampeonato.DisplayMember = "descricao";
            this.cbCampeonato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCampeonato.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCampeonato.FormattingEnabled = true;
            this.cbCampeonato.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cbCampeonato.Location = new System.Drawing.Point(7, 20);
            this.cbCampeonato.Name = "cbCampeonato";
            this.cbCampeonato.Size = new System.Drawing.Size(187, 21);
            this.cbCampeonato.TabIndex = 0;
            this.cbCampeonato.ValueMember = "id";
            // 
            // cAMPEONATOBindingSource
            // 
            this.cAMPEONATOBindingSource.DataMember = "CAMPEONATO";
            this.cAMPEONATOBindingSource.DataSource = this.dataSetCAMPEONATOSBindingSource;
            // 
            // dataSetCAMPEONATOSBindingSource
            // 
            this.dataSetCAMPEONATOSBindingSource.DataSource = this.dataSetCAMPEONATOS;
            this.dataSetCAMPEONATOSBindingSource.Position = 0;
            // 
            // dataSetCAMPEONATOS
            // 
            this.dataSetCAMPEONATOS.DataSetName = "DataSetCAMPEONATOS";
            this.dataSetCAMPEONATOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cAMPEONATOTableAdapter
            // 
            this.cAMPEONATOTableAdapter.ClearBeforeFill = true;
            // 
            // buttonGerarRodadas
            // 
            this.buttonGerarRodadas.Location = new System.Drawing.Point(565, 17);
            this.buttonGerarRodadas.Name = "buttonGerarRodadas";
            this.buttonGerarRodadas.Size = new System.Drawing.Size(146, 41);
            this.buttonGerarRodadas.TabIndex = 5;
            this.buttonGerarRodadas.Text = "Gerar rodadas";
            this.buttonGerarRodadas.UseVisualStyleBackColor = true;
            this.buttonGerarRodadas.Click += new System.EventHandler(this.buttonGerarRodadas_Click);
            // 
            // dateTimePickerNascimento
            // 
            this.dateTimePickerNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNascimento.Location = new System.Drawing.Point(25, 19);
            this.dateTimePickerNascimento.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerNascimento.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerNascimento.Name = "dateTimePickerNascimento";
            this.dateTimePickerNascimento.Size = new System.Drawing.Size(90, 20);
            this.dateTimePickerNascimento.TabIndex = 18;
            this.dateTimePickerNascimento.TabStop = false;
            // 
            // groupBoxDataInicial
            // 
            this.groupBoxDataInicial.Controls.Add(this.dateTimePickerNascimento);
            this.groupBoxDataInicial.Location = new System.Drawing.Point(218, 12);
            this.groupBoxDataInicial.Name = "groupBoxDataInicial";
            this.groupBoxDataInicial.Size = new System.Drawing.Size(147, 46);
            this.groupBoxDataInicial.TabIndex = 19;
            this.groupBoxDataInicial.TabStop = false;
            this.groupBoxDataInicial.Text = "Data inicial";
            // 
            // groupBoxRodadas
            // 
            this.groupBoxRodadas.Controls.Add(this.checkBoxDuasRodadasSemana);
            this.groupBoxRodadas.Location = new System.Drawing.Point(371, 12);
            this.groupBoxRodadas.Name = "groupBoxRodadas";
            this.groupBoxRodadas.Size = new System.Drawing.Size(188, 46);
            this.groupBoxRodadas.TabIndex = 20;
            this.groupBoxRodadas.TabStop = false;
            this.groupBoxRodadas.Text = "Rodadas";
            // 
            // checkBoxDuasRodadasSemana
            // 
            this.checkBoxDuasRodadasSemana.AutoSize = true;
            this.checkBoxDuasRodadasSemana.Location = new System.Drawing.Point(17, 19);
            this.checkBoxDuasRodadasSemana.Name = "checkBoxDuasRodadasSemana";
            this.checkBoxDuasRodadasSemana.Size = new System.Drawing.Size(156, 17);
            this.checkBoxDuasRodadasSemana.TabIndex = 0;
            this.checkBoxDuasRodadasSemana.Text = "Duas rodadas por semana?";
            this.checkBoxDuasRodadasSemana.UseVisualStyleBackColor = true;
            // 
            // FormGerarRodadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 70);
            this.Controls.Add(this.groupBoxRodadas);
            this.Controls.Add(this.groupBoxDataInicial);
            this.Controls.Add(this.buttonGerarRodadas);
            this.Controls.Add(this.grCampeonato);
            this.Name = "FormGerarRodadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerar rodadas";
            this.Load += new System.EventHandler(this.FormGerarRodadas_Load);
            this.grCampeonato.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cAMPEONATOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCAMPEONATOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCAMPEONATOS)).EndInit();
            this.groupBoxDataInicial.ResumeLayout(false);
            this.groupBoxRodadas.ResumeLayout(false);
            this.groupBoxRodadas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grCampeonato;
        private System.Windows.Forms.ComboBox cbCampeonato;
        private System.Windows.Forms.BindingSource dataSetCAMPEONATOSBindingSource;
        private DataSetCAMPEONATOS dataSetCAMPEONATOS;
        private System.Windows.Forms.BindingSource cAMPEONATOBindingSource;
        private DataSetCAMPEONATOSTableAdapters.CAMPEONATOTableAdapter cAMPEONATOTableAdapter;
        private System.Windows.Forms.Button buttonGerarRodadas;
        private System.Windows.Forms.DateTimePicker dateTimePickerNascimento;
        private System.Windows.Forms.GroupBox groupBoxDataInicial;
        private System.Windows.Forms.GroupBox groupBoxRodadas;
        private System.Windows.Forms.CheckBox checkBoxDuasRodadasSemana;
    }
}