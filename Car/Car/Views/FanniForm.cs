using System;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Transactions;
using System.Windows.Forms;
using Car.Controllers;
using Car.Infrastructure;
using Car.Models;
using Microsoft.VisualBasic;

namespace Car.Views
{
    public partial class FanniForm : Form
    {
        public FanniForm()
        {
            InitializeComponent();
        }
        FanniController _fc=new FanniController();
        FanniOperationController _foc=new FanniOperationController();
        private FanniOperationDetailController _fodc = new FanniOperationDetailController();
        private int Id { set; get; }


        private void FanniForm_Load(object sender, EventArgs e)
        {
            fdDate.GeoDate = DateTime.Now;
            dgvFanni.AutoGenerateColumns = false;
            FillFanni();
            FillPelak();
            FillDGV();
        }

        private void FillDGV()
        {
            dgvFanni.DataSource = _foc.GetAllForDGV();

        }


        private void FillPelak()
        {
            var cc = new CarController();
            cmbPelak.DataSource = cc.GetAll();
            cmbPelak.DisplayMember = "Pelak";
            cmbPelak.ValueMember = "Id";

        }
        private void FillFanni()
        {
            chklbOperation.DataSource = _fc.GetAll();
            chklbOperation.DisplayMember = "Name";
            chklbOperation.ValueMember = "Id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Information.IsNumeric(txtPrice.Text))
            {
                MessageBox.Show(Messages.Error_Mablagh);
            }
            else if (chklbOperation.CheckedItems.Count<1)
            {
                MessageBox.Show(Messages.Error_SelectOne);
            }
            else
            {
                using (var scope=new TransactionScope())
                {
                    try
                    {
                        var f = new FanniOperation
                        {

                            CarId = int.Parse(cmbPelak.SelectedValue.ToString()),
                            Description = txtDescription.Text,
                            Price = long.Parse(txtPrice.Text),
                            Tarikh = fdDate.Controls[1].Text

                        };

                        if (Id == 0)
                        {
                          _foc.Create(f);
                            

                            foreach (Fanni item in chklbOperation.CheckedItems)
                            {
                               
                                _fodc.Create(new FanniOperationDetail
                                {
                                    
                                    FanniId = item.Id,
                                    FanniOperationId = f.Id
                                });

                            }

                        }
                        else
                        {
                            f.Id = Id;
                            _foc.Update(f);
                            _fodc.DeleteByOperationId(f.Id);

                            foreach (Fanni item in chklbOperation.CheckedItems)
                            {
                                
                                _fodc.Create(new FanniOperationDetail
                                {

                                    FanniId =item.Id,
                                    FanniOperationId = f.Id
                                });

                            }
                            
                            Id = 0;
                        }

                        scope.Complete();
                        ClearValues();
                        FillDGV();
                    }
                    catch
                    {
                        scope.Dispose();

                    }


                }
               


            }
        }

        private void ClearValues()
        {
            txtPrice.Text = "";
            txtDescription.Text = "";
            fdDate.GeoDate = DateTime.Now;
        }

        private void dgvFanni_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right &&  MessageBox.Show("حذف شود؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
            {

                _foc.Delete(int.Parse(dgvFanni.Rows[e.RowIndex].Cells[clnId.Name].Value.ToString()));
                FillDGV();


            }
        }

        private void dgvFanni_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.RowIndex > -1)
            {
                int opId = int.Parse(dgvFanni.Rows[e.RowIndex].Cells[clnId.Name].Value.ToString());
                var m = _foc.Get(opId);
                txtDescription.Text = m.Description;
                txtPrice.Text = m.Price.ToString();
                fdDate.Controls[1].Text  = m.Tarikh;
                cmbPelak.SelectedValue = m.CarId;
                Id = m.Id;
                var lst = _fodc.GetByOperationId(opId);

               


                for (int i = 0; i < chklbOperation.Items.Count; i++)
                {

                    foreach (var item2 in lst)
                    {
                        if (item2.FanniId ==((Fanni) chklbOperation.Items[i]).Id)
                        {
                            chklbOperation.SetItemChecked(i, true);
                        }
                    }
                }
            

            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
