﻿using WebApplication1.DTO;

namespace WebApplication1.DataAccess
{
    public interface IAccountDataAccess
    {
        (string, UserDto) GetUserInfoByUserName(string username);
    }
}