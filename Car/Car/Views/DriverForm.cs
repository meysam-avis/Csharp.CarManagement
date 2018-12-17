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
    public partial class DriverForm : Form
    {

        public DriverForm()
        {
            InitializeComponent();
        }
     private   Driver d = new Driver();
        private  DriverController dc = new DriverController();

        public  int Id { set; get; }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void FillDGV()
        {
            var dc = new DriverController();
            dgvCar.DataSource = dc.GetAll();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtName.Text.Trim()==string.Empty )
            {

            }
            else
            {
                
              

                d.CellPhone = txtCellphone.Text;
                d.MelliCode = txtMellicode.Text;
                d.Name = txtName.Text;

                if (Id == 0)
                {
                    dc.Create(d);
                }
                else
                {
                    d.Id = Id;
                    dc.Update(d);

                }

                FillDGV();

            }

       }

        private void DriverForm_Load(object sender, EventArgs e)
        {
            dgvCar.AutoGenerateColumns = false;
            FillDGV();
        }

      
        private void dgvCar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > -1)
            {


                if (MessageBox.Show("حذف شود؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                {

                    dc.Delete(int.Parse(dgvCar.Rows[e.RowIndex].Cells[clnId.Name].Value.ToString()));

                    FillDGV();

                }




            }

        }

        private void dgvCar_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left && e.RowIndex > -1)
            {
                var d2 = dc.Get(int.Parse(dgvCar.Rows[e.RowIndex].Cells[clnId.Name].Value.ToString()));
                Id = d2.Id;

                txtMellicode.Text = d2.MelliCode;
                txtCellphone.Text = d2.CellPhone;
                txtName.Text = d2.Name;


            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
