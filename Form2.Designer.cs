namespace healthcare
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEditPatientDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePatientRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDoctorStaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignDoctorToPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleAppointmentForPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAppointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentsHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpSupportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactSupportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pbPatient = new System.Windows.Forms.PictureBox();
            this.pbAppointment = new System.Windows.Forms.PictureBox();
            this.pbStaff = new System.Windows.Forms.PictureBox();
            this.pbHelp = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::healthcare.Properties.Resources.Vitality_Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(800, 418);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 79);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.doctorManagementToolStripMenuItem,
            this.appointmentsToolStripMenuItem,
            this.helpSupportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(988, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewPatientToolStripMenuItem,
            this.viewEditPatientDetailsToolStripMenuItem,
            this.deletePatientRecordToolStripMenuItem});
            this.mainMenuToolStripMenuItem.Image = global::healthcare.Properties.Resources.patient;
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(146, 20);
            this.mainMenuToolStripMenuItem.Text = "Patient Management";
            // 
            // addNewPatientToolStripMenuItem
            // 
            this.addNewPatientToolStripMenuItem.Name = "addNewPatientToolStripMenuItem";
            this.addNewPatientToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.addNewPatientToolStripMenuItem.Text = "Add New Patient";
            // 
            // viewEditPatientDetailsToolStripMenuItem
            // 
            this.viewEditPatientDetailsToolStripMenuItem.Name = "viewEditPatientDetailsToolStripMenuItem";
            this.viewEditPatientDetailsToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.viewEditPatientDetailsToolStripMenuItem.Text = "View / Edit Patient Details";
            // 
            // deletePatientRecordToolStripMenuItem
            // 
            this.deletePatientRecordToolStripMenuItem.Name = "deletePatientRecordToolStripMenuItem";
            this.deletePatientRecordToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.deletePatientRecordToolStripMenuItem.Text = "Delete Patient Record";
            // 
            // doctorManagementToolStripMenuItem
            // 
            this.doctorManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDoctorToolStripMenuItem,
            this.viewDoctorStaToolStripMenuItem,
            this.assignDoctorToPatientToolStripMenuItem});
            this.doctorManagementToolStripMenuItem.Image = global::healthcare.Properties.Resources.doctor4;
            this.doctorManagementToolStripMenuItem.Name = "doctorManagementToolStripMenuItem";
            this.doctorManagementToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.doctorManagementToolStripMenuItem.Text = "Staff Management";
            // 
            // addNewDoctorToolStripMenuItem
            // 
            this.addNewDoctorToolStripMenuItem.Name = "addNewDoctorToolStripMenuItem";
            this.addNewDoctorToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.addNewDoctorToolStripMenuItem.Text = "Add New Doctor / Staff";
            // 
            // viewDoctorStaToolStripMenuItem
            // 
            this.viewDoctorStaToolStripMenuItem.Name = "viewDoctorStaToolStripMenuItem";
            this.viewDoctorStaToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.viewDoctorStaToolStripMenuItem.Text = "View Doctor / Staff Details";
            // 
            // assignDoctorToPatientToolStripMenuItem
            // 
            this.assignDoctorToPatientToolStripMenuItem.Name = "assignDoctorToPatientToolStripMenuItem";
            this.assignDoctorToPatientToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.assignDoctorToPatientToolStripMenuItem.Text = "Assign Doctor To Patient";
            // 
            // appointmentsToolStripMenuItem
            // 
            this.appointmentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleAppointmentForPatientToolStripMenuItem,
            this.viewAppointmentsToolStripMenuItem,
            this.cancelAppointmentToolStripMenuItem,
            this.appointmentsHistoryToolStripMenuItem});
            this.appointmentsToolStripMenuItem.Image = global::healthcare.Properties.Resources.appointment;
            this.appointmentsToolStripMenuItem.Name = "appointmentsToolStripMenuItem";
            this.appointmentsToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.appointmentsToolStripMenuItem.Text = "Appointments";
            // 
            // scheduleAppointmentForPatientToolStripMenuItem
            // 
            this.scheduleAppointmentForPatientToolStripMenuItem.Name = "scheduleAppointmentForPatientToolStripMenuItem";
            this.scheduleAppointmentForPatientToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.scheduleAppointmentForPatientToolStripMenuItem.Text = "Schedule Appointment";
            // 
            // viewAppointmentsToolStripMenuItem
            // 
            this.viewAppointmentsToolStripMenuItem.Name = "viewAppointmentsToolStripMenuItem";
            this.viewAppointmentsToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.viewAppointmentsToolStripMenuItem.Text = "View Appointments";
            // 
            // cancelAppointmentToolStripMenuItem
            // 
            this.cancelAppointmentToolStripMenuItem.Name = "cancelAppointmentToolStripMenuItem";
            this.cancelAppointmentToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.cancelAppointmentToolStripMenuItem.Text = "Cancel Appointment";
            // 
            // appointmentsHistoryToolStripMenuItem
            // 
            this.appointmentsHistoryToolStripMenuItem.Name = "appointmentsHistoryToolStripMenuItem";
            this.appointmentsHistoryToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.appointmentsHistoryToolStripMenuItem.Text = "Appointments History";
            // 
            // helpSupportToolStripMenuItem
            // 
            this.helpSupportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userGuideToolStripMenuItem,
            this.contactSupportToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpSupportToolStripMenuItem.Image = global::healthcare.Properties.Resources.support1;
            this.helpSupportToolStripMenuItem.Name = "helpSupportToolStripMenuItem";
            this.helpSupportToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.helpSupportToolStripMenuItem.Text = "Help and Support";
            // 
            // userGuideToolStripMenuItem
            // 
            this.userGuideToolStripMenuItem.Name = "userGuideToolStripMenuItem";
            this.userGuideToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.userGuideToolStripMenuItem.Text = "User Guide";
            // 
            // contactSupportToolStripMenuItem
            // 
            this.contactSupportToolStripMenuItem.Name = "contactSupportToolStripMenuItem";
            this.contactSupportToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.contactSupportToolStripMenuItem.Text = "Contact Support";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.exitToolStripMenuItem.Image = global::healthcare.Properties.Resources.exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            // 
            // pbPatient
            // 
            this.pbPatient.BackColor = System.Drawing.Color.Transparent;
            this.pbPatient.BackgroundImage = global::healthcare.Properties.Resources.round;
            this.pbPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPatient.Image = global::healthcare.Properties.Resources.patient;
            this.pbPatient.Location = new System.Drawing.Point(213, 70);
            this.pbPatient.Name = "pbPatient";
            this.pbPatient.Size = new System.Drawing.Size(202, 143);
            this.pbPatient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPatient.TabIndex = 5;
            this.pbPatient.TabStop = false;
            // 
            // pbAppointment
            // 
            this.pbAppointment.BackColor = System.Drawing.Color.Transparent;
            this.pbAppointment.BackgroundImage = global::healthcare.Properties.Resources.round;
            this.pbAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAppointment.Image = global::healthcare.Properties.Resources.appointment;
            this.pbAppointment.Location = new System.Drawing.Point(733, 70);
            this.pbAppointment.Name = "pbAppointment";
            this.pbAppointment.Size = new System.Drawing.Size(202, 143);
            this.pbAppointment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAppointment.TabIndex = 6;
            this.pbAppointment.TabStop = false;
            // 
            // pbStaff
            // 
            this.pbStaff.BackColor = System.Drawing.Color.Transparent;
            this.pbStaff.BackgroundImage = global::healthcare.Properties.Resources.round;
            this.pbStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbStaff.Image = global::healthcare.Properties.Resources.doctor4;
            this.pbStaff.Location = new System.Drawing.Point(473, 70);
            this.pbStaff.Name = "pbStaff";
            this.pbStaff.Size = new System.Drawing.Size(202, 143);
            this.pbStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStaff.TabIndex = 7;
            this.pbStaff.TabStop = false;
            // 
            // pbHelp
            // 
            this.pbHelp.BackColor = System.Drawing.Color.Transparent;
            this.pbHelp.BackgroundImage = global::healthcare.Properties.Resources.round;
            this.pbHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHelp.Image = global::healthcare.Properties.Resources.support1;
            this.pbHelp.Location = new System.Drawing.Point(342, 269);
            this.pbHelp.Name = "pbHelp";
            this.pbHelp.Size = new System.Drawing.Size(202, 143);
            this.pbHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHelp.TabIndex = 8;
            this.pbHelp.TabStop = false;
            // 
            // pbExit
            // 
            this.pbExit.BackColor = System.Drawing.Color.Transparent;
            this.pbExit.BackgroundImage = global::healthcare.Properties.Resources.round;
            this.pbExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExit.Image = global::healthcare.Properties.Resources.exit4;
            this.pbExit.Location = new System.Drawing.Point(606, 269);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(202, 143);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit.TabIndex = 9;
            this.pbExit.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(219, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Patient Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(491, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Staff Management";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(359, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Help and Support";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(686, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Exit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(769, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Appointments";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::healthcare.Properties.Resources.back_21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(988, 531);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.pbHelp);
            this.Controls.Add(this.pbStaff);
            this.Controls.Add(this.pbAppointment);
            this.Controls.Add(this.pbPatient);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Vitality™";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pbPatient;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpSupportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEditPatientDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePatientRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDoctorStaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignDoctorToPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleAppointmentForPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAppointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentsHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userGuideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactSupportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pbAppointment;
        private System.Windows.Forms.PictureBox pbStaff;
        private System.Windows.Forms.PictureBox pbHelp;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
