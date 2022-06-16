using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodeBased4
{
    public partial class Headphones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {



                string[] str = new string[] { "Boat", "Beats", "Skull", "Sinn", "JBL" };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Image1.ImageUrl = "~/Images/" + str + ".JFIF";
            if (DropDownList1.Items.FindByText("Boat").Selected == true)
            {
                Label1.Text = "Price: 3,000/-";
            }
            else if (DropDownList1.Items.FindByText("Beats").Selected == true)
            {
                Label1.Text = "Price: 5,000/-";
            }
            else if (DropDownList1.Items.FindByText("Skull").Selected == true)
            {
                Label1.Text = "Price: 4,5000/-";
            }
            else if (DropDownList1.Items.FindByText("Sinn").Selected == true)
            {
                Label1.Text = "Price: 10,000 /-";
            }
            else
            {
                Label1.Text = "Price: 7,000/-";
            }
        }
    }
}