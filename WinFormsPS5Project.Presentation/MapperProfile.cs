﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using WinFormsPS5Project.BuisenessLogicLayer.ViewModels;
using WinFormsPS5Project.DataAccessLayer.Models;
using WinFormsPS5Project.DataAccessLayer.ViewModels;

namespace WinFormsPS5Project.Presentation
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<UsersModel, User>().ReverseMap();
            CreateMap<GamesModel, Game>().ReverseMap();
            CreateMap<ContactsModel, Contact>().ReverseMap();
            CreateMap<CostsModel, Cost>().ReverseMap();
        }
    }
}
