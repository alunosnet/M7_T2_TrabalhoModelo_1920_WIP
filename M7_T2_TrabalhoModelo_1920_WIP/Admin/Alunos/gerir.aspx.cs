﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M7_T2_TrabalhoModelo_1920_WIP.Admin.Alunos
{
    public partial class gerir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //página para admin
            if (Session["perfil"] == null || Session["perfil"].Equals("0") == false)
                Response.Redirect("~/index.aspx");

        }
    }
}