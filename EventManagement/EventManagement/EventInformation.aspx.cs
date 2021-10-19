using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EventBusiness;

namespace EventManagementSystem
{
    public partial class EventInformation : System.Web.UI.Page
    {
        BusinessLayerClass businessobj = new BusinessLayerClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = businessobj.GetEvents();
            gvEventInfo.DataSource = dt;
            gvEventInfo.DataBind();

        }

        protected void gvEventInfo_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void gvEventInfo_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void gvEventInfo_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
    }
}