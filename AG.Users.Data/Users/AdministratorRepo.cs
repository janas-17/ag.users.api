﻿using AG.Users.EFCore;
using AG.Users.EFCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AG.Users.Data.Users
{
    public class AdministratorRepo : ARepo<Administrator, UsersContext>
    {
        public AdministratorRepo(UsersContext context)
            : base(context)
        {

        }
    }
}
