using System;
using System.Windows.Forms;
using Car.Extensions;
using Car.Views;

namespace Car
{
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
        }
        
        private void MainFrom_Load(object sender, EventArgs e)
        {
            
            lblVersion.Text = Program.Version;

            lblDate.Text = DateTime.Now.GetPersianDate();
            lblUserName.Text = Program.User.Name;
        }

        private void btnMamoriat_Click(object sender, EventArgs e)
        {
            new MamoriatForm().ShowDialog();
            
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            new CarForm().ShowDialog();
        }

        private void btnDriver_Click(object sender, EventArgs e)
        {
            new DriverForm().ShowDialog();

        }

        private void btnBimeh_Click(object sender, EventArgs e)
        {
            new BimehForm().ShowDialog();
        }

        private void btnAvarez_Click(object sender, EventArgs e)
        {
            new AvarezForm().ShowDialog();
        }

        private void btnHazineh_Click(object sender, EventArgs e)
        {
            new FuelForm().ShowDialog();
        }

        private void btnTasadof_Click(object sender, EventArgs e)
        {
            new TasadofForm().ShowDialog();
        }

        private void btnFanni_Click(object sender, EventArgs e)
        {
            new FanniForm().ShowDialog();

        }

        private void btnPersonCar_Click(object sender, EventArgs e)
        {
            new PersonalCarForm().ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
