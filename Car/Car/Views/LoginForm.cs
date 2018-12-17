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
using Car.Extensions;
using Car.Infrastructure;
using Car.Models;
using Car.Shared;

namespace Car.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            var uc = new UserController();
            var u = uc.Get(txtMellicode.Text, txtPassword.Text);
            if (u != null)
            {
                Program.User = u;
                
                Shared.Registery.SetStringKeys("mellicode", txtMellicode.Text);

                Common.SetUserActivity(UserActivityType.Login, u.MelliCode + ":" + DateTime.Now.GetPersianDateTime());
                uc.UpdateLoginDate(u.Id);
                this.DialogResult = DialogResult.OK;
               
            }
            else
            {
                
                MessageBox.Show(Messages.Error_Login);
            }


        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

            if (Registery.GetConnectionString()=="")
            {
               Registery.SetConncetionString(Cryptography.Encrypt(Program.ConnectionString, Program.AesKey));
            }
          
            txtMellicode.Text = Registery.GetStringKeys("MelliCode");
            txtPassword.Select();

            lblVersion.Text = Program.Version;

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
