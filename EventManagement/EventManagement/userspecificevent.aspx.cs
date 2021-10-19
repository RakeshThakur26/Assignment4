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
    public partial class userspecificevent : System.Web.UI.Page
    {
        BusinessLayerClass businessobj = new BusinessLayerClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            int user_id = Convert.ToInt32(Request.QueryString["User"]);

            DataTable dt = new DataTable();
            dt = businessobj.GetEventsByID(user_id);
            gveventtable.DataSource = dt;
            gveventtable.DataBind();

        }

        protected void gveventtable_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void gveventtable_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void gveventtable_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }
    }
}