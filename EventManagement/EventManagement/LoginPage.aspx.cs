using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EventBusiness;

namespace EventManagementSystem
{
    public partial class LoginPage : System.Web.UI.Page
    {
        BusinessLayerClass businessobj = new BusinessLayerClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtsubmit_Click(object sender, EventArgs e)
        {
            string emailid = txtloginemailid.Text;
            string password = txtloginpassword.Text;
            string msg = businessobj.ValidationUserLogin(emailid, password);
            
            if(msg.Equals("Success"))
            {
                int user_id = businessobj.GetUserID(emailid);
                Response.Redirect("EventBookingPage.aspx?User=" +user_id);
                
            }
            else
            {
                Response.Write("UserId & Password Is not correct Try again..!!");
            }

        }
    }
}