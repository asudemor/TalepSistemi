using Core.Model;
using Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Concrete
{
    public class AuthService : IAuthService
    {
        public Task<BaseResponse<EmployeeResponse>> Login(LoginRequest request)
        {
            request.ldapUser.username = "asude.mor";
        }

        //http://helper.mlpcare.com/api/auth/login
    }
}
