using Orchard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Allred.LimitLogin.Services
{

    public interface ILimitLoginService : IDependency
    {
        bool IsAccountLocked(string userName);
    }
    public class LimitLoginService : ILimitLoginService
    {
        public bool IsAccountLocked(string userName)
        {
            return true;
        }
    }
}