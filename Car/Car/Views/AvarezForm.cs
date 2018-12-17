using System;
using System.Windows.Forms;
using Car.Controllers;
using Car.Infrastructure;
using Car.Models;

namespace Car.Views
{
    public partial class AvarezForm : Form
    {
        public AvarezForm()
        {
            InitializeComponent();
        }

        public int Id { set; get; } = 0;

        AvarezController  _ac= new AvarezController();

        private void AvarezForm_Load(object sender, EventArgs e)
        {
            cmbAvarezType.SelectedIndex = 0;
            dgvAvarez.AutoGenerateColumns = false;
            FillPelak();
            FillDGV();
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
            dgvAvarez.DataSource= _ac.GetAllDGV();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtRahgiry.Text.Trim()))
            {
                MessageBox.Show(Messages.Error_Avarez_FillRahgiry);


            }else if (string.IsNullOrEmpty(txtPrice.Text.Trim()))
            {
                MessageBox.Show(Messages.Error_Avarez_FillPrice);
            }
            else
            {

                var a = new Avarez
                {
                    AvarezType = (short)cmbAvarezType.SelectedIndex,
                    CarId = int.Parse(cmbPelak.SelectedValue.ToString()),
                    Price = long.Parse(txtPrice.Text),
                    Rahgiri = txtRahgiry.Text,
                    Tarikh = fdpPardakhtDate.Controls[1].Text,
                    Deleted = false
                };

                if (Id == 0)
                {
                    _ac.Create(a);

                }
                else
                {
                     a.Id = Id;
                    _ac.Update(a);
                }
                FillDGV();
                ClearValues();
            }
        }

        private void ClearValues()
        {
            Id = 0;
            txtPrice.Clear();
            txtRahgiry.Clear();
            fdpPardakhtDate.GeoDate = DateTime.Now;
            cmbAvarezType.SelectedIndex = 0;

        }

        private void dgvAvarez_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > -1)
            {
                if (MessageBox.Show("حذف شود؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                {

                    _ac.Delete(int.Parse(dgvAvarez.Rows[e.RowIndex].Cells[clnId.Name].Value.ToString()));
                    FillDGV();


                }
            }

        }

        private void dgvAvarez_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.RowIndex > -1)
            {
                var m = _ac.Get(int.Parse(dgvAvarez.Rows[e.RowIndex].Cells[clnId.Name].Value.ToString()));
                fdpPardakhtDate.Text = m.Tarikh;
                txtPrice.Text = m.Price.ToString();
                txtRahgiry.Text = m.Rahgiri;
                cmbPelak.SelectedValue = m.Car.Id;
                cmbAvarezType.SelectedIndex = m.AvarezType;
               Id = m.Id;

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
