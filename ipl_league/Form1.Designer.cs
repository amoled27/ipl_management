namespace ipl_league
{
    partial class match
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
            this.match_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.opp1 = new System.Windows.Forms.TextBox();
            this.opp2 = new System.Windows.Forms.TextBox();
            this.date1 = new System.Windows.Forms.TextBox();
            this.time1 = new System.Windows.Forms.TextBox();
            this.venue = new System.Windows.Forms.TextBox();
            this.hr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // match_id
            // 
            this.match_id.Location = new System.Drawing.Point(112, 32);
            this.match_id.Name = "match_id";
            this.match_id.Size = new System.Drawing.Size(100, 20);
            this.match_id.TabIndex = 0;
            this.match_id.TextChanged += new System.EventHandler(this.match_id_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Match_id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // opp1
            // 
            this.opp1.Location = new System.Drawing.Point(112, 78);
            this.opp1.Name = "opp1";
            this.opp1.Size = new System.Drawing.Size(100, 20);
            this.opp1.TabIndex = 2;
            this.opp1.TextChanged += new System.EventHandler(this.opp1_TextChanged);
            // 
            // opp2
            // 
            this.opp2.Location = new System.Drawing.Point(112, 124);
            this.opp2.Name = "opp2";
            this.opp2.Size = new System.Drawing.Size(100, 20);
            this.opp2.TabIndex = 3;
            // 
            // date1
            // 
            this.date1.Location = new System.Drawing.Point(112, 171);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(100, 20);
            this.date1.TabIndex = 4;
            this.date1.TextChanged += new System.EventHandler(this.date1_TextChanged);
            // 
            // time1
            // 
            this.time1.Location = new System.Drawing.Point(112, 217);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(100, 20);
            this.time1.TabIndex = 5;
            this.time1.TextChanged += new System.EventHandler(this.time1_TextChanged);
            // 
            // venue
            // 
            this.venue.Location = new System.Drawing.Point(112, 258);
            this.venue.Name = "venue";
            this.venue.Size = new System.Drawing.Size(100, 20);
            this.venue.TabIndex = 6;
            this.venue.TextChanged += new System.EventHandler(this.venue_TextChanged);
            // 
            // hr
            // 
            this.hr.Location = new System.Drawing.Point(112, 299);
            this.hr.Name = "hr";
            this.hr.Size = new System.Drawing.Size(100, 20);
            this.hr.TabIndex = 7;
            this.hr.TextChanged += new System.EventHandler(this.hr_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(27, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Opponent1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(27, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Opponent2";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(27, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Match Date";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(27, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Time";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(27, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Venue";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(27, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Duration(in hr)";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addbutton.Location = new System.Drawing.Point(46, 354);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(75, 23);
            this.addbutton.TabIndex = 14;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(147, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Admin";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // match
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(284, 433);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hr);
            this.Controls.Add(this.venue);
            this.Controls.Add(this.time1);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.opp2);
            this.Controls.Add(this.opp1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.match_id);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "match";
            this.Text = "match";
            this.Load += new System.EventHandler(this.match_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox match_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox opp1;
        private System.Windows.Forms.TextBox opp2;
        private System.Windows.Forms.TextBox date1;
        private System.Windows.Forms.TextBox time1;
        private System.Windows.Forms.TextBox venue;
        private System.Windows.Forms.TextBox hr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button button1;
    }
}

