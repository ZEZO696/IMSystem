using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IMSystem
{
    public partial class Customers : Sample2
    {
        int edit = 0;
        int custID;
        public Customers()
        {
            InitializeComponent();
        }
        retrieval rObj = new retrieval();

        private void Customers_Load(object sender, EventArgs e)
        {
            mainClass.disable_reset(leftPanel);
            rObj.displayCust(dataGridView1, custIDGV, custNameGV, custPhnGV, custAddressGV, custTotalAmountGV, custAmountPaidGV, custRemAmountGV, custAreaGV, custShopGV);
        }
        public override void addBtn_Click(object sender, EventArgs e)
        {
            mainClass.enable_reset(leftPanel);
            edit = 0;
        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            mainClass.enable(leftPanel);
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (textBoxCustName.Text == "") { nameErrLbl.Visible = true; } else { nameErrLbl.Visible = false; }
            if (textBoxCustName.Text == "") { nameErrLbl.Visible = true; } else { phnErrLbl.Visible = false; }
            if (textBoxCustName.Text == "") { nameErrLbl.Visible = true; } else { totalAmountErrLbl.Visible = false; }
            if (textBoxCustName.Text == "") { nameErrLbl.Visible = true; } else { amountPaidErrLbl.Visible = false; }
            if (textBoxCustName.Text == "") { remAmountErrLbl.Visible = true; } else { remAmountErrLbl.Visible = false; }
            
            if(nameErrLbl.Visible || phnErrLbl.Visible || totalAmountErrLbl .Visible || amountPaidErrLbl.Visible || remAmountErrLbl.Visible)
            {
                mainClass.ShowMSG("Fields with * are mandatory", "Stop", "Error");
            }
            else
            {
                if (edit == 0)
                {
                    insertion i = new insertion();
                    i.insertCust(textBoxCustName.Text, textBoxCustPhn.Text, textBoxCustAddress.Text,textBoxCustTotalAmount.Text,textBoxCustAmountPaid.Text,textBoxCustRemAmount.Text, textBoxCustArea.Text, textBoxCustShop.Text);
                    rObj.displayCust(dataGridView1, custIDGV, custNameGV, custPhnGV, custAddressGV, custTotalAmountGV, custAmountPaidGV, custRemAmountGV, custAreaGV, custShopGV);
                }
                if (edit == 1)
                {
                    updation u = new updation();
                    u.updateCust(custID,textBoxCustName.Text, textBoxCustPhn.Text, textBoxCustAddress.Text, textBoxCustTotalAmount.Text, textBoxCustAmountPaid.Text, textBoxCustRemAmount.Text, textBoxCustArea.Text, textBoxCustShop.Text);
                    rObj.displayCust(dataGridView1, custIDGV, custNameGV, custPhnGV, custAddressGV, custTotalAmountGV, custAmountPaidGV, custRemAmountGV, custAreaGV, custShopGV);
                }
            }
        }

        public override void delBtn_Click(object sender, EventArgs e)
        {

        }

        public override void textBoxSearchSampleTwo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                custID = Convert.ToInt32(row.Cells["custIDGV"].Value.ToString());
                textBoxCustName.Text = row.Cells["custNameGV"].Value.ToString();
                textBoxCustPhn.Text = row.Cells["custPhnGV"].Value.ToString();
                textBoxCustAddress.Text = row.Cells["custAddressGV"].Value.ToString();
                textBoxCustTotalAmount.Text = row.Cells["custTotalAmountGV"].Value.ToString();
                textBoxCustAmountPaid.Text = row.Cells["custAmountPaidGV"].Value.ToString();
                textBoxCustRemAmount.Text = row.Cells["custRemAmountGV"].Value.ToString();
                textBoxCustArea.Text = row.Cells["custAreaGV"].Value.ToString();
                textBoxCustShop.Text = row.Cells["custShopGV"].Value.ToString();

                mainClass.disable(leftPanel);
            }
        }    }
}
