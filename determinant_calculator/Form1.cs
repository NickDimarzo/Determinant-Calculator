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

        double D = 0;
        double Nx = 0;
        double Ny = 0;
        double Nz = 0;

        double X = 0;
        double Y = 0;
        double Z = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
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

        private void calculate_Click(object sender, EventArgs e)
        {
            D = ((x1 * y2 * z3) + (y1 * z2 * x3) + (z1 * x2 * y3) - (x3 * y2 * z1) - (y3 * z2 * x1) - (z3 * x2 * y1));
            Nx = ((c1 * y2 * z3) + (y1 * z2 * c3) + (z1 * c2 * y3) - (c3 * y2 * z1) - (y3 * z2 * c1) - (z3 * c2 * y1));
            Ny = ((x1 * c2 * z3) + (c1 * z2 * x3) + (z1 * x2 * c3) - (x3 * c2 * z1) - (c3 * z2 * x1) - (z3 * x2 * c1));
            Nz = ((x1 * y2 * c3) + (y1 * c2 * x3) + (c1 * x2 * y3) - (x3 * y2 * c1) - (y3 * c2 * x1) - (c3 * x2 * y1));

            X = Nx / D;
            Y = Ny / D;
            Z = Nz / D;
        }

        private void param_Nx_TextChanged(object sender, EventArgs e)
        {
            param_Nx.Text = ($"Nx = {Nx.ToString()}");
        }

        private void param_Ny_TextChanged(object sender, EventArgs e)
        {
            param_Ny.Text = ($"Ny = {Ny.ToString()}");
        }

        private void param_Nz_TextChanged(object sender, EventArgs e)
        {
            param_Nz.Text = ($"Nz = {Nz.ToString()}");
        }

        private void param__D_TextChanged(object sender, EventArgs e)
        {
            param__D.Text = ($"D = {D.ToString()}");
        }

        private void param_X_TextChanged(object sender, EventArgs e)
        {
            param_X.Text = ($"X = {X.ToString()}");
        }

        private void param_Y_TextChanged(object sender, EventArgs e)
        {
            param_Y.Text = ($"Y = {Y.ToString()}");
        }

        private void param_Z_TextChanged(object sender, EventArgs e)
        {
            param_Z.Text = ($"Z = {Z.ToString()}");
        }


    }
}