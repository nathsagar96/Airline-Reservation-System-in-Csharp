namespace ARS
{
    partial class add_flight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_flight));
            this.flightinfo = new System.Windows.Forms.GroupBox();
            this.airline = new System.Windows.Forms.ComboBox();
            this.destination = new System.Windows.Forms.ComboBox();
            this.airportsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.airlineDataSet1 = new ARS.airlineDataSet1();
            this.source = new System.Windows.Forms.ComboBox();
            this.airportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airlineDataSet = new ARS.airlineDataSet();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flightid = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.airportsTableAdapter = new ARS.airlineDataSetTableAdapters.airportsTableAdapter();
            this.airportsTableAdapter1 = new ARS.airlineDataSet1TableAdapters.airportsTableAdapter();
            this.flightinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDataSet)).BeginInit();
            this.fareandseat.SuspendLayout();
            this.SuspendLayout();
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
            this.flightinfo.Controls.Add(this.label1);
            this.flightinfo.Controls.Add(this.label6);
            this.flightinfo.Controls.Add(this.label5);
            this.flightinfo.Controls.Add(this.label4);
            this.flightinfo.Controls.Add(this.label3);
            this.flightinfo.Controls.Add(this.label2);
            this.flightinfo.Controls.Add(this.flightid);
            this.flightinfo.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightinfo.Location = new System.Drawing.Point(12, 26);
            this.flightinfo.Name = "flightinfo";
            this.flightinfo.Size = new System.Drawing.Size(748, 350);
            this.flightinfo.TabIndex = 0;
            this.flightinfo.TabStop = false;
            this.flightinfo.Text = "Insert Flight Information";
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
            this.airline.Location = new System.Drawing.Point(114, 171);
            this.airline.Name = "airline";
            this.airline.Size = new System.Drawing.Size(233, 30);
            this.airline.TabIndex = 18;
            // 
            // destination
            // 
            this.destination.DataSource = this.airportsBindingSource1;
            this.destination.DisplayMember = "city";
            this.destination.FormattingEnabled = true;
            this.destination.Location = new System.Drawing.Point(114, 128);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(233, 30);
            this.destination.TabIndex = 17;
            // 
            // airportsBindingSource1
            // 
            this.airportsBindingSource1.DataMember = "airports";
            this.airportsBindingSource1.DataSource = this.airlineDataSet1;
            // 
            // airlineDataSet1
            // 
            this.airlineDataSet1.DataSetName = "airlineDataSet1";
            this.airlineDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // source
            // 
            this.source.DataSource = this.airportsBindingSource;
            this.source.DisplayMember = "city";
            this.source.FormattingEnabled = true;
            this.source.Location = new System.Drawing.Point(114, 83);
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(233, 30);
            this.source.TabIndex = 16;
            // 
            // airportsBindingSource
            // 
            this.airportsBindingSource.DataMember = "airports";
            this.airportsBindingSource.DataSource = this.airlineDataSet;
            // 
            // airlineDataSet
            // 
            this.airlineDataSet.DataSetName = "airlineDataSet";
            this.airlineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.fareandseat.Location = new System.Drawing.Point(453, 28);
            this.fareandseat.Name = "fareandseat";
            this.fareandseat.Size = new System.Drawing.Size(286, 316);
            this.fareandseat.TabIndex = 15;
            this.fareandseat.TabStop = false;
            this.fareandseat.Text = "Fare And Seating";
            // 
            // economy_fare
            // 
            this.economy_fare.Location = new System.Drawing.Point(86, 172);
            this.economy_fare.Name = "economy_fare";
            this.economy_fare.Size = new System.Drawing.Size(142, 29);
            this.economy_fare.TabIndex = 7;
            // 
            // business_fare
            // 
            this.business_fare.Location = new System.Drawing.Point(85, 72);
            this.business_fare.Name = "business_fare";
            this.business_fare.Size = new System.Drawing.Size(143, 29);
            this.business_fare.TabIndex = 6;
            // 
            // economy_seat
            // 
            this.economy_seat.Location = new System.Drawing.Point(86, 129);
            this.economy_seat.Name = "economy_seat";
            this.economy_seat.Size = new System.Drawing.Size(142, 29);
            this.economy_seat.TabIndex = 5;
            // 
            // business_seat
            // 
            this.business_seat.Location = new System.Drawing.Point(86, 31);
            this.business_seat.Name = "business_seat";
            this.business_seat.Size = new System.Drawing.Size(142, 29);
            this.business_seat.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 22);
            this.label10.TabIndex = 3;
            this.label10.Text = "Fare";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 22);
            this.label9.TabIndex = 2;
            this.label9.Text = "Fare";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 132);
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
            this.duration.Location = new System.Drawing.Point(114, 303);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(233, 29);
            this.duration.TabIndex = 14;
            // 
            // arrival
            // 
            this.arrival.Location = new System.Drawing.Point(114, 260);
            this.arrival.Name = "arrival";
            this.arrival.Size = new System.Drawing.Size(233, 29);
            this.arrival.TabIndex = 13;
            // 
            // departure
            // 
            this.departure.Location = new System.Drawing.Point(114, 212);
            this.departure.Name = "departure";
            this.departure.Size = new System.Drawing.Size(233, 29);
            this.departure.TabIndex = 12;
            // 
            // flight_id
            // 
            this.flight_id.Location = new System.Drawing.Point(114, 47);
            this.flight_id.Name = "flight_id";
            this.flight_id.Size = new System.Drawing.Size(233, 29);
            this.flight_id.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Duration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Arrival";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Departure";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 171);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "From";
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
            // back
            // 
            this.back.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(371, 382);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(116, 33);
            this.back.TabIndex = 1;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(196, 380);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(119, 36);
            this.add.TabIndex = 2;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // airportsTableAdapter
            // 
            this.airportsTableAdapter.ClearBeforeFill = true;
            // 
            // airportsTableAdapter1
            // 
            this.airportsTableAdapter1.ClearBeforeFill = true;
            // 
            // add_flight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(775, 423);
            this.Controls.Add(this.add);
            this.Controls.Add(this.back);
            this.Controls.Add(this.flightinfo);
            this.Name = "add_flight";
            this.Text = "Add New Flight Info";
            this.Load += new System.EventHandler(this.add_flight_Load);
            this.flightinfo.ResumeLayout(false);
            this.flightinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDataSet)).EndInit();
            this.fareandseat.ResumeLayout(false);
            this.fareandseat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox flightinfo;
        private System.Windows.Forms.GroupBox fareandseat;
        private System.Windows.Forms.TextBox economy_fare;
        private System.Windows.Forms.TextBox business_fare;
        private System.Windows.Forms.TextBox economy_seat;
        private System.Windows.Forms.TextBox business_seat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox duration;
        private System.Windows.Forms.TextBox arrival;
        private System.Windows.Forms.TextBox departure;
        private System.Windows.Forms.TextBox flight_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label flightid;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ComboBox airline;
        private System.Windows.Forms.ComboBox destination;
        private System.Windows.Forms.ComboBox source;
        private airlineDataSet airlineDataSet;
        private System.Windows.Forms.BindingSource airportsBindingSource;
        private airlineDataSetTableAdapters.airportsTableAdapter airportsTableAdapter;
        private airlineDataSet1 airlineDataSet1;
        private System.Windows.Forms.BindingSource airportsBindingSource1;
        private airlineDataSet1TableAdapters.airportsTableAdapter airportsTableAdapter1;
    }
}