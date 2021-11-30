using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsPS5Project.DataAccessLayer.Models;
using WinFormsPS5Project.DataAccessLayer.ViewModels;

namespace WinFormsPS5Project.DataAccessLayer
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<UserModel, User>().ReverseMap();
            CreateMap<GameModel, Game>().ReverseMap();
            CreateMap<CostModel, Cost>().ReverseMap();
            CreateMap<ContactModel, Contact>().ReverseMap();

        }
    }
}
