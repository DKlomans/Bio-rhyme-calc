namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DateTime birthDate = datePickerBirth.Value;
            DateTime targetDate = datePickerTarget.Value;
            int t = (int)(targetDate - birthDate).TotalDays;
            double physical = Math.Sin(2 * Math.PI * t / 23) * 100;
            double emotional = Math.Sin(2 * Math.PI * t / 28) * 100;
            double intellectual = Math.Sin(2 * Math.PI * t / 33) * 100;

            DrawBiorhythmChart(physical, emotional, intellectual);
        }

        private void DrawBiorhythmChart(double physical, double emotional, double intellectual)
        {

            Graphics g = chartBox.CreateGraphics();
            g.Clear(chartBox.BackColor);

 
            Pen pen = new Pen(Color.Red, 2);
            g.DrawLine(pen, 0, 50, (int)physical, 50);
            pen.Color = Color.Blue;
            g.DrawLine(pen, 0, 100, (int)emotional, 100);
            pen.Color = Color.Green;
            g.DrawLine(pen, 0, 150, (int)intellectual, 150);
        }
    }

}
