using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_Test
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public string MyProperty { get; set; }
        public int MyProperty2 { get; set; }
        public float gaming { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            MyProperty = "Hello, World!";
            MyProperty2 = 42;
            gaming = 3.14f;
            if (IsPostBack)
            {
                MyProperty = Request.Form["MyProperty"];
                MyProperty2 = int.Parse(Request.Form["MyProperty2"]);
                gaming = float.Parse(Request.Form["gaming"]);
            }




        }
    }
}