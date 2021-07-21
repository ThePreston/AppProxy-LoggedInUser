using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Microsoft.AppProxyWindows.Web.Models
{
    public class UserInfo
    {
        public List<Claim> claim { get; set; }

        public string JSON { get; set; }

    }
}
