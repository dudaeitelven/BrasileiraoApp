namespace BrasileiraoApp.View
{
    partial class FormCadastrarResultados
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
            this.rODADABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCAMPEONATOS = new BrasileiraoApp.DataSetCAMPEONATOS();
            this.cAMPEONATOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cAMPEONATOTableAdapter = new BrasileiraoApp.DataSetCAMPEONATOSTableAdapters.CAMPEONATOTableAdapter();
            this.rODADATableAdapter = new BrasileiraoApp.DataSetCAMPEONATOSTableAdapters.RODADATableAdapter();
            this.dataGridViewRodada = new System.Windows.Forms.DataGridView();
            this.grRodada = new System.Windows.Forms.GroupBox();
            this.cbRodada = new System.Windows.Forms.ComboBox();
            this.grCampeonato = new System.Windows.Forms.GroupBox();
            this.cbCampeonato = new System.Windows.Forms.ComboBox();
            this.jOGOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jOGOTableAdapter = new BrasileiraoApp.DataSetCAMPEONATOSTableAdapters.JOGOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rODADABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCAMPEONATOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMPEONATOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRodada)).BeginInit();
            this.grRodada.SuspendLayout();
            this.grCampeonato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jOGOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rODADABindingSource
            // 
            this.rODADABindingSource.DataMember = "RODADA";
            this.rODADABindingSource.DataSource = this.dataSetCAMPEONATOS;
            // 
            // dataSetCAMPEONATOS
            // 
            this.dataSetCAMPEONATOS.DataSetName = "DataSetCAMPEONATOS";
            this.dataSetCAMPEONATOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cAMPEONATOBindingSource
            // 
            this.cAMPEONATOBindingSource.DataMember = "CAMPEONATO";
            this.cAMPEONATOBindingSource.DataSource = this.dataSetCAMPEONATOS;
            // 
            // cAMPEONATOTableAdapter
            // 
            this.cAMPEONATOTableAdapter.ClearBeforeFill = true;
            // 
            // rODADATableAdapter
            // 
            this.rODADATableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewRodada
            // 
            this.dataGridViewRodada.AllowUserToAddRows = false;
            this.dataGridViewRodada.AllowUserToDeleteRows = false;
            this.dataGridViewRodada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRodada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRodada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRodada.Location = new System.Drawing.Point(12, 78);
            this.dataGridViewRodada.Name = "dataGridViewRodada";
            this.dataGridViewRodada.ReadOnly = true;
            this.dataGridViewRodada.Size = new System.Drawing.Size(776, 360);
            this.dataGridViewRodada.TabIndex = 5;
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
            // jOGOBindingSource
            // 
            this.jOGOBindingSource.DataMember = "JOGO";
            this.jOGOBindingSource.DataSource = this.dataSetCAMPEONATOS;
            // 
            // jOGOTableAdapter
            // 
            this.jOGOTableAdapter.ClearBeforeFill = true;
            // 
            // FormCadastrarResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewRodada);
            this.Controls.Add(this.grRodada);
            this.Controls.Add(this.grCampeonato);
            this.Name = "FormCadastrarResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar resultados";
            this.Load += new System.EventHandler(this.FormCadastrarResultados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rODADABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCAMPEONATOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMPEONATOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRodada)).EndInit();
            this.grRodada.ResumeLayout(false);
            this.grCampeonato.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.jOGOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSetCAMPEONATOS dataSetCAMPEONATOS;
        private System.Windows.Forms.BindingSource cAMPEONATOBindingSource;
        private DataSetCAMPEONATOSTableAdapters.CAMPEONATOTableAdapter cAMPEONATOTableAdapter;
        private System.Windows.Forms.BindingSource rODADABindingSource;
        private DataSetCAMPEONATOSTableAdapters.RODADATableAdapter rODADATableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewRodada;
        private System.Windows.Forms.GroupBox grRodada;
        private System.Windows.Forms.ComboBox cbRodada;
        private System.Windows.Forms.GroupBox grCampeonato;
        private System.Windows.Forms.ComboBox cbCampeonato;
        private System.Windows.Forms.BindingSource jOGOBindingSource;
        private DataSetCAMPEONATOSTableAdapters.JOGOTableAdapter jOGOTableAdapter;
    }
}