using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace retailCrud
{
    public partial class Employees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            showData();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ID = txtid.Text;
            string fname = txtfname.Text;
            string lname = txtlname.Text;
            string gender = "";
            bool isChecked = Male.Checked;
            if (isChecked)
            {
                gender = Male.Text;
            }
            else
            {
                gender = Female.Text;
            }

            string dob = txtdob.Text;
            string cnic = txtcnic.Text;
            string desig = txtdesi.Text;
            string email = txtemail.Text;

            string qryin = "Insert into EmployeesData values ('" + ID + "','" + fname + "','" + lname + "','" + gender + "','" + dob + "','" + cnic + "','" + desig + "','" + email + "')";
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
            string qryse = "select * from EmployeesData ";

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
                string gender = "";
                bool isChecked = Male.Checked;
                if (isChecked)
                {
                    gender = Male.Text;
                }
                else
                {
                    gender = Female.Text;
                }

                string dob = txtdob.Text;
                string cnic = txtcnic.Text;
                string desig = txtdesi.Text;
                string email = txtemail.Text;

                string qryup = "Update EmployeesData SET " +
                     " EmployeesID='" + ID + "', FirstName='" + fname + "',LastName='" + lname + "',Gender='" + gender + "',DOB='" + dob + "',CNIC='" + cnic + "',Designation='" + desig + "',Email='" + email + "' where EmployeesID='" + ID + "'";

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
                string qrydel = "delete from EmployeesData where EmployeesID ='" + txtid.Text + "'";

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
                string qryse = "select * from EmployeesData where EmployeesID='" + txtid.Text + "'";

                dbCon db = new dbCon();
                DataTable dt = db.search(qryse);
                if (dt.Rows.Count > 0)
                {
                    showData();
                    //  txtfname.Text = dt.Rows[0]["FirstName"].ToString();
                    //  txtlname.Text = dt.Rows[0]["LastName"].ToString();
                    ////  string sqlDOB = dt.Rows[0]["DOB"].ToString();
                    //  //txtdob.Value = Convert.ToDateTime(sqlDOB);
                    //  txtdob.Text = dt.Rows[0]["DOB"].ToString();
                    //  txtcnic.Text = dt.Rows[0]["CNIC"].ToString();
                    //  txtdesi.Text = dt.Rows[0]["Designation"].ToString();
                    //  txtemail.Text = dt.Rows[0]["Email"].ToString();

                    //  testlabel.Text = "Record found";
                }

            }
            catch
            {
                testlabel.Text = "Record not found 404 Error...";
            }
        }
    }
}