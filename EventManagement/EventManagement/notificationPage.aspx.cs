using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using EventBusiness;
using System.Data.SqlClient;

namespace EventManagementSystem
{
    public partial class notificationPage : System.Web.UI.Page
    {
        BusinessLayerClass businessobj = new BusinessLayerClass();

        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = businessobj.GetBookings();
            gvnotification.DataSource = dt;
            gvnotification.DataBind();

        }

        protected void gvnotification_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int booking_id = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Approve")
            {
                string qry = "update BookingStatus set status= 'Approved' where status='pending' and booking_id=" + booking_id;
                SqlConnection sqlConnection = new SqlConnection(@"Data Source = LAPTOP-TG0AKH7V\SQLEXPRESS; Initial Catalog = EventManagement; Integrated Security = True");
                SqlCommand sqlCommand = new SqlCommand(qry, sqlConnection);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                DataTable dt = new DataTable();
                dt = businessobj.GetBookings();
                gvnotification.DataSource = dt;
                gvnotification.DataBind();

            }
            else if (e.CommandName == "Reject")
            {
                string qry = "update BookingStatus set status= 'Rejected' where status='pending' and booking_id=" +booking_id;
                SqlConnection sqlConnection = new SqlConnection(@"Data Source = LAPTOP-TG0AKH7V\SQLEXPRESS; Initial Catalog = EventManagement; Integrated Security = True");
                SqlCommand sqlCommand = new SqlCommand(qry, sqlConnection);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                DataTable dt = new DataTable();
                dt = businessobj.GetBookings();
                gvnotification.DataSource = dt;
                gvnotification.DataBind();


            }


        }

        protected void gvnotification_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void gvnotification_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }
    }
}