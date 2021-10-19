using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EventBusiness;

namespace EventManagementSystem
{
    public partial class UserInfo : System.Web.UI.Page
    {
        BusinessLayerClass businesobj = new BusinessLayerClass();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            lblnotification.Text = businesobj.notificationcount().ToString();
        }

        protected void txtnotification_Click(object sender, EventArgs e)
        {
            lblnotification.Text = businesobj.notificationcount().ToString();

        }

        protected void btnuserinfo_Click(object sender, EventArgs e)
        {

        }

        protected void btneventinfo_Click(object sender, EventArgs e)
        {

        }
    }
}