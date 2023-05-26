namespace Temperature_Converter_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FtoCin_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double fahrenheit = double.Parse(FtoCin.Text);


                double celsius = (fahrenheit - 32) * 5 / 9;
                FtoCout.Text = celsius.ToString();


            }
            catch (System.FormatException x)
            {
                FtoCout.Text = "";
            }
        }

        private void FtoKin_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double fahrenheit = double.Parse(FtoKin.Text); //eshte input


                double kelvin = (fahrenheit - 32) * 5 / 9 + 273.15;
                FtoKout.Text = kelvin.ToString();// eshte output


            }
            catch (System.FormatException x)
            {
                FtoKout.Text = ""; //eshte output
            }
        }

        private void CtoFin_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double celsius = double.Parse(CtoFin.Text);


                double fahrenheit = (celsius * 9 / 5) + 32;
                CtoFout.Text = fahrenheit.ToString();


            }
            catch (System.FormatException x)
            {
                CtoFout.Text = "";
            }
        }

        private void CtoKin_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double celsius = double.Parse(CtoKin.Text); //eshte input


                double kelvin = celsius + 273.15;
                CtoKout.Text = kelvin.ToString();// eshte output


            }
            catch (System.FormatException x)
            {
                CtoKout.Text = ""; //eshte output
            }
        }

        private void KtoCin_TextChanged(object sender, EventArgs e)
        {

            try
            {
                double kelvin = double.Parse(KtoCin.Text); //eshte input


                double celsius = kelvin - 273.15;
                KtoCout.Text = celsius.ToString();// esht output


            }
            catch (System.FormatException x)
            {
                KtoCout.Text = ""; //eshte output
            }
        }

        private void KtoFin_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double kelvin = double.Parse(KtoFin.Text); //eshte input


                double fahrenheit = (kelvin - 273.15) * 9 / 5 + 32;
                KtoFout.Text = fahrenheit.ToString();// esht output


            }
            catch (System.FormatException x)
            {
                KtoFout.Text = ""; //eshte output
            }
        }
    }
}