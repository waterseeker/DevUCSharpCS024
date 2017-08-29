using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevUCSharpCS_ASP_024
{
    public partial class Default : System.Web.UI.Page
    {
        string z = ""; //since this is declared at the class level, all the other code in the class 
        //can access it. it can reach out, but not in. 
        protected void Page_Load(object sender, EventArgs e)
        {
            z += "Hello ";
        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            z += "Bob ";

            if (true)
            {
                z += "Tabor!";
            }
            int x = 1;
            if (x == 1)
            {
                x = 2;
                int y = 3;
            }

            string result = x.ToString();
            //string result = y.ToString(); // can't access y because it's not in scope here. 
            resultLabel.Text = z;
        }
    }
}