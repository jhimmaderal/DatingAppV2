using System;
using API.DTO;
using API.Entities;
using API.Interfaces;

namespace API.Extensions;

public static class AppUserExtensions
{
    public static UserDTO ToDto(this AppUser user, ITokenService tokenService)
    {
        return new UserDTO
        {
            Id = user.Id,
            DisplayName = user.DisplayName,
            Email = user.Email,
            ImageUrl = user.ImageUrl,
            Token = tokenService.CreateToken(user)
        };
    }
}
