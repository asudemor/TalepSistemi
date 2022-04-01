using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Concrate
{
    public class AuthService:IAuthService
    {
        private readonly IHttpClientFactory httpClientFactory;
        public AuthService(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        //public async Task<BaseResponse<LoginResponse>> Login(LoginRequest loginRequest)
        //{
        //    var client = httpClientFactory.CreateClient("Login");
        //}
    }
}
