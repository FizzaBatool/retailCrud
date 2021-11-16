using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace retailCrud
{
    public class dbCon
    {
        SqlConnection sqlcon;
        SqlDataAdapter sda;
        DataTable dt;
        public dbCon()
        {

            //string constr = @"Data Source=CS-LAB2-102\NUMLCS;Initial Catalog=fizza2136;Integrated Security=True";
            string constr = @"Data Source=DESKTOP-138QU5L;Initial Catalog=crudOperations;Integrated Security=True";
            sqlcon = new SqlConnection(constr);
        }
        public bool UDI(string qry)
        {
            sqlcon.Open();

            SqlCommand cmd = new SqlCommand(qry, sqlcon);
            bool check = cmd.ExecuteNonQuery() > 0;

            sqlcon.Close();

            return check;

        }
        public DataTable search(string qry)
        {
            //sqlcon.Open();

            sda = new SqlDataAdapter(qry, sqlcon);
            dt = new DataTable();
            sda.Fill(dt);

            //sqlcon.Close();

            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            return null;
        }
        public DataTable showRecord(string qry)
        {
            // sqlcon.Open();
            sda = new SqlDataAdapter(qry, sqlcon);
            dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            return null;
            //  sqlcon.Close();

        }
    }
}