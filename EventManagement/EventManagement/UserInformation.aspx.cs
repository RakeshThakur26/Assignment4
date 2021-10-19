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
    public partial class UserInformation : System.Web.UI.Page
    {
        BusinessLayerClass businessobj = new BusinessLayerClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = businessobj.GetUsers();
            gvuserinfo.DataSource = dt;
            gvuserinfo.DataBind();

        }

        protected void gvuserinfo_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void gvuserinfo_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void gvuserinfo_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }
    }
}