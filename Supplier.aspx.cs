using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace retailCrud
{
    public partial class Supplier : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string ID = txtid.Text;
            string fname = txtfname.Text;
            string lname = txtlname.Text;
            string prodID = txtproID.Text;
            string quantity = txtquan.Text;
            string delDate = txtdeldate.Text;
            string address = txtadd.Text;
            string phone = txtphone.Text;

            string qryin = "Insert into SuppliersData values ('" + ID + "','" + fname + "','" + lname + "','" + prodID + "','" + quantity + "','" + delDate + "','" + address + "','" + phone + "')";
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

        protected void BTNupdate_Click(object sender, EventArgs e)
        {
            try
            {

                string ID = txtid.Text;
                string fname = txtfname.Text;
                string lname = txtlname.Text;
                string prodID = txtproID.Text;
                string quantity = txtquan.Text;
                string delDate = txtdeldate.Text;
                string address = txtadd.Text;
                string phone = txtphone.Text;

                string qryup = "Update SuppliersData SET " +
                     " EmployeesID='" + ID + "', FirstName='" + fname + "',LastName='" + lname + "',ProductID='" + prodID + "',Quantity='" + quantity + "',DeliveryDate='" + delDate + "',Address='" + address + "',PhoneNo='" + phone + "' where SuppliersID='" + ID + "'";

                dbCon db = new dbCon();
                bool check = db.UDI(qryup);
                if (check == true)
                {
                    testlabel.Text = "Successfully updated";
                }
            }
            catch
            {
                testlabel.Text = "Error occurred while updating...";
            }
        }

        protected void BTNdelete_Click(object sender, EventArgs e)
        {
            // string ID = txtid.Text;
            try
            {
                string qrydel = "delete from SuppliersData where SuppliersID ='" + txtid.Text + "'";

                dbCon db = new dbCon();
                bool check = db.UDI(qrydel);
                if (check == true)
                {
                    testlabel.Text = "Successfully deleted";
                }
            }
            catch
            {
                testlabel.Text = "Error occurred while deleting...";
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