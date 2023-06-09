﻿using CommomLibrary.Dapper.Repository.interfaces;
using Dapper;
using System.Data;
using WebAPITemplete.DBContexts.Dapper;
using WebAPITemplete.Models.DTOs.DefaultDB;
using WebAPITemplete.Models.Entities.DefaultDB;
using WebAPITemplete.Services.interfaces;

namespace WebAPITemplete.Services
{
    public class UserService : IUserService
    {
        private readonly IDbConnection _dbConnection;

        public UserService(IBaseDapper<ProjectDBContext_Default> baseDapperDefault)
        {
            _dbConnection = baseDapperDefault.CreateConnection();
        }

        public Task CreateUser(User User)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUser(int UserSerialNum)
        {
            throw new NotImplementedException();
        }

        public async Task<UserDTO> GetUser(int UserSerialNum)
        {
            var sql = @"SELECT U.SerialNum,
                               U.UserID,
                               U.FirstName,
                               U.LastName,
                               R.RoleID,
                               R.RoleName
                        FROM [dbo].[User] U
                        INNER JOIN UserPasswordRecord UP ON U.SerialNum = UP.UserSerialNum AND UP.IsEnable = 1
                        LEFT JOIN Role R ON U.RoleID = R.RoleID AND R.IsEnable = 1
                        WHERE U.SerialNum = @UserSerialNum AND U.IsEnable = 1";
            return await _dbConnection.QuerySingleOrDefaultAsync<UserDTO>(sql, new { UserSerialNum });
        }

        public Task<List<UserDTO>> GetUsers()
        {
            throw new NotImplementedException();
        }

        public Task UpdateUser(User User)
        {
            throw new NotImplementedException();
        }
    }
}
