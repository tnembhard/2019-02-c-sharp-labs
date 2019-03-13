using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab_27_Hello_World_Website
{
    public partial class LionPage : System.Web.UI.Page
    {
        static int counter = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            Label1.Test = $"You have clicked {counter.ToString()} times";
            counter++;
        }
    }
}