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
    public partial class BimehForm : Form
    {
        public BimehForm()
        {
            InitializeComponent();
        }
        public int Id { set; get; }

        BimehController bc =new BimehController();

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BimehForm_Load(object sender, EventArgs e)
        {
            dgvBimeh.AutoGenerateColumns = false;
            FillPelak();
            FillDGV();
            cmbBimehType.SelectedIndex = 0;
            fdpSodourDate.GeoDate = DateTime.Now;
            fdpEnghezaDate.GeoDate = DateTime.Now.AddYears(1);

        }

        private void FillPelak()
        {
            var cc = new CarController();
            cmbPelak.DataSource = cc.GetAll();
            cmbPelak.DisplayMember = "Pelak";
            cmbPelak.ValueMember = "Id";

        }

        private void FillDGV()
        {
         dgvBimeh.DataSource =   bc.GetAllDGV();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBimehName.Text.Trim() == string.Empty)
            {
                MessageBox.Show(Messages.Error_NewBimeh);
            }else if (! Information.IsNumeric(txtBimehPrice.Text ))
            {
                MessageBox.Show(Messages.Error_Mablagh);
            }
            else
            {
                var b=new Bimeh();
                b.CarId = int.Parse(cmbPelak.SelectedValue.ToString());
                b.Name = txtBimehName.Text;
                b.Price = long.Parse(  txtBimehPrice.Text);
                b.Shomareh = txtBimehNumber.Text;
                b.TarikhSodour = fdpSodourDate.Controls[1].Text;
                b.TarikhEngheza = fdpEnghezaDate.Controls[1].Text;
                b.Type=BimehType.ثالث;
                if (Id == 0)
                {
                    bc.Create(b);
                }
                else
                {
                    b.Id = Id;
                    bc.Update(b);
                    Id = 0;

                }

                FillDGV();
            }
        }

        private void dgvBimeh_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right && e.RowIndex > -1)
            {


                if (MessageBox.Show("حذف شود؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                {

                    bc.Delete(int.Parse(dgvBimeh.Rows[e.RowIndex].Cells[clnBimehId.Name].Value.ToString()));

                    FillDGV();

                }




            }



        }

        private void dgvBimeh_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            if (e.Button == MouseButtons.Left && e.RowIndex > -1)
            {
                var m = bc.Get(int.Parse(dgvBimeh.Rows[e.RowIndex].Cells[clnBimehId.Name].Value.ToString()));
                Id = m.Id;
                txtBimehName.Text = m.Name;
                txtBimehPrice.Text = m.Price.ToString();
                txtBimehNumber.Text = m.Shomareh;
                cmbPelak.SelectedValue = m.Car.Id;
                fdpSodourDate.Text  = m.TarikhSodour;
                fdpEnghezaDate.Text = m.TarikhEngheza;

            }



        }
    }
}
