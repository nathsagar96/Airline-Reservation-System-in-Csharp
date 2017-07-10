namespace ARS
{
    partial class view_flight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(view_flight));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reset = new System.Windows.Forms.Button();
            this.last = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.previous = new System.Windows.Forms.Button();
            this.first = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.search_flight_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reset);
            this.groupBox1.Controls.Add(this.last);
            this.groupBox1.Controls.Add(this.next);
            this.groupBox1.Controls.Add(this.previous);
            this.groupBox1.Controls.Add(this.first);
            this.groupBox1.Controls.Add(this.back);
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.search_flight_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1030, 496);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(784, 39);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(98, 30);
            this.reset.TabIndex = 9;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // last
            // 
            this.last.Location = new System.Drawing.Point(903, 433);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(121, 33);
            this.last.TabIndex = 8;
            this.last.Text = "Last";
            this.last.UseVisualStyleBackColor = true;
            this.last.Click += new System.EventHandler(this.last_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(590, 433);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(105, 33);
            this.next.TabIndex = 7;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // previous
            // 
            this.previous.Location = new System.Drawing.Point(352, 433);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(110, 33);
            this.previous.TabIndex = 6;
            this.previous.Text = "Previous";
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // first
            // 
            this.first.Location = new System.Drawing.Point(21, 433);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(112, 33);
            this.first.TabIndex = 5;
            this.first.Text = "First";
            this.first.UseVisualStyleBackColor = true;
            this.first.Click += new System.EventHandler(this.first_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(903, 38);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(87, 34);
            this.back.TabIndex = 4;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(329, 38);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(105, 30);
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
            this.dataGridView1.Size = new System.Drawing.Size(1003, 339);
            this.dataGridView1.TabIndex = 2;
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
            // view_flight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1054, 520);
            this.Controls.Add(this.groupBox1);
            this.Name = "view_flight";
            this.Text = "All Flights";
            this.Load += new System.EventHandler(this.view_flight_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox search_flight_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button last;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Button first;
        private System.Windows.Forms.Button reset;
    }
}