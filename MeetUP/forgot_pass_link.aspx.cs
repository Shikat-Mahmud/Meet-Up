﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MeetUP
{
    public partial class forgot_pass_link : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] == null)
            {
                Response.Redirect("~/forgot_password.aspx");
            }
            else
            {
                txtemail.Text = Session["email"].ToString();
                //Response.Write(labeltext1.Text);
            }
        }

        protected void open_email_btn_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Session.Abandon();
            Response.Redirect("https://mail.google.com/mail/u/0/#inbox");
        }
    }
}