﻿using jhedgostBK.Model.Dtos.User;
using jhedgostBK.Modules.User.Application.Port;
using jhedgostBK.Modules.User.Domain.Entity;
using jhedgostBK.Modules.User.Domain.IRepository;

namespace jhedgostBK.Modules.User.Application.Adapter;

public class UserAdapter: IUserInputPort
{
    private readonly IUserRepository _userRepository;
    private readonly IUserOutPort _userOutPort;

    public UserAdapter(IUserRepository repository,IUserOutPort userOutPort)
    {
        _userRepository = repository;
        _userOutPort = userOutPort;
    }
    
     public async Task GetAllUsersAsync()
     {
         var users = await _userRepository.GetAllAsync<UserEntity>();

         if (!users.Any())
         {
             _userOutPort.NotFound("No users found.");
             return;
         }

         var userDtos = users.Select(user => new UserDto
         {
             Id = user.Id,
             FirstName = user.FirstName,
             LastName = user.LastName,
             Email = user.Email,
             BirthDate = user.BirthDate
         });
         
         _userOutPort.GetAllUsersAsync(userDtos);

     }
}