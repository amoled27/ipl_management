namespace ipl_league
{
    partial class update
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mATCHIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPP1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPP2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vENUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dURATIONHRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATCHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new ipl_league.DataSet2();
            this.mATCHTableAdapter = new ipl_league.DataSet2TableAdapters.MATCHTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.match_id = new System.Windows.Forms.TextBox();
            this.opp1 = new System.Windows.Forms.TextBox();
            this.opp2 = new System.Windows.Forms.TextBox();
            this.date1 = new System.Windows.Forms.TextBox();
            this.time1 = new System.Windows.Forms.TextBox();
            this.venue = new System.Windows.Forms.TextBox();
            this.Time = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATCHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Match_id";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(244, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(29, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 150);
            this.dataGridView1.TabIndex = 3;
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
            this.mATCHBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mATCHTableAdapter
            // 
            this.mATCHTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Match_id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Opponent1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Opponent2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(26, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Match date";
            // 
            // match_id
            // 
            this.match_id.Location = new System.Drawing.Point(99, 312);
            this.match_id.Name = "match_id";
            this.match_id.Size = new System.Drawing.Size(116, 20);
            this.match_id.TabIndex = 8;
            this.match_id.TextChanged += new System.EventHandler(this.match_id_TextChanged);
            // 
            // opp1
            // 
            this.opp1.Location = new System.Drawing.Point(99, 357);
            this.opp1.Name = "opp1";
            this.opp1.Size = new System.Drawing.Size(116, 20);
            this.opp1.TabIndex = 9;
            this.opp1.TextChanged += new System.EventHandler(this.opp1_TextChanged);
            // 
            // opp2
            // 
            this.opp2.Location = new System.Drawing.Point(99, 405);
            this.opp2.Name = "opp2";
            this.opp2.Size = new System.Drawing.Size(116, 20);
            this.opp2.TabIndex = 10;
            this.opp2.TextChanged += new System.EventHandler(this.opp2_TextChanged);
            // 
            // date1
            // 
            this.date1.Location = new System.Drawing.Point(99, 450);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(116, 20);
            this.date1.TabIndex = 11;
            this.date1.TextChanged += new System.EventHandler(this.date1_TextChanged);
            // 
            // time1
            // 
            this.time1.Location = new System.Drawing.Point(427, 308);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(116, 20);
            this.time1.TabIndex = 12;
            this.time1.TextChanged += new System.EventHandler(this.time1_TextChanged);
            // 
            // venue
            // 
            this.venue.Location = new System.Drawing.Point(427, 361);
            this.venue.Name = "venue";
            this.venue.Size = new System.Drawing.Size(116, 20);
            this.venue.TabIndex = 13;
            this.venue.TextChanged += new System.EventHandler(this.venue_TextChanged);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.ForeColor = System.Drawing.Color.White;
            this.Time.Location = new System.Drawing.Point(359, 315);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(34, 13);
            this.Time.TabIndex = 14;
            this.Time.Text = "Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(359, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Venue";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(359, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Duration";
            // 
            // duration
            // 
            this.duration.Location = new System.Drawing.Point(427, 405);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(116, 20);
            this.duration.TabIndex = 17;
            this.duration.TextChanged += new System.EventHandler(this.duration_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(456, 450);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(688, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Admin";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(783, 482);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.venue);
            this.Controls.Add(this.time1);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.opp2);
            this.Controls.Add(this.opp1);
            this.Controls.Add(this.match_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Name = "update";
            this.Text = "update";
            this.Load += new System.EventHandler(this.update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATCHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource mATCHBindingSource;
        private DataSet2TableAdapters.MATCHTableAdapter mATCHTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATCHIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPP1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPP2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vENUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dURATIONHRDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox match_id;
        private System.Windows.Forms.TextBox opp1;
        private System.Windows.Forms.TextBox opp2;
        private System.Windows.Forms.TextBox date1;
        private System.Windows.Forms.TextBox time1;
        private System.Windows.Forms.TextBox venue;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox duration;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}