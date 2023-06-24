namespace determinant_calculator
{
    public partial class Form1 : Form
    {
        double x1;
        double y1;
        double z1;
        double c1;

        double x2;
        double y2;
        double z2;
        double c2;

        double x3;
        double y3;
        double z3;
        double c3;

        double D;
        double Nx;
        double Ny;
        double Nz;

        double X;
        double Y;
        double Z;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            x1 = double.Parse(param_x1.Text);
            y1 = double.Parse(param_x2.Text);
            z1 = double.Parse(param_x3.Text);
            c1 = double.Parse(param_c1.Text);

            x2 = double.Parse(param_x2.Text);
            y2 = double.Parse(param_y2.Text);
            z2 = double.Parse(param_z2.Text);
            c2 = double.Parse(param_c2.Text);

            x3 = double.Parse(param_x3.Text);
            y3 = double.Parse(param_y3.Text);
            z3 = double.Parse(param_z3.Text);
            c3 = double.Parse(param_c3.Text);

            D = ((x1 * y2 * z3) + (y1 * z2 * x3) + (z1 * x2 * y3) - (x3 * y2 * z1) - (y3 * z2 * x1) - (z3 * x2 * y1));
            double roundedD = Math.Round(D, 2);
            Nx = ((c1 * y2 * z3) + (y1 * z2 * c3) + (z1 * c2 * y3) - (c3 * y2 * z1) - (y3 * z2 * c1) - (z3 * c2 * y1));
            double roundedNx = Math.Round(Nx, 2);
            Ny = ((x1 * c2 * z3) + (c1 * z2 * x3) + (z1 * x2 * c3) - (x3 * c2 * z1) - (c3 * z2 * x1) - (z3 * x2 * c1));
            double roundedNy = Math.Round(Ny, 2);
            Nz = ((x1 * y2 * c3) + (y1 * c2 * x3) + (c1 * x2 * y3) - (x3 * y2 * c1) - (y3 * c2 * x1) - (c3 * x2 * y1));
            double roundedNz = Math.Round(Nz, 2);

            X = Nx / D;
            double roundedX = Math.Round(X, 2);
            Y = Ny / D;
            double roundedY = Math.Round(Y, 2);
            Z = Nz / D;
            double roundedZ = Math.Round(Z, 2);

            param_Nx.Text = ($"Nx = {roundedNx.ToString()}");
            param_Ny.Text = ($"Ny = {roundedNy.ToString()}");
            param_Nz.Text = ($"Nz = {roundedNz.ToString()}");
            param__D.Text = ($"D = {roundedD.ToString()}");
            param_X.Text = ($"X = {roundedX.ToString()}");
            param_Y.Text = ($"Y = {roundedY.ToString()}");
            param_Z.Text = ($"Z = {roundedZ.ToString()}");
        }

        private void param_Z_TextChanged(object sender, EventArgs e)
        {

        }

        private void param_Y_TextChanged(object sender, EventArgs e)
        {
        }

        private void param_X_TextChanged(object sender, EventArgs e)
        {
        }
    }
}