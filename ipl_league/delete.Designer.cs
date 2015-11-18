namespace ipl_league
{
    partial class delete
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mATCHIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPP1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPP2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vENUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dURATIONHRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATCHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet4 = new ipl_league.DataSet4();
            this.mATCHTableAdapter = new ipl_league.DataSet4TableAdapters.MATCHTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATCHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(143, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(736, 300);
            this.dataGridView1.TabIndex = 2;
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
            this.mATCHBindingSource.DataSource = this.dataSet4;
            // 
            // dataSet4
            // 
            this.dataSet4.DataSetName = "DataSet4";
            this.dataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mATCHTableAdapter
            // 
            this.mATCHTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(673, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Admin";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(774, 440);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "delete";
            this.Text = "delete";
            this.Load += new System.EventHandler(this.delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATCHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet4 dataSet4;
        private System.Windows.Forms.BindingSource mATCHBindingSource;
        private DataSet4TableAdapters.MATCHTableAdapter mATCHTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATCHIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPP1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPP2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vENUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dURATIONHRDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}