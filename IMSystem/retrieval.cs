using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IMSystem
{
    class retrieval
    {
        public void displayCust(DataGridView gv, DataGridViewColumn custIDGV, DataGridViewColumn custNameGV, DataGridViewColumn custPhnGV, DataGridViewColumn custAddressGV, DataGridViewColumn custTotalAmountGV, DataGridViewColumn custAmountPaidGV, DataGridViewColumn custRemAmountGV, DataGridViewColumn custAreaGV, DataGridViewColumn custShopGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getCust", mainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                custIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                custNameGV.DataPropertyName = dt.Columns["Name"].ToString();
                custPhnGV.DataPropertyName = dt.Columns["Phone"].ToString();
                custAddressGV.DataPropertyName = dt.Columns["Address"].ToString();
                custTotalAmountGV.DataPropertyName = dt.Columns["Total Amount"].ToString();
                custAmountPaidGV.DataPropertyName = dt.Columns["Amount Paid"].ToString();
                custRemAmountGV.DataPropertyName = dt.Columns["Remaining Amount"].ToString();
                custAreaGV.DataPropertyName = dt.Columns["Area"].ToString();
                custShopGV.DataPropertyName = dt.Columns["Shop"].ToString();

                gv.DataSource = dt;
            }
            catch (Exception)
            {

            }
        }
    }
}
