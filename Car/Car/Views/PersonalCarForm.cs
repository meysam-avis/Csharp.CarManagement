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
using Car.Models;

namespace Car.Views
{
    public partial class PersonalCarForm : Form
    {
        public PersonalCarForm()
        {
            InitializeComponent();
        }
        public int Id { set; get; }
        PersonalCarController _pc = new PersonalCarController();
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtShomarehNameh.Text.Trim() == string.Empty)
            {
                MessageBox.Show(Messages.Error_NewBimeh);
            }
            else
            {

                var m = new PersonalCar();

                m.CarId = int.Parse(cmbPelak.SelectedValue.ToString());
                m.Deleted = false;
                m.DriverId = int.Parse(cmbDriver.SelectedValue.ToString());
                m.Finished = chkPersonal.Checked;
              
                m.ShomareNameh = txtShomarehNameh.Text;
                m.TarikhBargasht = fdpBargasht.Controls[1].Text;
                m.TarikhRaft = fdpRaft.Controls[1].Text;
              
                m.KilometerRaft = int.Parse(txtKilometerRaft.Text);
                m.KilometerBargasht = int.Parse(txtKilometerBargasht.Text);

                m.UserId = Program.User.Id;
                if (Id == 0)
                {
                    _pc.Create(m);
                    Id = m.Id;
                }
                else
                {


                    m.Id = Id;
                    _pc.Update(m);

                }

                FillDGV();
            }



        }

        private void PersonalCarForm_Load(object sender, EventArgs e)
        {
            dgvCar.AutoGenerateColumns = false;


            FillDrivers();
            FillPelaks();
            FillDGV();
            
        }


        private void FillDrivers()
        {
            var d = new DriverController();
            cmbDriver.DataSource = d.GetAll();
            cmbDriver.DisplayMember = "Name";
            cmbDriver.ValueMember = "Id";

        }

        private void FillPelaks()
        {

            var p = new CarController();
            cmbPelak.DataSource = p.GetAll();
            cmbPelak.DisplayMember = "Pelak";
            cmbPelak.ValueMember = "Id";
        }

        private void FillDGV()
        {
            var mc = new PersonalCarController();
            dgvCar.DataSource = mc.GetAllDGV();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            Close();
        }


        private void dgvCar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right && e.RowIndex > -1)
            {


                if (MessageBox.Show("حذف شود؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                {

                    _pc.Delete(int.Parse(dgvCar.Rows[e.RowIndex].Cells[clnMamoriatId.Name].Value.ToString()));

                    FillDGV();

                }

            }


        }

        private void dgvCar_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left && e.RowIndex > -1)
            {
                var m = _pc.Get(int.Parse(dgvCar.Rows[e.RowIndex].Cells[clnMamoriatId.Name].Value.ToString()));
                Id = m.Id;

                txtShomarehNameh.Text = m.ShomareNameh;
              
                cmbDriver.SelectedValue = m.Driver.Id;
                cmbPelak.SelectedValue = m.Car.Id;
             
                fdpRaft.Text = m.TarikhRaft;
                fdpBargasht.Text = m.TarikhBargasht;
                txtKilometerBargasht.Text = m.KilometerBargasht.ToString();
                txtKilometerRaft.Text = m.KilometerRaft.ToString();
            }

        }




    }
}
