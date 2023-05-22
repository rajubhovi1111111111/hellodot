using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormDemo
{
    public partial class _Default : Page
    {
        //SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnect"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        

        //SqlConnection conn = new SqlConnection(strcon);
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
           
            var myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnect"].ConnectionString.ToString());
            
            {
                myConnection.Open();
               
                SqlCommand cmd = new SqlCommand("insert into Persons values(@Name,@Age,@Address)", myConnection);
                cmd.Parameters.AddWithValue("Name", TextBox1.Text);
                cmd.Parameters.AddWithValue("Age", TextBox2.Text);
                cmd.Parameters.AddWithValue("Address", TextBox3.Text);
                cmd.ExecuteNonQuery();

            }
            Table1.Visible = false;
            Label4.Text = "Thanks for submitting the details " + TextBox1.Text;
        }
    }
}