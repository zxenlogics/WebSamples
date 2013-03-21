using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WebSample.Domain.Contracts;
using WebSample.Domain.Repositories;
using WebSample.Models;

namespace WebSample.Domain.Repositories
{
    public class AccountRepository : IAccountRepository
    {

        public List<UserProfile> GetUsers()
        {
            WebSampleDb db = new WebSampleDb();
            return db.UserProfiles.Where(a => a.UserName == a.UserName).ToList();

        }
    }
}
