namespace HospitalManagementWinform
{
    partial class PatientPage
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addPatientButton = new System.Windows.Forms.Button();
            this.editPatientButton = new System.Windows.Forms.Button();
            this.deletePatientButton = new System.Windows.Forms.Button();
            this.patientsCount = new System.Windows.Forms.Label();
            this.patientsList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, -1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(803, 90);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // addPatientButton
            // 
            this.addPatientButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addPatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPatientButton.Location = new System.Drawing.Point(71, 155);
            this.addPatientButton.Name = "addPatientButton";
            this.addPatientButton.Size = new System.Drawing.Size(103, 30);
            this.addPatientButton.TabIndex = 1;
            this.addPatientButton.Text = "ADD PATIENT";
            this.addPatientButton.UseVisualStyleBackColor = false;
            this.addPatientButton.Click += new System.EventHandler(this.addPatientButton_Click);
            // 
            // editPatientButton
            // 
            this.editPatientButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.editPatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPatientButton.Location = new System.Drawing.Point(71, 219);
            this.editPatientButton.Name = "editPatientButton";
            this.editPatientButton.Size = new System.Drawing.Size(103, 30);
            this.editPatientButton.TabIndex = 2;
            this.editPatientButton.Text = "EDIT PATIENT";
            this.editPatientButton.UseVisualStyleBackColor = false;
            this.editPatientButton.Click += new System.EventHandler(this.editPatientButton_Click);
            // 
            // deletePatientButton
            // 
            this.deletePatientButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.deletePatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePatientButton.Location = new System.Drawing.Point(71, 277);
            this.deletePatientButton.Name = "deletePatientButton";
            this.deletePatientButton.Size = new System.Drawing.Size(103, 37);
            this.deletePatientButton.TabIndex = 3;
            this.deletePatientButton.Text = "DELETE PATIENT";
            this.deletePatientButton.UseVisualStyleBackColor = false;
            this.deletePatientButton.Click += new System.EventHandler(this.deletePatientButton_Click);
            // 
            // patientsCount
            // 
            this.patientsCount.AutoSize = true;
            this.patientsCount.Location = new System.Drawing.Point(310, 395);
            this.patientsCount.Name = "patientsCount";
            this.patientsCount.Size = new System.Drawing.Size(35, 13);
            this.patientsCount.TabIndex = 5;
            this.patientsCount.Text = "label1";
            // 
            // patientsList
            // 
            this.patientsList.FormattingEnabled = true;
            this.patientsList.Location = new System.Drawing.Point(365, 117);
            this.patientsList.Name = "patientsList";
            this.patientsList.Size = new System.Drawing.Size(406, 290);
            this.patientsList.TabIndex = 6;
            // 
            // PatientPagina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.patientsList);
            this.Controls.Add(this.patientsCount);
            this.Controls.Add(this.deletePatientButton);
            this.Controls.Add(this.editPatientButton);
            this.Controls.Add(this.addPatientButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "PatientPagina";
            this.Text = "PATIENT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button addPatientButton;
        private System.Windows.Forms.Button editPatientButton;
        private System.Windows.Forms.Button deletePatientButton;
        private System.Windows.Forms.Label patientsCount;
        private System.Windows.Forms.ListBox patientsList;
    }
}