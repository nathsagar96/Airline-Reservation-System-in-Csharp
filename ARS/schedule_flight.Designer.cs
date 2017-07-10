namespace ARS
{
    partial class schedule_flight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(schedule_flight));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.economy_seat = new System.Windows.Forms.TextBox();
            this.business_seat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.ComboBox();
            this.back = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.flight_id = new System.Windows.Forms.ComboBox();
            this.flightsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airlineDataSet2 = new ARS.airlineDataSet2();
            this.label2 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flightsTableAdapter = new ARS.airlineDataSet2TableAdapters.flightsTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDataSet2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.economy_seat);
            this.groupBox1.Controls.Add(this.business_seat);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.status);
            this.groupBox1.Controls.Add(this.back);
            this.groupBox1.Controls.Add(this.refresh);
            this.groupBox1.Controls.Add(this.add);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.flight_id);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 434);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Schedule Flight";
            // 
            // economy_seat
            // 
            this.economy_seat.Location = new System.Drawing.Point(154, 252);
            this.economy_seat.Name = "economy_seat";
            this.economy_seat.Size = new System.Drawing.Size(200, 29);
            this.economy_seat.TabIndex = 14;
            // 
            // business_seat
            // 
            this.business_seat.Location = new System.Drawing.Point(154, 199);
            this.business_seat.Name = "business_seat";
            this.business_seat.Size = new System.Drawing.Size(200, 29);
            this.business_seat.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "Economy Seats";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Business Seats";
            // 
            // status
            // 
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Available",
            "Cancelled"});
            this.status.Location = new System.Drawing.Point(154, 151);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(200, 30);
            this.status.TabIndex = 10;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(282, 339);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(106, 62);
            this.back.TabIndex = 9;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(154, 339);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(106, 62);
            this.refresh.TabIndex = 8;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(22, 339);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(106, 62);
            this.add.TabIndex = 7;
            this.add.Text = "Add To Schedule";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status";
            // 
            // flight_id
            // 
            this.flight_id.DataSource = this.flightsBindingSource;
            this.flight_id.DisplayMember = "flight_id";
            this.flight_id.FormattingEnabled = true;
            this.flight_id.Location = new System.Drawing.Point(154, 92);
            this.flight_id.Name = "flight_id";
            this.flight_id.Size = new System.Drawing.Size(200, 30);
            this.flight_id.TabIndex = 3;
            this.flight_id.SelectedIndexChanged += new System.EventHandler(this.flight_id_SelectedIndexChanged);
            // 
            // flightsBindingSource
            // 
            this.flightsBindingSource.DataMember = "flights";
            this.flightsBindingSource.DataSource = this.airlineDataSet2;
            // 
            // airlineDataSet2
            // 
            this.airlineDataSet2.DataSetName = "airlineDataSet2";
            this.airlineDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Flight ID";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(154, 38);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 29);
            this.date.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(449, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 446);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Schedule";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(336, 405);
            this.dataGridView1.TabIndex = 0;
            // 
            // flightsTableAdapter
            // 
            this.flightsTableAdapter.ClearBeforeFill = true;
            // 
            // schedule_flight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(833, 471);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "schedule_flight";
            this.Text = "Schedule Flights";
            this.Load += new System.EventHandler(this.schedule_flight_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDataSet2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox flight_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label1;
        private airlineDataSet2 airlineDataSet2;
        private System.Windows.Forms.BindingSource flightsBindingSource;
        private airlineDataSet2TableAdapters.flightsTableAdapter flightsTableAdapter;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.TextBox economy_seat;
        private System.Windows.Forms.TextBox business_seat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}