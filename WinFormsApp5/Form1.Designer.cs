namespace WinFormsApp5
{
    partial class Form1
    {
        private System.Windows.Forms.DateTimePicker datePickerBirth;
        private System.Windows.Forms.DateTimePicker datePickerTarget;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.PictureBox chartBox;

        private void InitializeComponent()
        {
            this.datePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.datePickerTarget = new System.Windows.Forms.DateTimePicker();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.chartBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartBox)).BeginInit();
            this.SuspendLayout();

            // datePickerBirth
            this.datePickerBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerBirth.Location = new System.Drawing.Point(12, 12);
            this.datePickerBirth.Name = "datePickerBirth";
            this.datePickerBirth.Size = new System.Drawing.Size(200, 20);

            // datePickerTarget
            this.datePickerTarget.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerTarget.Location = new System.Drawing.Point(12, 38);
            this.datePickerTarget.Name = "datePickerTarget";
            this.datePickerTarget.Size = new System.Drawing.Size(200, 20);

            // btnCalculate
            this.btnCalculate.Location = new System.Drawing.Point(218, 25);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // chartBox
            this.chartBox.Location = new System.Drawing.Point(12, 64);
            this.chartBox.Name = "chartBox";
            this.chartBox.Size = new System.Drawing.Size(760, 384);
            this.chartBox.TabIndex = 3;
            this.chartBox.TabStop = false;

            // Form1
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.chartBox);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.datePickerTarget);
            this.Controls.Add(this.datePickerBirth);
            this.Name = "Form1";
            this.Text = "Biorhythm Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.chartBox)).EndInit();
            this.ResumeLayout(false);
        }
    }

}
