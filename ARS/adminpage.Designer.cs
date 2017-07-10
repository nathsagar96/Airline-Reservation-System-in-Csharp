namespace ARS
{
    partial class adminpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminpage));
            this.operation = new System.Windows.Forms.GroupBox();
            this.registration = new System.Windows.Forms.Button();
            this.schedule = new System.Windows.Forms.Button();
            this.view = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.welcomelabel = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.adminlogo = new System.Windows.Forms.PictureBox();
            this.operation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // operation
            // 
            this.operation.Controls.Add(this.registration);
            this.operation.Controls.Add(this.schedule);
            this.operation.Controls.Add(this.view);
            this.operation.Controls.Add(this.update);
            this.operation.Controls.Add(this.delete);
            this.operation.Controls.Add(this.add);
            this.operation.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operation.Location = new System.Drawing.Point(291, 91);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(600, 294);
            this.operation.TabIndex = 0;
            this.operation.TabStop = false;
            this.operation.Text = "Operation";
            // 
            // registration
            // 
            this.registration.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registration.Location = new System.Drawing.Point(277, 198);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(165, 49);
            this.registration.TabIndex = 5;
            this.registration.Text = "Add User";
            this.registration.UseVisualStyleBackColor = true;
            this.registration.Click += new System.EventHandler(this.registration_Click);
            // 
            // schedule
            // 
            this.schedule.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedule.Location = new System.Drawing.Point(277, 123);
            this.schedule.Name = "schedule";
            this.schedule.Size = new System.Drawing.Size(165, 49);
            this.schedule.TabIndex = 4;
            this.schedule.Text = "Schedule Flights";
            this.schedule.UseVisualStyleBackColor = true;
            this.schedule.Click += new System.EventHandler(this.schedule_Click);
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(277, 34);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(157, 58);
            this.view.TabIndex = 3;
            this.view.Text = "View Flights";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(15, 198);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(207, 51);
            this.update.TabIndex = 2;
            this.update.Text = "Update Flights";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(15, 121);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(207, 51);
            this.delete.TabIndex = 1;
            this.delete.Text = "Delete Flight";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(15, 34);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(207, 58);
            this.add.TabIndex = 0;
            this.add.Text = "Add Flight";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // welcomelabel
            // 
            this.welcomelabel.AutoSize = true;
            this.welcomelabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomelabel.CausesValidation = false;
            this.welcomelabel.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomelabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.welcomelabel.Location = new System.Drawing.Point(39, 9);
            this.welcomelabel.Name = "welcomelabel";
            this.welcomelabel.Size = new System.Drawing.Size(302, 57);
            this.welcomelabel.TabIndex = 2;
            this.welcomelabel.Text = "Welcome Admin";
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(33, 347);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(201, 38);
            this.logout.TabIndex = 3;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // adminlogo
            // 
            this.adminlogo.Image = ((System.Drawing.Image)(resources.GetObject("adminlogo.Image")));
            this.adminlogo.InitialImage = null;
            this.adminlogo.Location = new System.Drawing.Point(33, 91);
            this.adminlogo.Name = "adminlogo";
            this.adminlogo.Size = new System.Drawing.Size(211, 211);
            this.adminlogo.TabIndex = 4;
            this.adminlogo.TabStop = false;
            // 
            // adminpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(935, 414);
            this.Controls.Add(this.adminlogo);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.welcomelabel);
            this.Controls.Add(this.operation);
            this.Name = "adminpage";
            this.Text = "Admin Home";
            this.Load += new System.EventHandler(this.adminpage_Load);
            this.operation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adminlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox operation;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label welcomelabel;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button schedule;
        private System.Windows.Forms.Button registration;
        private System.Windows.Forms.PictureBox adminlogo;
    }
}

