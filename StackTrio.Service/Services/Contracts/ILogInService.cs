using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StackTrio.Model.DataModel;

namespace StackTrio.Service.Services.Contracts
{
    public interface ILogInService
    {
        Task<LogInStatus> Login(UserLoginDto model);
        Task<RegisterStatus> Register(UserRegistrationDto request);
    }
}
