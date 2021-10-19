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
    public partial class food_order_details : System.Web.UI.Page
    {
        BusinessLayerClass businessobj = new BusinessLayerClass();
        FoodOrder foodobj = new FoodOrder();
        string dish = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtbookfood_Click(object sender, EventArgs e)
        {
            if(txtveg.Checked)
            {
                foodobj.food_type = txtveg.Text;
            }
            else
            {
                foodobj.food_type = txtnonveg.Text;
            }
            if (txtlunch.Checked)
            {
                foodobj.meal_type = txtlunch.Text;
            }
            else
            {
                foodobj.meal_type = txtdinner.Text;
            }
            if(txtSouthindian.Checked)
            {
                dish += txtSouthindian.Text;
            }
            if (txtNorthindian.Checked)
            {
                dish += txtNorthindian.Text;

            }
            if (txtpunjabi.Checked)
            {
                dish += txtpunjabi.Text;

            }
            foodobj.user_id = Convert.ToInt32(txtuseridfood.Text);
            foodobj.event_id = Convert.ToInt32(txteventidfood.Text);
            foodobj.dish_type = dish;
            string msg = businessobj.InsertFood(foodobj);
            Response.Write(msg);


        }

        protected void txtveg_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void txtnonveg_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void txtlunch_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void txtdinner_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void txtSouthindian_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void txtNorthindian_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void txtpunjabi_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void btnorderflowers_Click(object sender, EventArgs e)
        {
            Response.Redirect("Flowers.aspx");
        }
    }
}