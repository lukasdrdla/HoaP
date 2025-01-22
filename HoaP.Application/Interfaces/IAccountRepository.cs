using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.ViewModels.AppUser;
using HoaP.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace HoaP.Application.Interfaces
{
    public interface IAccountRepository
    {
        Task<SignInResult> LoginAsync(LoginViewModel model);

        Task<AppUser> GetCurrentUserAsync();

       

    }
}
