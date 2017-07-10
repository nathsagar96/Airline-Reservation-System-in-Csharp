namespace ARS
{
    partial class book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(book));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flight_id1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.book1 = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.book_ticket = new System.Windows.Forms.Button();
            this.flight_info = new System.Windows.Forms.DataGridView();
            this.search_flight = new System.Windows.Forms.Button();
            this.class1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.no_of_seats = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.destination = new System.Windows.Forms.ComboBox();
            this.airportsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.airlineDataSet5 = new ARS.airlineDataSet5();
            this.source = new System.Windows.Forms.ComboBox();
            this.airportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airlineDataSet4 = new ARS.airlineDataSet4();
            this.airportsTableAdapter = new ARS.airlineDataSet4TableAdapters.airportsTableAdapter();
            this.airportsTableAdapter1 = new ARS.airlineDataSet5TableAdapters.airportsTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flight_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_of_seats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flight_id1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.book1);
            this.groupBox1.Controls.Add(this.back);
            this.groupBox1.Controls.Add(this.book_ticket);
            this.groupBox1.Controls.Add(this.flight_info);
            this.groupBox1.Controls.Add(this.search_flight);
            this.groupBox1.Controls.Add(this.class1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.no_of_seats);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.destination);
            this.groupBox1.Controls.Add(this.source);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(1302, 538);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // flight_id1
            // 
            this.flight_id1.Location = new System.Drawing.Point(997, 37);
            this.flight_id1.Name = "flight_id1";
            this.flight_id1.Size = new System.Drawing.Size(100, 29);
            this.flight_id1.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(892, 41);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 22);
            this.label6.TabIndex = 30;
            this.label6.Text = "Flight Id";
            // 
            // book1
            // 
            this.book1.Location = new System.Drawing.Point(791, 457);
            this.book1.Margin = new System.Windows.Forms.Padding(5);
            this.book1.Name = "book1";
            this.book1.Size = new System.Drawing.Size(152, 44);
            this.book1.TabIndex = 29;
            this.book1.Text = "Book";
            this.book1.UseVisualStyleBackColor = true;
            this.book1.Click += new System.EventHandler(this.book1_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(18, 457);
            this.back.Margin = new System.Windows.Forms.Padding(5);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(152, 44);
            this.back.TabIndex = 28;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // book_ticket
            // 
            this.book_ticket.Location = new System.Drawing.Point(1182, 570);
            this.book_ticket.Margin = new System.Windows.Forms.Padding(5);
            this.book_ticket.Name = "book_ticket";
            this.book_ticket.Size = new System.Drawing.Size(135, 58);
            this.book_ticket.TabIndex = 27;
            this.book_ticket.Text = "Book";
            this.book_ticket.UseVisualStyleBackColor = true;
            // 
            // flight_info
            // 
            this.flight_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flight_info.Location = new System.Drawing.Point(18, 205);
            this.flight_info.Margin = new System.Windows.Forms.Padding(5);
            this.flight_info.Name = "flight_info";
            this.flight_info.Size = new System.Drawing.Size(1205, 242);
            this.flight_info.TabIndex = 26;
            this.flight_info.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.flight_info_CellContentClick);
            // 
            // search_flight
            // 
            this.search_flight.Location = new System.Drawing.Point(622, 140);
            this.search_flight.Margin = new System.Windows.Forms.Padding(5);
            this.search_flight.Name = "search_flight";
            this.search_flight.Size = new System.Drawing.Size(200, 38);
            this.search_flight.TabIndex = 25;
            this.search_flight.Text = "Search Flight";
            this.search_flight.UseVisualStyleBackColor = true;
            this.search_flight.Click += new System.EventHandler(this.search_flight_Click);
            // 
            // class1
            // 
            this.class1.FormattingEnabled = true;
            this.class1.Items.AddRange(new object[] {
            "Business",
            "Economy"});
            this.class1.Location = new System.Drawing.Point(135, 148);
            this.class1.Margin = new System.Windows.Forms.Padding(5);
            this.class1.Name = "class1";
            this.class1.Size = new System.Drawing.Size(199, 30);
            this.class1.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 22);
            this.label5.TabIndex = 23;
            this.label5.Text = "Class";
            // 
            // no_of_seats
            // 
            this.no_of_seats.Location = new System.Drawing.Point(622, 89);
            this.no_of_seats.Margin = new System.Windows.Forms.Padding(5);
            this.no_of_seats.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.no_of_seats.Name = "no_of_seats";
            this.no_of_seats.Size = new System.Drawing.Size(200, 29);
            this.no_of_seats.TabIndex = 22;
            this.no_of_seats.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(498, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "No. of Seats";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(134, 91);
            this.date.Margin = new System.Windows.Forms.Padding(5);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 29);
            this.date.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "TO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "FROM";
            // 
            // destination
            // 
            this.destination.DataSource = this.airportsBindingSource1;
            this.destination.DisplayMember = "city";
            this.destination.FormattingEnabled = true;
            this.destination.Location = new System.Drawing.Point(622, 37);
            this.destination.Margin = new System.Windows.Forms.Padding(5);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(199, 30);
            this.destination.TabIndex = 16;
            // 
            // airportsBindingSource1
            // 
            this.airportsBindingSource1.DataMember = "airports";
            this.airportsBindingSource1.DataSource = this.airlineDataSet5;
            // 
            // airlineDataSet5
            // 
            this.airlineDataSet5.DataSetName = "airlineDataSet5";
            this.airlineDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // source
            // 
            this.source.DataSource = this.airportsBindingSource;
            this.source.DisplayMember = "city";
            this.source.FormattingEnabled = true;
            this.source.Location = new System.Drawing.Point(134, 37);
            this.source.Margin = new System.Windows.Forms.Padding(5);
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(199, 30);
            this.source.TabIndex = 15;
            // 
            // airportsBindingSource
            // 
            this.airportsBindingSource.DataMember = "airports";
            this.airportsBindingSource.DataSource = this.airlineDataSet4;
            // 
            // airlineDataSet4
            // 
            this.airlineDataSet4.DataSetName = "airlineDataSet4";
            this.airlineDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // airportsTableAdapter
            // 
            this.airportsTableAdapter.ClearBeforeFill = true;
            // 
            // airportsTableAdapter1
            // 
            this.airportsTableAdapter1.ClearBeforeFill = true;
            // 
            // book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1354, 566);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "book";
            this.Text = "Book";
            this.Load += new System.EventHandler(this.book_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flight_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_of_seats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button book_ticket;
        private System.Windows.Forms.DataGridView flight_info;
        private System.Windows.Forms.Button search_flight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox destination;
        private System.Windows.Forms.ComboBox source;
        private System.Windows.Forms.Button book1;
        private airlineDataSet4 airlineDataSet4;
        private System.Windows.Forms.BindingSource airportsBindingSource;
        private airlineDataSet4TableAdapters.airportsTableAdapter airportsTableAdapter;
        private airlineDataSet5 airlineDataSet5;
        private System.Windows.Forms.BindingSource airportsBindingSource1;
        private airlineDataSet5TableAdapters.airportsTableAdapter airportsTableAdapter1;
        public System.Windows.Forms.TextBox flight_id1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox class1;
        public System.Windows.Forms.NumericUpDown no_of_seats;
        public System.Windows.Forms.DateTimePicker date;
    }
}