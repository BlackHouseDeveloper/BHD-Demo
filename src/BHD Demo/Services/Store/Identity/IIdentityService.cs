using BHD_Demo.Models.Store.User;

namespace BHD_Demo.Services.Store.Identity;

public interface IIdentityService
{
    Task<bool> SignInAsync();

    Task<bool> SignOutAsync();

    Task<UserInfo> GetUserInfoAsync();

    Task<string> GetAuthTokenAsync();
}