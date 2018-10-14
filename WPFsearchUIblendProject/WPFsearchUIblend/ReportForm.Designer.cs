namespace WPFsearchUIblend
{
    partial class ReportForm
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
            this.loadButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fornavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mellomnavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etternavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postnummer1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postnummer2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postnummer3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postnummer4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postnummer5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poststed1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poststed2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poststed3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poststed4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poststed5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(1126, 535);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(125, 23);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Last inn alle data";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fornavnDataGridViewTextBoxColumn,
            this.mellomnavnDataGridViewTextBoxColumn,
            this.etternavnDataGridViewTextBoxColumn,
            this.adresse1DataGridViewTextBoxColumn,
            this.adresse2DataGridViewTextBoxColumn,
            this.adresse3DataGridViewTextBoxColumn,
            this.adresse4DataGridViewTextBoxColumn,
            this.adresse5DataGridViewTextBoxColumn,
            this.postnummer1DataGridViewTextBoxColumn,
            this.postnummer2DataGridViewTextBoxColumn,
            this.postnummer3DataGridViewTextBoxColumn,
            this.postnummer4DataGridViewTextBoxColumn,
            this.postnummer5DataGridViewTextBoxColumn,
            this.poststed1DataGridViewTextBoxColumn,
            this.poststed2DataGridViewTextBoxColumn,
            this.poststed3DataGridViewTextBoxColumn,
            this.poststed4DataGridViewTextBoxColumn,
            this.poststed5DataGridViewTextBoxColumn,
            this.email1DataGridViewTextBoxColumn,
            this.email2DataGridViewTextBoxColumn,
            this.email3DataGridViewTextBoxColumn,
            this.email4DataGridViewTextBoxColumn,
            this.email5DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1239, 517);
            this.dataGridView1.TabIndex = 2;
            // 
            // fornavnDataGridViewTextBoxColumn
            // 
            this.fornavnDataGridViewTextBoxColumn.DataPropertyName = "Fornavn";
            this.fornavnDataGridViewTextBoxColumn.HeaderText = "Fornavn";
            this.fornavnDataGridViewTextBoxColumn.Name = "fornavnDataGridViewTextBoxColumn";
            // 
            // mellomnavnDataGridViewTextBoxColumn
            // 
            this.mellomnavnDataGridViewTextBoxColumn.DataPropertyName = "Mellomnavn";
            this.mellomnavnDataGridViewTextBoxColumn.HeaderText = "Mellomnavn";
            this.mellomnavnDataGridViewTextBoxColumn.Name = "mellomnavnDataGridViewTextBoxColumn";
            // 
            // etternavnDataGridViewTextBoxColumn
            // 
            this.etternavnDataGridViewTextBoxColumn.DataPropertyName = "Etternavn";
            this.etternavnDataGridViewTextBoxColumn.HeaderText = "Etternavn";
            this.etternavnDataGridViewTextBoxColumn.Name = "etternavnDataGridViewTextBoxColumn";
            // 
            // adresse1DataGridViewTextBoxColumn
            // 
            this.adresse1DataGridViewTextBoxColumn.DataPropertyName = "Adresse1";
            this.adresse1DataGridViewTextBoxColumn.HeaderText = "Adresse1";
            this.adresse1DataGridViewTextBoxColumn.Name = "adresse1DataGridViewTextBoxColumn";
            // 
            // adresse2DataGridViewTextBoxColumn
            // 
            this.adresse2DataGridViewTextBoxColumn.DataPropertyName = "Adresse2";
            this.adresse2DataGridViewTextBoxColumn.HeaderText = "Adresse2";
            this.adresse2DataGridViewTextBoxColumn.Name = "adresse2DataGridViewTextBoxColumn";
            // 
            // adresse3DataGridViewTextBoxColumn
            // 
            this.adresse3DataGridViewTextBoxColumn.DataPropertyName = "Adresse3";
            this.adresse3DataGridViewTextBoxColumn.HeaderText = "Adresse3";
            this.adresse3DataGridViewTextBoxColumn.Name = "adresse3DataGridViewTextBoxColumn";
            // 
            // adresse4DataGridViewTextBoxColumn
            // 
            this.adresse4DataGridViewTextBoxColumn.DataPropertyName = "Adresse4";
            this.adresse4DataGridViewTextBoxColumn.HeaderText = "Adresse4";
            this.adresse4DataGridViewTextBoxColumn.Name = "adresse4DataGridViewTextBoxColumn";
            // 
            // adresse5DataGridViewTextBoxColumn
            // 
            this.adresse5DataGridViewTextBoxColumn.DataPropertyName = "Adresse5";
            this.adresse5DataGridViewTextBoxColumn.HeaderText = "Adresse5";
            this.adresse5DataGridViewTextBoxColumn.Name = "adresse5DataGridViewTextBoxColumn";
            // 
            // postnummer1DataGridViewTextBoxColumn
            // 
            this.postnummer1DataGridViewTextBoxColumn.DataPropertyName = "Postnummer1";
            this.postnummer1DataGridViewTextBoxColumn.HeaderText = "Postnummer1";
            this.postnummer1DataGridViewTextBoxColumn.Name = "postnummer1DataGridViewTextBoxColumn";
            // 
            // postnummer2DataGridViewTextBoxColumn
            // 
            this.postnummer2DataGridViewTextBoxColumn.DataPropertyName = "Postnummer2";
            this.postnummer2DataGridViewTextBoxColumn.HeaderText = "Postnummer2";
            this.postnummer2DataGridViewTextBoxColumn.Name = "postnummer2DataGridViewTextBoxColumn";
            // 
            // postnummer3DataGridViewTextBoxColumn
            // 
            this.postnummer3DataGridViewTextBoxColumn.DataPropertyName = "Postnummer3";
            this.postnummer3DataGridViewTextBoxColumn.HeaderText = "Postnummer3";
            this.postnummer3DataGridViewTextBoxColumn.Name = "postnummer3DataGridViewTextBoxColumn";
            // 
            // postnummer4DataGridViewTextBoxColumn
            // 
            this.postnummer4DataGridViewTextBoxColumn.DataPropertyName = "Postnummer4";
            this.postnummer4DataGridViewTextBoxColumn.HeaderText = "Postnummer4";
            this.postnummer4DataGridViewTextBoxColumn.Name = "postnummer4DataGridViewTextBoxColumn";
            // 
            // postnummer5DataGridViewTextBoxColumn
            // 
            this.postnummer5DataGridViewTextBoxColumn.DataPropertyName = "Postnummer5";
            this.postnummer5DataGridViewTextBoxColumn.HeaderText = "Postnummer5";
            this.postnummer5DataGridViewTextBoxColumn.Name = "postnummer5DataGridViewTextBoxColumn";
            // 
            // poststed1DataGridViewTextBoxColumn
            // 
            this.poststed1DataGridViewTextBoxColumn.DataPropertyName = "Poststed1";
            this.poststed1DataGridViewTextBoxColumn.HeaderText = "Poststed1";
            this.poststed1DataGridViewTextBoxColumn.Name = "poststed1DataGridViewTextBoxColumn";
            // 
            // poststed2DataGridViewTextBoxColumn
            // 
            this.poststed2DataGridViewTextBoxColumn.DataPropertyName = "Poststed2";
            this.poststed2DataGridViewTextBoxColumn.HeaderText = "Poststed2";
            this.poststed2DataGridViewTextBoxColumn.Name = "poststed2DataGridViewTextBoxColumn";
            // 
            // poststed3DataGridViewTextBoxColumn
            // 
            this.poststed3DataGridViewTextBoxColumn.DataPropertyName = "Poststed3";
            this.poststed3DataGridViewTextBoxColumn.HeaderText = "Poststed3";
            this.poststed3DataGridViewTextBoxColumn.Name = "poststed3DataGridViewTextBoxColumn";
            // 
            // poststed4DataGridViewTextBoxColumn
            // 
            this.poststed4DataGridViewTextBoxColumn.DataPropertyName = "Poststed4";
            this.poststed4DataGridViewTextBoxColumn.HeaderText = "Poststed4";
            this.poststed4DataGridViewTextBoxColumn.Name = "poststed4DataGridViewTextBoxColumn";
            // 
            // poststed5DataGridViewTextBoxColumn
            // 
            this.poststed5DataGridViewTextBoxColumn.DataPropertyName = "Poststed5";
            this.poststed5DataGridViewTextBoxColumn.HeaderText = "Poststed5";
            this.poststed5DataGridViewTextBoxColumn.Name = "poststed5DataGridViewTextBoxColumn";
            // 
            // email1DataGridViewTextBoxColumn
            // 
            this.email1DataGridViewTextBoxColumn.DataPropertyName = "Email1";
            this.email1DataGridViewTextBoxColumn.HeaderText = "Email1";
            this.email1DataGridViewTextBoxColumn.Name = "email1DataGridViewTextBoxColumn";
            // 
            // email2DataGridViewTextBoxColumn
            // 
            this.email2DataGridViewTextBoxColumn.DataPropertyName = "Email2";
            this.email2DataGridViewTextBoxColumn.HeaderText = "Email2";
            this.email2DataGridViewTextBoxColumn.Name = "email2DataGridViewTextBoxColumn";
            // 
            // email3DataGridViewTextBoxColumn
            // 
            this.email3DataGridViewTextBoxColumn.DataPropertyName = "Email3";
            this.email3DataGridViewTextBoxColumn.HeaderText = "Email3";
            this.email3DataGridViewTextBoxColumn.Name = "email3DataGridViewTextBoxColumn";
            // 
            // email4DataGridViewTextBoxColumn
            // 
            this.email4DataGridViewTextBoxColumn.DataPropertyName = "Email4";
            this.email4DataGridViewTextBoxColumn.HeaderText = "Email4";
            this.email4DataGridViewTextBoxColumn.Name = "email4DataGridViewTextBoxColumn";
            // 
            // email5DataGridViewTextBoxColumn
            // 
            this.email5DataGridViewTextBoxColumn.DataPropertyName = "Email5";
            this.email5DataGridViewTextBoxColumn.HeaderText = "Email5";
            this.email5DataGridViewTextBoxColumn.Name = "email5DataGridViewTextBoxColumn";
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(WPFsearchUIblend.Person);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 570);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.loadButton);
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print rapport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mellomnavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etternavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postnummer1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postnummer2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postnummer3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postnummer4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postnummer5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poststed1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poststed2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poststed3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poststed4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poststed5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn email1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn email2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn email3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn email4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn email5DataGridViewTextBoxColumn;
    }
}