using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.Model;


namespace Service.Abstract
{
    public interface IAuthService
    {
        Task<CoreLayer.Model.BaseResponse<LoginResponse>> Login(LoginRequest request) 
    }
}
