using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SICOD
{
    public partial class FrmLogin : Form
    {
        public FrmLogin( )
        {
            InitializeComponent();
        }

        private void btnEntrar_Click( object sender, EventArgs e )
        {
            bool logar = true;

            if (logar)
            {
                FrmMain main = new FrmMain();
                main.Show();
                this.Hide();
            }
        }
    }
}
