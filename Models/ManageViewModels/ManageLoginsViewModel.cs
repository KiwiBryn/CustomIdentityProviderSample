﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// using Microsoft.AspNetCore.Http.Authentication; BHL
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;

namespace CustomIdentityProviderSample.Models.ManageViewModels
{
    public class ManageLoginsViewModel
    {
        //public IList<AuthenticationDescription> OtherLogins { get; set; } BHL
        public IList<UserLoginInfo> CurrentLogins { get; set; }

        // public IList<AuthenticationDescription> OtherLogins { get; set; } BHL
        public IList<AuthenticationScheme> OtherLogins { get; set; }
    }
}
