using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IMSystem
{
    public partial class Sample2 : Sample
    {
        public Sample2()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            HomeScreen hsObj = new HomeScreen();
            mainClass.showWindow(hsObj, this, MDI.ActiveForm);
        }

        public virtual void addBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void editBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void saveBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void delBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void textBoxSearchSampleTwo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
