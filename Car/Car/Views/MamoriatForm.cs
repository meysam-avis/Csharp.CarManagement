using System;
using System.Windows.Forms;
using Car.Controllers;
using Car.Infrastructure;
using Car.Models;

namespace Car.Views
{
    public partial class MamoriatForm : Form
    {
        public int Id { set; get; }
        MamoriatController mc = new MamoriatController();
        public MamoriatForm()
        {
            InitializeComponent();
        }

        private void MamoriatForm_Load(object sender, EventArgs e)
        {
            dgvCar.AutoGenerateColumns = false;
           

            FillDrivers();
            FillPelaks();
            FillDGV();
            dtRaft.Value = DateTime.Now;
            dtBatgasht.Value = DateTime.Now;
          
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
            var mc = new MamoriatController();
            dgvCar.DataSource = mc.GetAllDGV();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtShomarehNameh.Text.Trim() == string.Empty)
            {
                MessageBox.Show(Messages.Error_NewBimeh);
            }
            else
            {
                
                var m = new Mamoriat();
               
                m.CarId = int.Parse(cmbPelak.SelectedValue.ToString());
                m.Deleted = false;
                m.DriverId = int.Parse(cmbDriver.SelectedValue.ToString());
                m.Finished = false;
                m.Mabda = txtMabda.Text;
                m.Maghsad = txtMaghsad.Text;
                m.ShomareNameh = txtShomarehNameh.Text;
                m.TarikhBargasht = fdpBargasht.Controls[1].Text;
                m.TarikhRaft = fdpRaft.Controls[1].Text;
                m.ZamanBargasht = dtBatgasht.Text;
                m.ZamanRaft = dtRaft.Text;
                m.KilometerRaft = int.Parse( txtKilometerRaft.Text);
                m.KilometerBargasht = int.Parse( txtKilometerBargasht.Text);
                m.Finished = chkEndOfMamoriat.Checked;
                m.UserId = Program.User.Id;
                if (Id == 0)
                {
                    mc.Create(m);
                    Id = m.Id;
                }
                else
                {

                    m.Id = Id;
                    mc.Update(m);

                }

                FillDGV();
            }
        }

        private void dgvCar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right && e.RowIndex > -1)
            {
               

                if (MessageBox.Show("حذف شود؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                {

                    mc.Delete(int.Parse(dgvCar.Rows[e.RowIndex].Cells[clnMamoriatId.Name].Value.ToString()));

                    FillDGV();

                }

            }


        }

        private void dgvCar_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left && e.RowIndex > -1)
            {
                var m = mc.Get(int.Parse(dgvCar.Rows[e.RowIndex].Cells[clnMamoriatId.Name].Value.ToString()));
                Id = m.Id;
              
                txtShomarehNameh.Text = m.ShomareNameh;
                txtMabda.Text = m.Mabda;
                txtMaghsad.Text = m.Maghsad;
                cmbDriver.SelectedValue = m.Driver.Id;
                cmbPelak.SelectedValue = m.Car.Id;
                dtRaft.Text = m.ZamanRaft;
                dtBatgasht.Text = m.ZamanBargasht;
                fdpRaft.Text = m.TarikhRaft;
                fdpBargasht.Text = m.TarikhBargasht;
                txtKilometerBargasht.Text = m.KilometerBargasht.ToString();
                txtKilometerRaft.Text = m.KilometerRaft.ToString();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

      
    }
}
