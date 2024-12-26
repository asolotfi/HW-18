﻿using HW_18.Domain.Entites;

namespace HW_18.Domain.Contract.Repositoris
{
    public interface IUserRepository
    {
        User GetUser(User user);
        bool Add(User user);
        bool Delete(User user);
        bool Edit(User user);
        bool Get(User user);
        bool GetAll();
    }
}

