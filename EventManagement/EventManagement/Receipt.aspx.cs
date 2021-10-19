using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using EventBusiness;
using EventManagementDataLayer;
using System.Data.SqlClient;

namespace EventManagementSystem
{
    public partial class Receipt : System.Web.UI.Page
    {
        BusinessLayerClass businessobj = new BusinessLayerClass();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            int user_id = Convert.ToInt32(Request.QueryString["User"]);
            DataTable dt = new DataTable();
            gvreceiptbooking.DataSource = businessobj.getBookingstatusBYID(user_id);
            gvreceiptbooking.DataBind();

        }

        protected void gvreceiptbooking_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int user_id = Convert.ToInt32(Request.QueryString["User"]);
            int booking_id = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "Cancel")
            {
                string qry = "update BookingStatus set status= 'Cancelled' where booking_id=" + booking_id;
                SqlConnection sqlConnection = new SqlConnection(@"Data Source = LAPTOP-TG0AKH7V\SQLEXPRESS; Initial Catalog = EventManagement; Integrated Security = True");
                SqlCommand sqlCommand = new SqlCommand(qry, sqlConnection);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                DataTable dt = new DataTable();
                dt = businessobj.getBookingstatusBYID(user_id);
                gvreceiptbooking.DataSource = dt;
                gvreceiptbooking.DataBind();

            }

        }

        protected void gvreceiptbooking_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gvreceiptbooking_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void gvreceiptbooking_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void gvreceiptbooking_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }
    }
}