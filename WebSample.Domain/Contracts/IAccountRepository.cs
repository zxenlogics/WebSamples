﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WebSample.Models;

namespace WebSample.Domain.Contracts
{
    public interface IAccountRepository
    {
        List<UserProfile> GetUsers();
    }
}
