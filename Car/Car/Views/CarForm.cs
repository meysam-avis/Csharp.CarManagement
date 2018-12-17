using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Car.Controllers;
using Car.Infrastructure;

namespace Car.Views
{
    public partial class CarForm : Form
    {
        public CarForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtPelak.Text.Trim() == string.Empty)
            {
                MessageBox.Show(Messages.Error_Pelak);

            }else if (txtName.Text.Trim() == string.Empty)
            {

                MessageBox.Show(Messages.Error_CarName);
            }
            else
            {
                var c = new Models.Car();
                var cc = new CarController();

                c.Model = txtModel.Text;
                c.Name = txtName.Text;
                c.Pelak = txtPelak.Text;
                c.VahedId = int.Parse(cmbVahed.SelectedValue.ToString());
                c.Color = txtColor.Text;
                
                cc.Create(c);
                FillDGV();


            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarForm_Load(object sender, EventArgs e)
        {
            dgvCar.AutoGenerateColumns = false;
            FillVaheds();
            FillDGV();
        }

        private void FillVaheds()
        {
            var v=new VahedController();
            cmbVahed.DataSource = v.GetAll();
            cmbVahed.DisplayMember = "Name";
            cmbVahed.ValueMember = "Id";


        }

        private void FillDGV()
        {
            var v = new CarController();
            dgvCar.DataSource = v.GetAll();
           

        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
