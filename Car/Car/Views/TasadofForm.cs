using Car.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Car.Infrastructure;
using Car.Models;
using Microsoft.VisualBasic;

namespace Car.Views
{
    public partial class TasadofForm : Form
    {
        public TasadofForm()
        {
            InitializeComponent();
        }
        TasadofController _tc = new TasadofController();
        public int Id { set; get; } = 0;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!Information.IsNumeric(txtPrice.Text ))
            {

                MessageBox.Show(Messages.Error_Mablagh);
            }
            else
            {
                var t = new Tasadof
                {

                    CarId = int.Parse(cmbPelak.SelectedValue.ToString()),
                    DriverId = int.Parse(cmbDriver.SelectedValue.ToString()),
                    Price = long.Parse(txtPrice.Text),
                    Tarikh = fdTasadofDate.Controls[1].Text
                };
                if (Id == 0)
                {

                    _tc.Create(t);
                
                }
                else
                {
                    t.Id = Id;
                    _tc.Update(t);
                    Id = 0;
                   
                }


                ClearValues();
                FillDGV();
            }

          


        }
        private void FillPelak()
        {
            var cc = new CarController();
            cmbPelak.DataSource = cc.GetAll();
            cmbPelak.DisplayMember = "Pelak";
            cmbPelak.ValueMember = "Id";

        }
        private void FillDrivers()
        {
            var d = new DriverController();
            cmbDriver.DataSource = d.GetAll();
            cmbDriver.DisplayMember = "Name";
            cmbDriver.ValueMember = "Id";

        }

        private void ClearValues()
        {
            txtPrice.Text = "";
            fdTasadofDate.GeoDate = DateTime.Now;
        }

        private void TasadofForm_Load(object sender, EventArgs e)
        {
           // dgvTasadof.AutoGenerateColumns = false;
            FillPelak();
            FillDrivers();
            FillDGV();

        }

        private void dgvTasadof_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > -1)
            {


                if (MessageBox.Show("حذف شود؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                {

                    _tc.Delete(int.Parse(dgvTasadof.Rows[e.RowIndex].Cells[clnId.Name].Value.ToString()));

                    FillDGV();

                }

            }

        }

        private void FillDGV()
        {
          dgvTasadof.DataSource=  _tc.GetAllForDGV();
        }

        private void dgvTasadof_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left && e.RowIndex > -1)
            {
                var t = _tc.Get(int.Parse(dgvTasadof.Rows[e.RowIndex].Cells[clnId.Name].Value.ToString()));
                Id = t.Id;
                txtPrice.Text = t.Price.ToString();
                cmbDriver.SelectedValue = t.DriverId;
                cmbPelak.SelectedValue = t.CarId;
                fdTasadofDate.Controls[1].Text = t.Tarikh;

            }

            
        }
    }
}
