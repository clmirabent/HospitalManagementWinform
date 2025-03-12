namespace HospitalManagementWinform
{
    partial class AppointmentForm
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
            this.patientSelector = new System.Windows.Forms.ComboBox();
            this.doctorSelector = new System.Windows.Forms.ComboBox();
            this.doctorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateBox = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, -2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(803, 84);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // patientSelector
            // 
            this.patientSelector.FormattingEnabled = true;
            this.patientSelector.Location = new System.Drawing.Point(139, 173);
            this.patientSelector.Name = "patientSelector";
            this.patientSelector.Size = new System.Drawing.Size(121, 21);
            this.patientSelector.TabIndex = 1;
            // 
            // doctorSelector
            // 
            this.doctorSelector.FormattingEnabled = true;
            this.doctorSelector.Location = new System.Drawing.Point(516, 173);
            this.doctorSelector.Name = "doctorSelector";
            this.doctorSelector.Size = new System.Drawing.Size(121, 21);
            this.doctorSelector.TabIndex = 2;
            // 
            // doctorLabel
            // 
            this.doctorLabel.AutoSize = true;
            this.doctorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorLabel.Location = new System.Drawing.Point(513, 139);
            this.doctorLabel.Name = "doctorLabel";
            this.doctorLabel.Size = new System.Drawing.Size(105, 15);
            this.doctorLabel.TabIndex = 3;
            this.doctorLabel.Text = "Assign a doctor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select a patient";
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(139, 288);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(203, 20);
            this.dateBox.TabIndex = 5;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(136, 258);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(91, 15);
            this.dateLabel.TabIndex = 6;
            this.dateLabel.Text = "Select a date";
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doctorLabel);
            this.Controls.Add(this.doctorSelector);
            this.Controls.Add(this.patientSelector);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "AppointmentForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox patientSelector;
        private System.Windows.Forms.ComboBox doctorSelector;
        private System.Windows.Forms.Label doctorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateBox;
        private System.Windows.Forms.Label dateLabel;
    }
}