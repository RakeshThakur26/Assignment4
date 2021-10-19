using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EventBusiness;

namespace EventManagementSystem
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        BusinessLayerClass businessobj = new BusinessLayerClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtadminsubmit_Click(object sender, EventArgs e)
        {
            string username = txtadminloginid.Text;
            string password = txtadminpassword.Text;
            string msg = businessobj.ValidationAdminLogin(username, password);

            if (msg.Equals("Success"))
            {
                Response.Redirect("AdminAccess.aspx");
                

            }
            else
            {
                Response.Write("UserId & Password Is not correct Try again..!!");
            }

        }
    }
}