﻿using WinFormsPS5Project.DataAccessLayer.Models;

namespace WinFormsPS5Project.DataAccessLayer.Repositories.Interfaces
{
    public interface IContactRepo
    {
        Contact GetAdmin(int id);
    }
}
