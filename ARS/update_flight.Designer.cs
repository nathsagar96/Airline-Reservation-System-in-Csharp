﻿namespace ARS
{
    partial class update_flight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(update_flight));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reset = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.search_flight_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flightinfo = new System.Windows.Forms.GroupBox();
            this.airline = new System.Windows.Forms.ComboBox();
            this.destination = new System.Windows.Forms.ComboBox();
            this.airportsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.airlineDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airlineDataSet = new ARS.airlineDataSet();
            this.source = new System.Windows.Forms.ComboBox();
            this.airportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fareandseat = new System.Windows.Forms.GroupBox();
            this.economy_fare = new System.Windows.Forms.TextBox();
            this.business_fare = new System.Windows.Forms.TextBox();
            this.economy_seat = new System.Windows.Forms.TextBox();
            this.business_seat = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.TextBox();
            this.arrival = new System.Windows.Forms.TextBox();
            this.departure = new System.Windows.Forms.TextBox();
            this.flight_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.flightid = new System.Windows.Forms.Label();
            this.airlineDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airlineDataSet1 = new ARS.airlineDataSet1();
            this.update = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.airportsTableAdapter = new ARS.airlineDataSetTableAdapters.airportsTableAdapter();
            this.airportsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.airportsTableAdapter1 = new ARS.airlineDataSet1TableAdapters.airportsTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flightinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource)).BeginInit();
            this.fareandseat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reset);
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.search_flight_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(983, 265);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Flight";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(449, 39);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 29);
            this.reset.TabIndex = 4;
            this.reset.Text = "Refresh";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(329, 38);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 30);
            this.search.TabIndex = 3;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(945, 162);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // search_flight_id
            // 
            this.search_flight_id.Location = new System.Drawing.Point(159, 39);
            this.search_flight_id.Name = "search_flight_id";
            this.search_flight_id.Size = new System.Drawing.Size(133, 29);
            this.search_flight_id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Flight Id";
            // 
            // flightinfo
            // 
            this.flightinfo.Controls.Add(this.airline);
            this.flightinfo.Controls.Add(this.destination);
            this.flightinfo.Controls.Add(this.source);
            this.flightinfo.Controls.Add(this.fareandseat);
            this.flightinfo.Controls.Add(this.duration);
            this.flightinfo.Controls.Add(this.arrival);
            this.flightinfo.Controls.Add(this.departure);
            this.flightinfo.Controls.Add(this.flight_id);
            this.flightinfo.Controls.Add(this.label2);
            this.flightinfo.Controls.Add(this.label6);
            this.flightinfo.Controls.Add(this.label5);
            this.flightinfo.Controls.Add(this.label4);
            this.flightinfo.Controls.Add(this.label3);
            this.flightinfo.Controls.Add(this.label11);
            this.flightinfo.Controls.Add(this.flightid);
            this.flightinfo.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightinfo.Location = new System.Drawing.Point(12, 280);
            this.flightinfo.Name = "flightinfo";
            this.flightinfo.Size = new System.Drawing.Size(983, 247);
            this.flightinfo.TabIndex = 3;
            this.flightinfo.TabStop = false;
            this.flightinfo.Text = " Flight Information";
            // 
            // airline
            // 
            this.airline.FormattingEnabled = true;
            this.airline.Items.AddRange(new object[] {
            "AirAsia India",
            "Air Carnival",
            "Air India",
            "Air India Express",
            "Air Odisha",
            "Chhattisgarh Air Link",
            "Club One Air",
            "FlyEasy",
            "GoAir",
            "IndiGo",
            "Jet Airways",
            "SpiceJet",
            "TajAir",
            "TruJet",
            "Vistara"});
            this.airline.Location = new System.Drawing.Point(461, 44);
            this.airline.Name = "airline";
            this.airline.Size = new System.Drawing.Size(229, 30);
            this.airline.TabIndex = 19;
            // 
            // destination
            // 
            this.destination.DataSource = this.airportsBindingSource2;
            this.destination.DisplayMember = "city";
            this.destination.FormattingEnabled = true;
            this.destination.Location = new System.Drawing.Point(114, 128);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(229, 30);
            this.destination.TabIndex = 18;
            // 
            // airportsBindingSource2
            // 
            this.airportsBindingSource2.DataMember = "airports";
            this.airportsBindingSource2.DataSource = this.airlineDataSetBindingSource;
            // 
            // airlineDataSetBindingSource
            // 
            this.airlineDataSetBindingSource.DataSource = this.airlineDataSet;
            this.airlineDataSetBindingSource.Position = 0;
            // 
            // airlineDataSet
            // 
            this.airlineDataSet.DataSetName = "airlineDataSet";
            this.airlineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // source
            // 
            this.source.DataSource = this.airportsBindingSource;
            this.source.DisplayMember = "city";
            this.source.FormattingEnabled = true;
            this.source.Location = new System.Drawing.Point(114, 87);
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(229, 30);
            this.source.TabIndex = 17;
            // 
            // airportsBindingSource
            // 
            this.airportsBindingSource.DataMember = "airports";
            this.airportsBindingSource.DataSource = this.airlineDataSet;
            // 
            // fareandseat
            // 
            this.fareandseat.Controls.Add(this.economy_fare);
            this.fareandseat.Controls.Add(this.business_fare);
            this.fareandseat.Controls.Add(this.economy_seat);
            this.fareandseat.Controls.Add(this.business_seat);
            this.fareandseat.Controls.Add(this.label10);
            this.fareandseat.Controls.Add(this.label9);
            this.fareandseat.Controls.Add(this.label8);
            this.fareandseat.Controls.Add(this.label7);
            this.fareandseat.Location = new System.Drawing.Point(730, 28);
            this.fareandseat.Name = "fareandseat";
            this.fareandseat.Size = new System.Drawing.Size(236, 211);
            this.fareandseat.TabIndex = 15;
            this.fareandseat.TabStop = false;
            this.fareandseat.Text = "Fare And Seating";
            // 
            // economy_fare
            // 
            this.economy_fare.Location = new System.Drawing.Point(85, 168);
            this.economy_fare.Name = "economy_fare";
            this.economy_fare.Size = new System.Drawing.Size(129, 29);
            this.economy_fare.TabIndex = 7;
            // 
            // business_fare
            // 
            this.business_fare.Location = new System.Drawing.Point(85, 75);
            this.business_fare.Name = "business_fare";
            this.business_fare.Size = new System.Drawing.Size(129, 29);
            this.business_fare.TabIndex = 6;
            // 
            // economy_seat
            // 
            this.economy_seat.Location = new System.Drawing.Point(85, 120);
            this.economy_seat.Name = "economy_seat";
            this.economy_seat.Size = new System.Drawing.Size(129, 29);
            this.economy_seat.TabIndex = 5;
            // 
            // business_seat
            // 
            this.business_seat.Location = new System.Drawing.Point(85, 28);
            this.business_seat.Name = "business_seat";
            this.business_seat.Size = new System.Drawing.Size(129, 29);
            this.business_seat.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 22);
            this.label10.TabIndex = 3;
            this.label10.Text = "Fare";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 22);
            this.label9.TabIndex = 2;
            this.label9.Text = "Fare";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 22);
            this.label8.TabIndex = 1;
            this.label8.Text = "Economy";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Business";
            // 
            // duration
            // 
            this.duration.Location = new System.Drawing.Point(114, 176);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(229, 29);
            this.duration.TabIndex = 14;
            // 
            // arrival
            // 
            this.arrival.Location = new System.Drawing.Point(461, 152);
            this.arrival.Name = "arrival";
            this.arrival.Size = new System.Drawing.Size(229, 29);
            this.arrival.TabIndex = 13;
            // 
            // departure
            // 
            this.departure.Location = new System.Drawing.Point(461, 99);
            this.departure.Name = "departure";
            this.departure.Size = new System.Drawing.Size(229, 29);
            this.departure.TabIndex = 12;
            // 
            // flight_id
            // 
            this.flight_id.Location = new System.Drawing.Point(114, 47);
            this.flight_id.Name = "flight_id";
            this.flight_id.ReadOnly = true;
            this.flight_id.Size = new System.Drawing.Size(229, 29);
            this.flight_id.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Duration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Arrival";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Departure";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Airline";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "To";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 22);
            this.label11.TabIndex = 1;
            this.label11.Text = "From";
            // 
            // flightid
            // 
            this.flightid.AutoSize = true;
            this.flightid.Location = new System.Drawing.Point(7, 47);
            this.flightid.Name = "flightid";
            this.flightid.Size = new System.Drawing.Size(72, 22);
            this.flightid.TabIndex = 0;
            this.flightid.Text = "Flight Id";
            // 
            // airlineDataSet1BindingSource
            // 
            this.airlineDataSet1BindingSource.DataSource = this.airlineDataSet1;
            this.airlineDataSet1BindingSource.Position = 0;
            // 
            // airlineDataSet1
            // 
            this.airlineDataSet1.DataSetName = "airlineDataSet1";
            this.airlineDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(325, 543);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(102, 30);
            this.update.TabIndex = 4;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(509, 543);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(125, 30);
            this.back.TabIndex = 5;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // airportsTableAdapter
            // 
            this.airportsTableAdapter.ClearBeforeFill = true;
            // 
            // airportsBindingSource1
            // 
            this.airportsBindingSource1.DataMember = "airports";
            this.airportsBindingSource1.DataSource = this.airlineDataSet1BindingSource;
            // 
            // airportsTableAdapter1
            // 
            this.airportsTableAdapter1.ClearBeforeFill = true;
            // 
            // update_flight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1007, 589);
            this.Controls.Add(this.back);
            this.Controls.Add(this.update);
            this.Controls.Add(this.flightinfo);
            this.Controls.Add(this.groupBox1);
            this.Name = "update_flight";
            this.Text = "Update Flight Information";
            this.Load += new System.EventHandler(this.update_flight_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flightinfo.ResumeLayout(false);
            this.flightinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource)).EndInit();
            this.fareandseat.ResumeLayout(false);
            this.fareandseat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox search_flight_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox flightinfo;
        private System.Windows.Forms.TextBox duration;
        private System.Windows.Forms.TextBox arrival;
        private System.Windows.Forms.TextBox departure;
        private System.Windows.Forms.TextBox flight_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label flightid;
        private System.Windows.Forms.GroupBox fareandseat;
        private System.Windows.Forms.TextBox economy_fare;
        private System.Windows.Forms.TextBox business_fare;
        private System.Windows.Forms.TextBox economy_seat;
        private System.Windows.Forms.TextBox business_seat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ComboBox source;
        private System.Windows.Forms.ComboBox destination;
        private System.Windows.Forms.ComboBox airline;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.BindingSource airlineDataSetBindingSource;
        private airlineDataSet airlineDataSet;
        private System.Windows.Forms.BindingSource airportsBindingSource;
        private airlineDataSetTableAdapters.airportsTableAdapter airportsTableAdapter;
        private System.Windows.Forms.BindingSource airlineDataSet1BindingSource;
        private airlineDataSet1 airlineDataSet1;
        private System.Windows.Forms.BindingSource airportsBindingSource1;
        private airlineDataSet1TableAdapters.airportsTableAdapter airportsTableAdapter1;
        private System.Windows.Forms.BindingSource airportsBindingSource2;
    }
}