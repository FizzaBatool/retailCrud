using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace retailCrud
{
    public partial class Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtquan_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ID = txtid.Text;
            string pname = txtpname.Text;
            string quantity = txtquan.Text;
            string price = txtprice.Text;
            string expiry = txtexp.Text;
            string suppID = txtsppID.Text;

            string qryin = "Insert into ProductsData values ('" + ID + "','" + pname + "','" + quantity + "','" + price + "','" + expiry + "','" + suppID + "')";
            dbCon db = new dbCon();
            bool check = db.UDI(qryin);
            if (check == true)
            {
                testlabel.Text = "Successfully inserted";
                showData();
            }
            else
            {
                testlabel.Text = "Error occurred while inserting...";
            }

        }
        public void showData()
        {
            string qryse = "select * from SuppliersData ";

            dbCon db = new dbCon();
            DataTable dt = db.search(qryse);
            if (dt.Rows.Count > 0)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }

        }

        protected void BTNsearch_Click(object sender, EventArgs e)
        {

            try
            {
                string qryse = "select * from SuppliersData where SuppliersID='" + txtid.Text + "'";

                dbCon db = new dbCon();
                DataTable dt = db.search(qryse);
                if (dt.Rows.Count > 0)
                {
                    showData();
                    //  txtfname.Text = dt.Rows[0]["FirstName"].ToString();
                   
                }

            }
            catch
            {
                testlabel.Text = "Record not found 404 Error...";
            }
        }
    }
}