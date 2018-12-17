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
using Microsoft.VisualBasic;

namespace Car.Views
{
    public partial class FuelForm : Form
    {
        public FuelForm()
        {
            InitializeComponent();
        }
        public int Id { set; get; } = 0;
      
        private FuelController _fc =new FuelController();

        private void FuelForm_Load(object sender, EventArgs e)
        {
            dgvFuel.AutoGenerateColumns = false;

            FillPelak();
            FillDGV();
            FillFuel();
          
            
        }
        private void FillPelak()
        {
            var cc = new CarController();
            cmbPelak.DataSource = cc.GetAll();
            cmbPelak.DisplayMember = "Pelak";
            cmbPelak.ValueMember = "Id";

        }
        private void FillFuel()
        {
            var fc = new FuelTypeController();
            cmbFuelType.DataSource = fc.GetAll();
            cmbFuelType.DisplayMember = "Name";
            cmbFuelType.ValueMember = "Id";

        }
        private void FillDGV()
        {
          dgvFuel.DataSource = _fc.GetAllDGV();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFactorNumber .Text.Trim()))
            {
                MessageBox.Show(Messages.Error_Avarez_FillRahgiry);


            }
            else if (!Information.IsNumeric(txtPrice.Text))
            {
                MessageBox.Show(Messages.Error_Avarez_FillPrice);
            }else if (!Information.IsNumeric(txtKilometer.Text))
            {
                MessageBox.Show(Messages.Error_Fuel_FillKilometer);

            }
            else
            {
              MessageBox.Show(cmbFuelType.SelectedValue.ToString());
                var f = new Fuel
                {
                   FuelTypeId = int.Parse( cmbFuelType.SelectedValue.ToString() ),
                    FactorNumber = txtFactorNumber.Text ,
                    Kilometer = int.Parse(txtKilometer.Text ),
                    Mablagh = long.Parse(txtPrice.Text ),
                    TarikhPardakht = fdpPardakhtDate.Controls[1].Text ,
                    CarId = int.Parse(cmbPelak.SelectedValue.ToString()),
                    Deleted = false

                };

                if (Id == 0)
                {
                   _fc.Create(f);
                   
                }
                else
                {
                    f.Id = Id; 
                   _fc.Update(f);
                    Id = 0;

                }
                FillDGV();
             ClearValues();
            }
        }

        private void  ClearValues()
        {
            txtPrice.Clear();
            txtFactorNumber.Clear();
            txtKilometer.Clear();
            
            
        }

        private void dgvFuel_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.RowIndex > -1)
            {
                var f = _fc.Get(int.Parse(dgvFuel.Rows[e.RowIndex].Cells[clnId.Name].Value.ToString()));
                Id = f.Id;
                txtPrice.Text = f.Mablagh.ToString();
                txtFactorNumber.Text = f.FactorNumber;
                txtKilometer.Text = f.Kilometer.ToString();
                cmbPelak.SelectedValue = f.Car.Id;
                cmbFuelType.SelectedValue = f.FuelType.Id;
             
            }

        }

        private void dgvFuel_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > -1)
            {


                if (MessageBox.Show("حذف شود؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                {

                    _fc.Delete(int.Parse(dgvFuel.Rows[e.RowIndex].Cells[clnId.Name].Value.ToString()));

                    FillDGV();
               
                }




            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
