using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IMSystem
{
    public partial class Login : Sample
    { 
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            HomeScreen hs = new HomeScreen();
            mainClass.showWindow(hs, this, MDI.ActiveForm);
        }
    }
}
