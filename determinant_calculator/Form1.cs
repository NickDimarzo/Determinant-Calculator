namespace determinant_calculator
{
    public partial class Form1 : Form
    {
        double x1 = 0;
        double y1 = 0;
        double z1 = 0;
        double c1 = 0;

        double x2 = 0;
        double y2 = 0;
        double z2 = 0;
        double c2 = 0;

        double x3 = 0;
        double y3 = 0;
        double z3 = 0;
        double c3 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void param_x1_TextChanged(object sender, EventArgs e)
        {
            x1 = double.Parse(param_x1.Text);
        }

        private void param_x2_TextChanged(object sender, EventArgs e)
        {
            x2 = double.Parse(param_x2.Text);
        }

        private void param_x3_TextChanged(object sender, EventArgs e)
        {
            x3 = double.Parse(param_x3.Text);
        }

        private void param_y1_TextChanged(object sender, EventArgs e)
        {
            y1 = double.Parse(param_y1.Text);
        }

        private void param_y2_TextChanged(object sender, EventArgs e)
        {
            y2 = double.Parse(param_y2.Text);
        }

        private void param_y3_TextChanged(object sender, EventArgs e)
        {
            y3 = double.Parse(param_y3.Text);
        }

        private void param_z1_TextChanged(object sender, EventArgs e)
        {
            z1 = double.Parse(param_z1.Text);
        }

        private void param_z2_TextChanged(object sender, EventArgs e)
        {
            z2 = double.Parse(param_z2.Text);
        }

        private void param_z3_TextChanged(object sender, EventArgs e)
        {
            z3 = double.Parse(param_z3.Text);
        }

        private void param_c1_TextChanged(object sender, EventArgs e)
        {
            c1 = double.Parse(param_c1.Text);
        }

        private void param_c2_TextChanged(object sender, EventArgs e)
        {
            c2 = double.Parse(param_c2.Text);
        }

        private void param_c3_TextChanged(object sender, EventArgs e)
        {
            c3 = double.Parse(param_c3.Text);
        }
    }
}