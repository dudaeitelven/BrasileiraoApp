﻿namespace BrasileiraoApp.View
{
    partial class FormRodadas
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
            this.dataSetCAMPEONATOS = new BrasileiraoApp.DataSetCAMPEONATOS();
            this.cAMPEONATOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cAMPEONATOTableAdapter = new BrasileiraoApp.DataSetCAMPEONATOSTableAdapters.CAMPEONATOTableAdapter();
            this.grRodada = new System.Windows.Forms.GroupBox();
            this.cbRodada = new System.Windows.Forms.ComboBox();
            this.dataSetCAMPEONATOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rODADABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rODADATableAdapter = new BrasileiraoApp.DataSetCAMPEONATOSTableAdapters.RODADATableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCampeonatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroRodadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRodadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grCampeonato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCAMPEONATOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMPEONATOBindingSource)).BeginInit();
            this.grRodada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCAMPEONATOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rODADABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grCampeonato
            // 
            this.grCampeonato.Controls.Add(this.cbCampeonato);
            this.grCampeonato.Location = new System.Drawing.Point(13, 13);
            this.grCampeonato.Name = "grCampeonato";
            this.grCampeonato.Size = new System.Drawing.Size(200, 46);
            this.grCampeonato.TabIndex = 0;
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
            this.cbCampeonato.SelectedIndexChanged += new System.EventHandler(this.cbCampeonato_SelectedIndexChanged);
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
            // grRodada
            // 
            this.grRodada.Controls.Add(this.cbRodada);
            this.grRodada.Location = new System.Drawing.Point(219, 13);
            this.grRodada.Name = "grRodada";
            this.grRodada.Size = new System.Drawing.Size(200, 46);
            this.grRodada.TabIndex = 1;
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
            this.cbRodada.DataSource = this.rODADABindingSource;
            this.cbRodada.DisplayMember = "numeroRodada";
            this.cbRodada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRodada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbRodada.FormattingEnabled = true;
            this.cbRodada.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cbRodada.Location = new System.Drawing.Point(7, 20);
            this.cbRodada.Name = "cbRodada";
            this.cbRodada.Size = new System.Drawing.Size(187, 21);
            this.cbRodada.TabIndex = 0;
            // 
            // dataSetCAMPEONATOSBindingSource
            // 
            this.dataSetCAMPEONATOSBindingSource.DataSource = this.dataSetCAMPEONATOS;
            this.dataSetCAMPEONATOSBindingSource.Position = 0;
            // 
            // rODADABindingSource
            // 
            this.rODADABindingSource.DataMember = "RODADA";
            this.rODADABindingSource.DataSource = this.dataSetCAMPEONATOS;
            // 
            // rODADATableAdapter
            // 
            this.rODADATableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idCampeonatoDataGridViewTextBoxColumn,
            this.numeroRodadaDataGridViewTextBoxColumn,
            this.dataRodadaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rODADABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(775, 372);
            this.dataGridView1.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idCampeonatoDataGridViewTextBoxColumn
            // 
            this.idCampeonatoDataGridViewTextBoxColumn.DataPropertyName = "idCampeonato";
            this.idCampeonatoDataGridViewTextBoxColumn.HeaderText = "idCampeonato";
            this.idCampeonatoDataGridViewTextBoxColumn.Name = "idCampeonatoDataGridViewTextBoxColumn";
            this.idCampeonatoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroRodadaDataGridViewTextBoxColumn
            // 
            this.numeroRodadaDataGridViewTextBoxColumn.DataPropertyName = "numeroRodada";
            this.numeroRodadaDataGridViewTextBoxColumn.HeaderText = "numeroRodada";
            this.numeroRodadaDataGridViewTextBoxColumn.Name = "numeroRodadaDataGridViewTextBoxColumn";
            this.numeroRodadaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataRodadaDataGridViewTextBoxColumn
            // 
            this.dataRodadaDataGridViewTextBoxColumn.DataPropertyName = "dataRodada";
            this.dataRodadaDataGridViewTextBoxColumn.HeaderText = "dataRodada";
            this.dataRodadaDataGridViewTextBoxColumn.Name = "dataRodadaDataGridViewTextBoxColumn";
            this.dataRodadaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormRodadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grRodada);
            this.Controls.Add(this.grCampeonato);
            this.Name = "FormRodadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRodadas";
            this.Load += new System.EventHandler(this.FormRodadas_Load);
            this.grCampeonato.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCAMPEONATOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMPEONATOBindingSource)).EndInit();
            this.grRodada.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCAMPEONATOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rODADABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grCampeonato;
        private System.Windows.Forms.ComboBox cbCampeonato;
        private DataSetCAMPEONATOS dataSetCAMPEONATOS;
        private System.Windows.Forms.BindingSource cAMPEONATOBindingSource;
        private DataSetCAMPEONATOSTableAdapters.CAMPEONATOTableAdapter cAMPEONATOTableAdapter;
        private System.Windows.Forms.GroupBox grRodada;
        private System.Windows.Forms.ComboBox cbRodada;
        private System.Windows.Forms.BindingSource dataSetCAMPEONATOSBindingSource;
        private System.Windows.Forms.BindingSource rODADABindingSource;
        private DataSetCAMPEONATOSTableAdapters.RODADATableAdapter rODADATableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCampeonatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroRodadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRodadaDataGridViewTextBoxColumn;
    }
}