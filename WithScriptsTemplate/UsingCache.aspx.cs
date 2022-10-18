using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WithScriptsTemplate
{
    public partial class UsingCache : System.Web.UI.Page
    {
        List <string> names =new List <string> ();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                names.Add("Meena");
                names.Add("Teena");
                ListBox1.DataSource = names;
                ListBox1.DataBind();

                ViewState["list"] = names;
                Cache.Insert("list",names);


            }

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            names = (List<string>)ViewState["list"];
            names = (List<string>)Cache.Get("list"); 
            names.Add(TextBox1.Text);

            ListBox1.DataSource = names;
            ListBox1.DataBind();

            ViewState["names"] = names;
            Cache.Insert("list", names);

        }
    }
}