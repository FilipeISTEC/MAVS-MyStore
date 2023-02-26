using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyStore
{
    public partial class CreateUser : Form
    {
        Code.Query_DB qdb = new Code.Query_DB();
        public CreateUser()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UEmail.Text = "";
            UMobile.Text="";
            UAddress.Text = "";
            UName.Text = "";
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
                String EMAIL = UEmail.Text;
                if (!qdb.CheckUser(EMAIL))
                  {
                    String NAME = UName.Text;
                    String ADDRESS = UAddress.Text;
                    String MOBILE = UMobile.Text;
                    String GENDER=" ";
                    if (UMale.Checked) { GENDER = "Masculino"; }
                    if (UFemale.Checked) { GENDER = "Feminino"; }
                    
                    if (qdb.CreateUser(EMAIL, NAME, MOBILE, ADDRESS, GENDER))
                    {
                        MessageBox.Show("Cliente criado");
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel criar este utilizador");
                    }
                }
                else {
                    MessageBox.Show("Este utilizador já existe");
                }
            }

        private void CreateUser_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
