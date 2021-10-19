using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using EventBusiness;
using EventManagementDataLayer;
using Tulpep.NotificationWindow;

namespace EventManagementSystem
{
    public partial class UserRegistration : System.Web.UI.Page
    {
        BusinessLayerClass businesslayerobj = new BusinessLayerClass();
        UsersTable userdataobj = new UsersTable();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtusersubmit_Click(object sender, EventArgs e)
        {
            userdataobj.first_name = txtuserfirstname.Text;
            userdataobj.last_name = txtuserlastname.Text;
            userdataobj.email = txtuseremailid.Text;
            userdataobj.password = txtuserpassword.Text;
            userdataobj.phone = Convert.ToInt32(txtuserphone.Text);
            userdataobj.address = txtuseraddress.Text;
            string msg = businesslayerobj.InsertUser(userdataobj);
            //Response.Write(msg);
            PopupNotifier popup = new PopupNotifier();
            popup.TitleText = "Congrats";
            popup.ContentText = "Account has been created successfully";
            popup.Popup();
            Response.Redirect("LoginPage.aspx");


        }
    }
}