namespace ARS
{
    partial class user_home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user_home));
            this.history = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.book_flight = new System.Windows.Forms.Button();
            this.userlogo = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.userlogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // history
            // 
            this.history.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history.Location = new System.Drawing.Point(271, 303);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(185, 61);
            this.history.TabIndex = 12;
            this.history.Text = "Previous Bookings";
            this.history.UseVisualStyleBackColor = true;
            this.history.Click += new System.EventHandler(this.history_Click);
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(29, 314);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(156, 50);
            this.logout.TabIndex = 11;
            this.logout.Text = "Log out";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(271, 206);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(197, 57);
            this.cancel.TabIndex = 10;
            this.cancel.Text = "Cancel Ticket";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_ticket_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(271, 109);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(197, 60);
            this.search.TabIndex = 9;
            this.search.Text = "Search Flight";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // book_flight
            // 
            this.book_flight.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_flight.Location = new System.Drawing.Point(271, 19);
            this.book_flight.Name = "book_flight";
            this.book_flight.Size = new System.Drawing.Size(197, 59);
            this.book_flight.TabIndex = 8;
            this.book_flight.Text = "Book Flight";
            this.book_flight.UseVisualStyleBackColor = true;
            this.book_flight.Click += new System.EventHandler(this.book_flight_Click);
            // 
            // userlogo
            // 
            this.userlogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("userlogo.InitialImage")));
            this.userlogo.Location = new System.Drawing.Point(29, 30);
            this.userlogo.Name = "userlogo";
            this.userlogo.Size = new System.Drawing.Size(156, 185);
            this.userlogo.TabIndex = 7;
            this.userlogo.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.userlogo);
            this.groupBox1.Controls.Add(this.history);
            this.groupBox1.Controls.Add(this.logout);
            this.groupBox1.Controls.Add(this.cancel);
            this.groupBox1.Controls.Add(this.book_flight);
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 385);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // user_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(502, 412);
            this.Controls.Add(this.groupBox1);
            this.Name = "user_home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.userlogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button history;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button book_flight;
        private System.Windows.Forms.PictureBox userlogo;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}