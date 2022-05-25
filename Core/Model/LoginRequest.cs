using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    public class LoginRequest
    {
        public int app { get; set; } = 2007;
        public LdapUserInfo ldapUser { get; set; }
    }
    public class LdapUserInfo
    {
        public string username { get; set; }
        public string password { get; set; }
    }
}
