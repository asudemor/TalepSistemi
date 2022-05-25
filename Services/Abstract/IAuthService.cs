using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface IAuthService
    {
        Task<BaseResponse<EmployeeResponse>> Login(LoginRequest request); 
    }
}
