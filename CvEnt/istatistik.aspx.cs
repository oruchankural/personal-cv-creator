﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEnt
{
    public partial class istatistik : System.Web.UI.Page
    {
        DBCVEntities db = new DBCVEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = db.TBLYETENEKLER.Count().ToString();
            Label2.Text = db.TBLILETISIM.Count().ToString();
            Label3.Text = db.TBLYETENEKLER.Average(x => x.DERECE).ToString();
            Label4.Text = db.TBLYETENEKLER.Max(x => x.DERECE).ToString();
            Label5.Text = db.TBLYETENEKLER.Max(x => x.YETENEK).ToString();

        }
    }
}