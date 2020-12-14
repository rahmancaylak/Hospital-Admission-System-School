
namespace HospitalAdmissionSystem
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbpatientComplaintDescription = new System.Windows.Forms.Label();
            this.tbPatientComplaintDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbPatientCivilizationNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDoctorDepartment = new System.Windows.Forms.ComboBox();
            this.cbPatientGender = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPatientAge = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbAge = new System.Windows.Forms.Label();
            this.tbPatientId = new System.Windows.Forms.TextBox();
            this.lbPatientId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbPatientName = new System.Windows.Forms.TextBox();
            this.cbDoctorName = new System.Windows.Forms.ComboBox();
            this.lbPatientName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.tbPatientSurname = new System.Windows.Forms.TextBox();
            this.lbSurname = new System.Windows.Forms.Label();
            this.dgvPatient = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbpatientComplaintDescription);
            this.groupBox1.Controls.Add(this.tbPatientComplaintDescription);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.tbPatientCivilizationNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbDoctorDepartment);
            this.groupBox1.Controls.Add(this.cbPatientGender);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbPatientAge);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.lbAge);
            this.groupBox1.Controls.Add(this.tbPatientId);
            this.groupBox1.Controls.Add(this.lbPatientId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.tbPatientName);
            this.groupBox1.Controls.Add(this.cbDoctorName);
            this.groupBox1.Controls.Add(this.lbPatientName);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.buttonRegister);
            this.groupBox1.Controls.Add(this.tbPatientSurname);
            this.groupBox1.Controls.Add(this.lbSurname);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 413);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Details";
            // 
            // lbpatientComplaintDescription
            // 
            this.lbpatientComplaintDescription.AutoSize = true;
            this.lbpatientComplaintDescription.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbpatientComplaintDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbpatientComplaintDescription.Location = new System.Drawing.Point(10, 260);
            this.lbpatientComplaintDescription.Name = "lbpatientComplaintDescription";
            this.lbpatientComplaintDescription.Size = new System.Drawing.Size(105, 15);
            this.lbpatientComplaintDescription.TabIndex = 17;
            this.lbpatientComplaintDescription.Text = "Patient Complaint";
            // 
            // tbPatientComplaintDescription
            // 
            this.tbPatientComplaintDescription.Location = new System.Drawing.Point(13, 278);
            this.tbPatientComplaintDescription.Multiline = true;
            this.tbPatientComplaintDescription.Name = "tbPatientComplaintDescription";
            this.tbPatientComplaintDescription.Size = new System.Drawing.Size(165, 129);
            this.tbPatientComplaintDescription.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(212, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Register Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(215, 278);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(171, 20);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Location = new System.Drawing.Point(215, 61);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(165, 1);
            this.panel5.TabIndex = 16;
            // 
            // tbPatientCivilizationNumber
            // 
            this.tbPatientCivilizationNumber.BackColor = System.Drawing.SystemColors.Control;
            this.tbPatientCivilizationNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPatientCivilizationNumber.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbPatientCivilizationNumber.Location = new System.Drawing.Point(215, 39);
            this.tbPatientCivilizationNumber.Name = "tbPatientCivilizationNumber";
            this.tbPatientCivilizationNumber.Size = new System.Drawing.Size(165, 19);
            this.tbPatientCivilizationNumber.TabIndex = 4;
            this.tbPatientCivilizationNumber.TextChanged += new System.EventHandler(this.tbPatientCivilizationNumber_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(212, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(212, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Patient Identification Number";
            // 
            // cbDoctorDepartment
            // 
            this.cbDoctorDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDoctorDepartment.FormattingEnabled = true;
            this.cbDoctorDepartment.Items.AddRange(new object[] {
            "Cardiology",
            "Anesthetics",
            "Breast Screening",
            "Ear, nose and throat (ENT)",
            "Elderly Services",
            "Gynecology"});
            this.cbDoctorDepartment.Location = new System.Drawing.Point(215, 217);
            this.cbDoctorDepartment.Name = "cbDoctorDepartment";
            this.cbDoctorDepartment.Size = new System.Drawing.Size(165, 21);
            this.cbDoctorDepartment.TabIndex = 16;
            // 
            // cbPatientGender
            // 
            this.cbPatientGender.BackColor = System.Drawing.SystemColors.Window;
            this.cbPatientGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPatientGender.FormattingEnabled = true;
            this.cbPatientGender.Items.AddRange(new object[] {
            "Man",
            "Woman"});
            this.cbPatientGender.Location = new System.Drawing.Point(215, 156);
            this.cbPatientGender.Name = "cbPatientGender";
            this.cbPatientGender.Size = new System.Drawing.Size(165, 21);
            this.cbPatientGender.TabIndex = 12;
            this.cbPatientGender.Tag = "";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Location = new System.Drawing.Point(13, 176);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(165, 1);
            this.panel4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(212, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Gender";
            // 
            // tbPatientAge
            // 
            this.tbPatientAge.BackColor = System.Drawing.SystemColors.Control;
            this.tbPatientAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPatientAge.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbPatientAge.Location = new System.Drawing.Point(13, 154);
            this.tbPatientAge.Name = "tbPatientAge";
            this.tbPatientAge.Size = new System.Drawing.Size(165, 19);
            this.tbPatientAge.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(12, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(165, 1);
            this.panel3.TabIndex = 13;
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbAge.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbAge.Location = new System.Drawing.Point(10, 136);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(26, 15);
            this.lbAge.TabIndex = 9;
            this.lbAge.Text = "Age";
            // 
            // tbPatientId
            // 
            this.tbPatientId.BackColor = System.Drawing.SystemColors.Control;
            this.tbPatientId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPatientId.Enabled = false;
            this.tbPatientId.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbPatientId.Location = new System.Drawing.Point(12, 39);
            this.tbPatientId.Name = "tbPatientId";
            this.tbPatientId.ReadOnly = true;
            this.tbPatientId.Size = new System.Drawing.Size(165, 19);
            this.tbPatientId.TabIndex = 2;
            // 
            // lbPatientId
            // 
            this.lbPatientId.AutoSize = true;
            this.lbPatientId.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbPatientId.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbPatientId.Location = new System.Drawing.Point(9, 21);
            this.lbPatientId.Name = "lbPatientId";
            this.lbPatientId.Size = new System.Drawing.Size(60, 15);
            this.lbPatientId.TabIndex = 1;
            this.lbPatientId.Text = "Patient ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(10, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Dr. Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(12, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 1);
            this.panel2.TabIndex = 8;
            // 
            // tbPatientName
            // 
            this.tbPatientName.BackColor = System.Drawing.SystemColors.Control;
            this.tbPatientName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPatientName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbPatientName.Location = new System.Drawing.Point(12, 94);
            this.tbPatientName.Name = "tbPatientName";
            this.tbPatientName.Size = new System.Drawing.Size(165, 19);
            this.tbPatientName.TabIndex = 6;
            // 
            // cbDoctorName
            // 
            this.cbDoctorName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDoctorName.FormattingEnabled = true;
            this.cbDoctorName.Items.AddRange(new object[] {
            "Dr. Rahman Çaylak",
            "Dr. John Doe",
            "Dr. Jennifer",
            "Dr. Adam"});
            this.cbDoctorName.Location = new System.Drawing.Point(13, 217);
            this.cbDoctorName.Name = "cbDoctorName";
            this.cbDoctorName.Size = new System.Drawing.Size(165, 21);
            this.cbDoctorName.TabIndex = 14;
            // 
            // lbPatientName
            // 
            this.lbPatientName.AutoSize = true;
            this.lbPatientName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbPatientName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbPatientName.Location = new System.Drawing.Point(9, 76);
            this.lbPatientName.Name = "lbPatientName";
            this.lbPatientName.Size = new System.Drawing.Size(38, 15);
            this.lbPatientName.TabIndex = 5;
            this.lbPatientName.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(215, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 1);
            this.panel1.TabIndex = 5;
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRegister.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonRegister.Location = new System.Drawing.Point(215, 319);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(171, 88);
            this.buttonRegister.TabIndex = 19;
            this.buttonRegister.Text = "Patient Register";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // tbPatientSurname
            // 
            this.tbPatientSurname.BackColor = System.Drawing.SystemColors.Control;
            this.tbPatientSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPatientSurname.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbPatientSurname.Location = new System.Drawing.Point(215, 94);
            this.tbPatientSurname.Name = "tbPatientSurname";
            this.tbPatientSurname.Size = new System.Drawing.Size(165, 19);
            this.tbPatientSurname.TabIndex = 8;
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSurname.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbSurname.Location = new System.Drawing.Point(212, 76);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(55, 15);
            this.lbSurname.TabIndex = 7;
            this.lbSurname.Text = "Surname";
            // 
            // dgvPatient
            // 
            this.dgvPatient.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatient.Location = new System.Drawing.Point(415, 26);
            this.dgvPatient.Name = "dgvPatient";
            this.dgvPatient.ReadOnly = true;
            this.dgvPatient.Size = new System.Drawing.Size(763, 413);
            this.dgvPatient.TabIndex = 1;
            this.dgvPatient.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatient_CellDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 451);
            this.Controls.Add(this.dgvPatient);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Hospital Admission System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox tbPatientSurname;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.DataGridView dgvPatient;
        private System.Windows.Forms.ComboBox cbDoctorName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbPatientId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbPatientName;
        private System.Windows.Forms.Label lbPatientName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPatientAge;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDoctorDepartment;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbPatientCivilizationNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbPatientGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbpatientComplaintDescription;
        private System.Windows.Forms.TextBox tbPatientComplaintDescription;
        private System.Windows.Forms.TextBox tbPatientId;
    }
}

