using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PlayYouTube : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // this is the YouTube Video ID, here you replace by 
        // the code of the one you want to show
        string VideoID = Request.QueryString["v"];

        // Here this code you show in the label the YouTube Video that you put the code
        LabelShowYouTubeVideo.Text = "<object width='425' height='355'><param name='movie' value='http://www.youtube.com/v/" + VideoID + "'></param><param name='wmode' value='transparent'></param><embed src='http://www.youtube.com/v/" + VideoID + "' type='application/x-shockwave-flash' wmode='transparent' width='425' height='355'></embed></object>";
    }
}