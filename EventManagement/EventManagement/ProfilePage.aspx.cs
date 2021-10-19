using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EventBusiness;
using System.Data;

namespace EventManagementSystem
{
    public partial class ProfilePage : System.Web.UI.Page
    {
        BusinessLayerClass businessobj = new BusinessLayerClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            int user_id = Convert.ToInt32(Request.QueryString["User"]);
            DataTable dt = businessobj.GetUsersByID(user_id);
            lblname.Text = dt.Rows[0][1].ToString() + " " + dt.Rows[0][2].ToString();
            lblemail.Text = dt.Rows[0][3].ToString();
            lblphone.Text = dt.Rows[0][5].ToString();
            lbladdress.Text = dt.Rows[0][6].ToString();



        }

        protected void btnevents_Click(object sender, EventArgs e)
        {
            int user_id = Convert.ToInt32(Request.QueryString["User"]);
            Response.Redirect("userspecificevent.aspx?User=" + user_id);
        }
    }
}