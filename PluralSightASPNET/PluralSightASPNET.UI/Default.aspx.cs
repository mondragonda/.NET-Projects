using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PluralSightASPNET.UI
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button btnLearnMore = (Button)FindControl("btnLearnMore");
            btnLearnMore.Text = "Aprender Más";
        }
    }
}