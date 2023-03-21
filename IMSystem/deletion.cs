using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace IMSystem
{
    class deletion
    {
        public void delete(object id, string proc, string param)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, mainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param, id);

                mainClass.con.Open();
                cmd.ExecuteNonQuery();
                mainClass.con.Close();
                mainClass.ShowMSG("Data deleted Successfully..", "Success..", "Success");
            }
            catch (Exception ex)
            {
                mainClass.con.Close();
                mainClass.ShowMSG(ex.Message, "Error...", "Error");
            }
        }
    }
}
