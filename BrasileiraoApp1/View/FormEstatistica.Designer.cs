namespace BrasileiraoApp.View
{
    partial class FormEstatistica
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
            this.grRodada = new System.Windows.Forms.GroupBox();
            this.cbRodada = new System.Windows.Forms.ComboBox();
            this.grCampeonato = new System.Windows.Forms.GroupBox();
            this.cbCampeonato = new System.Windows.Forms.ComboBox();
            this.cAMPEONATOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCAMPEONATOS = new BrasileiraoApp.DataSetCAMPEONATOS();
            this.dataSetCAMPEONATOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cAMPEONATOTableAdapter = new BrasileiraoApp.DataSetCAMPEONATOSTableAdapters.CAMPEONATOTableAdapter();
            this.groupBoxEstatistica = new System.Windows.Forms.GroupBox();
            this.cbEstatistica = new System.Windows.Forms.ComboBox();
            this.dataGridViewEstatisticas = new System.Windows.Forms.DataGridView();
            this.grRodada.SuspendLayout();
            this.grCampeonato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cAMPEONATOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCAMPEONATOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCAMPEONATOSBindingSource)).BeginInit();
            this.groupBoxEstatistica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstatisticas)).BeginInit();
            this.SuspendLayout();
            // 
            // grRodada
            // 
            this.grRodada.Controls.Add(this.cbRodada);
            this.grRodada.Location = new System.Drawing.Point(219, 13);
            this.grRodada.Name = "grRodada";
            this.grRodada.Size = new System.Drawing.Size(200, 46);
            this.grRodada.TabIndex = 4;
            this.grRodada.TabStop = false;
            this.grRodada.Text = "Selecione rodada";
            // 
            // cbRodada
            // 
            this.cbRodada.AutoCompleteCustomSource.AddRange(new string[] {
            "\'1\'",
            "\'2\'",
            "\'3\'",
            "\'4\'",
            "\'5\'"});
            this.cbRodada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRodada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbRodada.FormattingEnabled = true;
            this.cbRodada.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cbRodada.Location = new System.Drawing.Point(7, 20);
            this.cbRodada.Name = "cbRodada";
            this.cbRodada.Size = new System.Drawing.Size(187, 21);
            this.cbRodada.TabIndex = 0;
            this.cbRodada.SelectedIndexChanged += new System.EventHandler(this.cbRodada_SelectedIndexChanged);
            // 
            // grCampeonato
            // 
            this.grCampeonato.Controls.Add(this.cbCampeonato);
            this.grCampeonato.Location = new System.Drawing.Point(13, 13);
            this.grCampeonato.Name = "grCampeonato";
            this.grCampeonato.Size = new System.Drawing.Size(200, 46);
            this.grCampeonato.TabIndex = 3;
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
            this.cbCampeonato.SelectedIndexChanged += new System.EventHandler(this.cbCampeonato_SelectedIndexChanged);
            // 
            // cAMPEONATOBindingSource
            // 
            this.cAMPEONATOBindingSource.DataMember = "CAMPEONATO";
            this.cAMPEONATOBindingSource.DataSource = this.dataSetCAMPEONATOS;
            // 
            // dataSetCAMPEONATOS
            // 
            this.dataSetCAMPEONATOS.DataSetName = "DataSetCAMPEONATOS";
            this.dataSetCAMPEONATOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetCAMPEONATOSBindingSource
            // 
            this.dataSetCAMPEONATOSBindingSource.DataSource = this.dataSetCAMPEONATOS;
            this.dataSetCAMPEONATOSBindingSource.Position = 0;
            // 
            // cAMPEONATOTableAdapter
            // 
            this.cAMPEONATOTableAdapter.ClearBeforeFill = true;
            // 
            // groupBoxEstatistica
            // 
            this.groupBoxEstatistica.Controls.Add(this.cbEstatistica);
            this.groupBoxEstatistica.Location = new System.Drawing.Point(425, 13);
            this.groupBoxEstatistica.Name = "groupBoxEstatistica";
            this.groupBoxEstatistica.Size = new System.Drawing.Size(200, 46);
            this.groupBoxEstatistica.TabIndex = 6;
            this.groupBoxEstatistica.TabStop = false;
            this.groupBoxEstatistica.Text = "Selecione estatistica";
            // 
            // cbEstatistica
            // 
            this.cbEstatistica.AutoCompleteCustomSource.AddRange(new string[] {
            "\'1\'",
            "\'2\'",
            "\'3\'",
            "\'4\'",
            "\'5\'"});
            this.cbEstatistica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstatistica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbEstatistica.FormattingEnabled = true;
            this.cbEstatistica.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cbEstatistica.Location = new System.Drawing.Point(7, 20);
            this.cbEstatistica.Name = "cbEstatistica";
            this.cbEstatistica.Size = new System.Drawing.Size(187, 21);
            this.cbEstatistica.TabIndex = 0;
            this.cbEstatistica.SelectedIndexChanged += new System.EventHandler(this.cbEstatistica_SelectedIndexChanged);
            // 
            // dataGridViewEstatisticas
            // 
            this.dataGridViewEstatisticas.AllowUserToAddRows = false;
            this.dataGridViewEstatisticas.AllowUserToDeleteRows = false;
            this.dataGridViewEstatisticas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEstatisticas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEstatisticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstatisticas.Location = new System.Drawing.Point(12, 78);
            this.dataGridViewEstatisticas.Name = "dataGridViewEstatisticas";
            this.dataGridViewEstatisticas.ReadOnly = true;
            this.dataGridViewEstatisticas.Size = new System.Drawing.Size(776, 360);
            this.dataGridViewEstatisticas.TabIndex = 7;
            // 
            // FormEstatistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewEstatisticas);
            this.Controls.Add(this.groupBoxEstatistica);
            this.Controls.Add(this.grRodada);
            this.Controls.Add(this.grCampeonato);
            this.Name = "FormEstatistica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estatísticas";
            this.Load += new System.EventHandler(this.FormEstatistica_Load);
            this.grRodada.ResumeLayout(false);
            this.grCampeonato.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cAMPEONATOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCAMPEONATOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCAMPEONATOSBindingSource)).EndInit();
            this.groupBoxEstatistica.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstatisticas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grRodada;
        private System.Windows.Forms.ComboBox cbRodada;
        private System.Windows.Forms.GroupBox grCampeonato;
        private System.Windows.Forms.ComboBox cbCampeonato;
        private System.Windows.Forms.BindingSource dataSetCAMPEONATOSBindingSource;
        private DataSetCAMPEONATOS dataSetCAMPEONATOS;
        private System.Windows.Forms.BindingSource cAMPEONATOBindingSource;
        private DataSetCAMPEONATOSTableAdapters.CAMPEONATOTableAdapter cAMPEONATOTableAdapter;
        private System.Windows.Forms.GroupBox groupBoxEstatistica;
        private System.Windows.Forms.ComboBox cbEstatistica;
        private System.Windows.Forms.DataGridView dataGridViewEstatisticas;
    }
}