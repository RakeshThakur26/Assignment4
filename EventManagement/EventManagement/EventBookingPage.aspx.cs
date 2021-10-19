using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EventBusiness;
using EventManagementDataLayer;

namespace EventManagementSystem
{
    public partial class EventBookingPage : System.Web.UI.Page
    {
        BusinessLayerClass businessobj = new BusinessLayerClass();
        eventmngmtdatalayer datalayerobj = new eventmngmtdatalayer();
        EventsTable eventsobj = new EventsTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtbookingdate.Text = Calendar1.SelectedDate.ToString("yyyy-MM-dd");
            Calendar1.Visible = false;
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if(e.Day.IsOtherMonth)
            {
                e.Day.IsSelectable = false;
                e.Cell.BackColor = System.Drawing.Color.Black;
            }
        }

        protected void txtsubmitbooking_Click(object sender, EventArgs e)
        {

            eventsobj.event_type = droplistEventType.SelectedValue;
            eventsobj.guests = Convert.ToInt32(txtnumberofguest.Text);
            eventsobj.book_date = Convert.ToDateTime(txtbookingdate.Text);
            eventsobj.user_id = Convert.ToInt32(txtuserid.Text);
            string msg = businessobj.InsertEvents(eventsobj);
            Response.Redirect("food_order_details.aspx");

        }

        protected void lbtnprofile_Click(object sender, EventArgs e)
        {
            int user_id = Convert.ToInt32(Request.QueryString["User"]);
            Response.Redirect("ProfilePage.aspx?User="+user_id);
        }

        protected void lbtnbookingstatus_Click(object sender, EventArgs e)
        {
            int user_id = Convert.ToInt32(Request.QueryString["User"]);
            Response.Redirect("Receipt.aspx?User=" + user_id);
        }
    }
}