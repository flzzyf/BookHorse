﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Web_User_Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
    {
        //Roles.AddUserToRole(CreateUserWizard1.UserName, "member");
        Roles.AddUserToRole(CreateUserWizard1.UserName, "admin");
    }
}