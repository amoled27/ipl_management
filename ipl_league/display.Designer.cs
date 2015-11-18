namespace ipl_league
{
    partial class display
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mATCHIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPP1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPP2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vENUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dURATIONHRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATCHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet5 = new ipl_league.DataSet5();
            this.button2 = new System.Windows.Forms.Button();
            this.mATCHTableAdapter = new ipl_league.DataSet5TableAdapters.MATCHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATCHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mATCHIDDataGridViewTextBoxColumn,
            this.oPP1DataGridViewTextBoxColumn,
            this.oPP2DataGridViewTextBoxColumn,
            this.mDATEDataGridViewTextBoxColumn,
            this.tIMEDataGridViewTextBoxColumn,
            this.vENUEDataGridViewTextBoxColumn,
            this.dURATIONHRDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mATCHBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.Location = new System.Drawing.Point(23, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 241);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // mATCHIDDataGridViewTextBoxColumn
            // 
            this.mATCHIDDataGridViewTextBoxColumn.DataPropertyName = "MATCH_ID";
            this.mATCHIDDataGridViewTextBoxColumn.HeaderText = "MATCH_ID";
            this.mATCHIDDataGridViewTextBoxColumn.Name = "mATCHIDDataGridViewTextBoxColumn";
            // 
            // oPP1DataGridViewTextBoxColumn
            // 
            this.oPP1DataGridViewTextBoxColumn.DataPropertyName = "OPP1";
            this.oPP1DataGridViewTextBoxColumn.HeaderText = "OPP1";
            this.oPP1DataGridViewTextBoxColumn.Name = "oPP1DataGridViewTextBoxColumn";
            // 
            // oPP2DataGridViewTextBoxColumn
            // 
            this.oPP2DataGridViewTextBoxColumn.DataPropertyName = "OPP2";
            this.oPP2DataGridViewTextBoxColumn.HeaderText = "OPP2";
            this.oPP2DataGridViewTextBoxColumn.Name = "oPP2DataGridViewTextBoxColumn";
            // 
            // mDATEDataGridViewTextBoxColumn
            // 
            this.mDATEDataGridViewTextBoxColumn.DataPropertyName = "M_DATE";
            this.mDATEDataGridViewTextBoxColumn.HeaderText = "M_DATE";
            this.mDATEDataGridViewTextBoxColumn.Name = "mDATEDataGridViewTextBoxColumn";
            // 
            // tIMEDataGridViewTextBoxColumn
            // 
            this.tIMEDataGridViewTextBoxColumn.DataPropertyName = "TIME";
            this.tIMEDataGridViewTextBoxColumn.HeaderText = "TIME";
            this.tIMEDataGridViewTextBoxColumn.Name = "tIMEDataGridViewTextBoxColumn";
            // 
            // vENUEDataGridViewTextBoxColumn
            // 
            this.vENUEDataGridViewTextBoxColumn.DataPropertyName = "VENUE";
            this.vENUEDataGridViewTextBoxColumn.HeaderText = "VENUE";
            this.vENUEDataGridViewTextBoxColumn.Name = "vENUEDataGridViewTextBoxColumn";
            // 
            // dURATIONHRDataGridViewTextBoxColumn
            // 
            this.dURATIONHRDataGridViewTextBoxColumn.DataPropertyName = "DURATION_HR";
            this.dURATIONHRDataGridViewTextBoxColumn.HeaderText = "DURATION_HR";
            this.dURATIONHRDataGridViewTextBoxColumn.Name = "dURATIONHRDataGridViewTextBoxColumn";
            // 
            // mATCHBindingSource
            // 
            this.mATCHBindingSource.DataMember = "MATCH";
            this.mATCHBindingSource.DataSource = this.dataSet5;
            // 
            // dataSet5
            // 
            this.dataSet5.DataSetName = "DataSet5";
            this.dataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(23, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Admin";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mATCHTableAdapter
            // 
            this.mATCHTableAdapter.ClearBeforeFill = true;
            // 
            // display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(778, 373);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "display";
            this.Text = "display";
            this.Load += new System.EventHandler(this.display_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATCHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private DataSet5 dataSet5;
        private System.Windows.Forms.BindingSource mATCHBindingSource;
        private DataSet5TableAdapters.MATCHTableAdapter mATCHTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATCHIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPP1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPP2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vENUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dURATIONHRDataGridViewTextBoxColumn;
    }
}