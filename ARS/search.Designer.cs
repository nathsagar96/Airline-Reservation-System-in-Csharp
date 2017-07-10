namespace ARS
{
    partial class search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(search));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.search1 = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.destination = new System.Windows.Forms.ComboBox();
            this.airportsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.airlineDataSet3 = new ARS.airlineDataSet3();
            this.source = new System.Windows.Forms.ComboBox();
            this.airportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airlineDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airlineDataSet = new ARS.airlineDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.airportsTableAdapter = new ARS.airlineDataSetTableAdapters.airportsTableAdapter();
            this.airportsTableAdapter1 = new ARS.airlineDataSet3TableAdapters.airportsTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.search1);
            this.groupBox1.Controls.Add(this.back);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.destination);
            this.groupBox1.Controls.Add(this.source);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1017, 479);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Flight";
            // 
            // search1
            // 
            this.search1.Location = new System.Drawing.Point(892, 31);
            this.search1.Name = "search1";
            this.search1.Size = new System.Drawing.Size(75, 30);
            this.search1.TabIndex = 4;
            this.search1.Text = "Search";
            this.search1.UseVisualStyleBackColor = true;
            this.search1.Click += new System.EventHandler(this.search1_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(410, 422);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(125, 30);
            this.back.TabIndex = 26;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(980, 302);
            this.dataGridView1.TabIndex = 25;
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(660, 33);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 29);
            this.date.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(610, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "Date";
            // 
            // destination
            // 
            this.destination.DataSource = this.airportsBindingSource1;
            this.destination.DisplayMember = "city";
            this.destination.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destination.FormattingEnabled = true;
            this.destination.Location = new System.Drawing.Point(357, 32);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(229, 30);
            this.destination.TabIndex = 22;
            // 
            // airportsBindingSource1
            // 
            this.airportsBindingSource1.DataMember = "airports";
            this.airportsBindingSource1.DataSource = this.airlineDataSet3;
            // 
            // airlineDataSet3
            // 
            this.airlineDataSet3.DataSetName = "airlineDataSet3";
            this.airlineDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // source
            // 
            this.source.DataSource = this.airportsBindingSource;
            this.source.DisplayMember = "city";
            this.source.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.source.FormattingEnabled = true;
            this.source.Location = new System.Drawing.Point(71, 31);
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(229, 30);
            this.source.TabIndex = 21;
            // 
            // airportsBindingSource
            // 
            this.airportsBindingSource.DataMember = "airports";
            this.airportsBindingSource.DataSource = this.airlineDataSetBindingSource;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(323, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "To";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 22);
            this.label11.TabIndex = 19;
            this.label11.Text = "From";
            // 
            // airportsTableAdapter
            // 
            this.airportsTableAdapter.ClearBeforeFill = true;
            // 
            // airportsTableAdapter1
            // 
            this.airportsTableAdapter1.ClearBeforeFill = true;
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1042, 504);
            this.Controls.Add(this.groupBox1);
            this.Name = "search";
            this.Text = "Search Flights";
            this.Load += new System.EventHandler(this.search_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox destination;
        private System.Windows.Forms.ComboBox source;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.BindingSource airlineDataSetBindingSource;
        private airlineDataSet airlineDataSet;
        private System.Windows.Forms.BindingSource airportsBindingSource;
        private airlineDataSetTableAdapters.airportsTableAdapter airportsTableAdapter;
        private airlineDataSet3 airlineDataSet3;
        private System.Windows.Forms.BindingSource airportsBindingSource1;
        private airlineDataSet3TableAdapters.airportsTableAdapter airportsTableAdapter1;
        private System.Windows.Forms.Button search1;
    }
}