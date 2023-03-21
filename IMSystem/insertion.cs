using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace IMSystem
{
    class insertion
    {
        public void insertCust(string custName, string custPhone, string custAddress, string custTotalAmount, string custPaidAmount, string custRemAmount, string custArea, string custShop) 
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertCust", mainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", custName);
                cmd.Parameters.AddWithValue("@phone", custPhone);
                cmd.Parameters.AddWithValue("@address", custAddress);
                cmd.Parameters.AddWithValue("@t_amount", custTotalAmount);
                cmd.Parameters.AddWithValue("@p_amount", custPaidAmount);
                cmd.Parameters.AddWithValue("@rem_amount", custRemAmount);
                cmd.Parameters.AddWithValue("@area", custArea);
                cmd.Parameters.AddWithValue("@shop", custShop);

                mainClass.con.Open();
                cmd.ExecuteNonQuery();
                mainClass.con.Close();
                
                mainClass.ShowMSG($"{custName} added to the records successfully", "Success...", "Success");
            }
            catch(Exception ex)
            {
                mainClass.con.Close();
                mainClass.ShowMSG(ex.Message, "Error...", "Error");
            }
        }
    }
}
