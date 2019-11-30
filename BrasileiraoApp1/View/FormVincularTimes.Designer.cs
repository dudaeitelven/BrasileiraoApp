namespace BrasileiraoApp.View
{
    partial class FormVincularTimes
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
            this.dataGridViewNaoVinculados = new System.Windows.Forms.DataGridView();
            this.dataGridViewVinculados = new System.Windows.Forms.DataGridView();
            this.buttonVincular = new System.Windows.Forms.Button();
            this.buttonDesvincular = new System.Windows.Forms.Button();
            this.grCampeonato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cAMPEONATOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCAMPEONATOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCAMPEONATOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNaoVinculados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVinculados)).BeginInit();
            this.SuspendLayout();
            // 
            // grCampeonato
            // 
            this.grCampeonato.Controls.Add(this.cbCampeonato);
            this.grCampeonato.Location = new System.Drawing.Point(12, 12);
            this.grCampeonato.Name = "grCampeonato";
            this.grCampeonato.Size = new System.Drawing.Size(200, 46);
            this.grCampeonato.TabIndex = 1;
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
            // dataGridViewNaoVinculados
            // 
            this.dataGridViewNaoVinculados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewNaoVinculados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNaoVinculados.Location = new System.Drawing.Point(13, 65);
            this.dataGridViewNaoVinculados.Name = "dataGridViewNaoVinculados";
            this.dataGridViewNaoVinculados.Size = new System.Drawing.Size(344, 373);
            this.dataGridViewNaoVinculados.TabIndex = 2;
            // 
            // dataGridViewVinculados
            // 
            this.dataGridViewVinculados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewVinculados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVinculados.Location = new System.Drawing.Point(444, 65);
            this.dataGridViewVinculados.Name = "dataGridViewVinculados";
            this.dataGridViewVinculados.Size = new System.Drawing.Size(344, 373);
            this.dataGridViewVinculados.TabIndex = 3;
            // 
            // buttonVincular
            // 
            this.buttonVincular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonVincular.Location = new System.Drawing.Point(363, 200);
            this.buttonVincular.Name = "buttonVincular";
            this.buttonVincular.Size = new System.Drawing.Size(75, 41);
            this.buttonVincular.TabIndex = 4;
            this.buttonVincular.Text = ">>>";
            this.buttonVincular.UseVisualStyleBackColor = true;
            // 
            // buttonDesvincular
            // 
            this.buttonDesvincular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDesvincular.Location = new System.Drawing.Point(363, 260);
            this.buttonDesvincular.Name = "buttonDesvincular";
            this.buttonDesvincular.Size = new System.Drawing.Size(75, 41);
            this.buttonDesvincular.TabIndex = 5;
            this.buttonDesvincular.Text = "<<<";
            this.buttonDesvincular.UseVisualStyleBackColor = true;
            // 
            // FormVincularTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDesvincular);
            this.Controls.Add(this.buttonVincular);
            this.Controls.Add(this.dataGridViewVinculados);
            this.Controls.Add(this.dataGridViewNaoVinculados);
            this.Controls.Add(this.grCampeonato);
            this.Name = "FormVincularTimes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vincular times";
            this.Load += new System.EventHandler(this.FormVincularTimes_Load);
            this.grCampeonato.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cAMPEONATOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCAMPEONATOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCAMPEONATOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNaoVinculados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVinculados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grCampeonato;
        private System.Windows.Forms.ComboBox cbCampeonato;
        private System.Windows.Forms.BindingSource dataSetCAMPEONATOSBindingSource;
        private DataSetCAMPEONATOS dataSetCAMPEONATOS;
        private System.Windows.Forms.BindingSource cAMPEONATOBindingSource;
        private DataSetCAMPEONATOSTableAdapters.CAMPEONATOTableAdapter cAMPEONATOTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewNaoVinculados;
        private System.Windows.Forms.DataGridView dataGridViewVinculados;
        private System.Windows.Forms.Button buttonVincular;
        private System.Windows.Forms.Button buttonDesvincular;
    }
}