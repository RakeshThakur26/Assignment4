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
    
    public partial class Flowers : System.Web.UI.Page
    {
        int cost = 0;
        FlowerOrder flowerobj = new FlowerOrder();
        FoodOrder foodobj = new FoodOrder();
        BusinessLayerClass businessobj = new BusinessLayerClass();
        string name = "";

        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void txtheckboxrose_CheckedChanged(object sender, EventArgs e)
        {
            
            
                


        }

        protected void txtsubmitflowers_Click(object sender, EventArgs e)
        {
            if (txtheckboxrose.Checked)
            {
                cost += Convert.ToInt32(txtrosecost.Text);
                name += "Rose";

            }
            if (txtselectmarigold.Checked)
            {
                cost += Convert.ToInt32(txtmarigoldcost.Text);
                name += ", Marigold";
            }
            flowerobj.event_id = Convert.ToInt32(txteventidflowers.Text);
            flowerobj.user_id = Convert.ToInt32(txtuseridflowers.Text);
            flowerobj.flower_cost = cost;
            flowerobj.flower_name = name;
             businessobj.InsertFlowers(flowerobj);
            
            string msg = businessobj.ConfirmBooking(Convert.ToInt32(txtuseridflowers.Text), Convert.ToInt32(txteventidflowers.Text));
            Response.Write(msg);
            Response.Redirect("Receipt.aspx");
            

        }

        protected void txtselectmarigold_CheckedChanged(object sender, EventArgs e)
        {
            


        }
    }
}