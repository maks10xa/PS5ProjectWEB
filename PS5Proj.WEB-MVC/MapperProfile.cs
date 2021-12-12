using AutoMapper;
using PS5Proj.WEB_MVC.Models;
using WinFormsPS5Project.BuisenessLogicLayer.ViewModels;
using WinFormsPS5Project.DataAccessLayer.ViewModels;

namespace PS5Proj.WEB_MVC
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<UsersModel, UserModel>().ReverseMap();
            CreateMap<UserMVC, UsersModel>().ReverseMap();
            CreateMap<GamesModel, GameModel>().ReverseMap();
            CreateMap<GameMVC, GamesModel>().ReverseMap();
            CreateMap<ContactsModel, ContactModel>().ReverseMap();
            CreateMap<ContactMVC, ContactsModel>().ReverseMap();
            CreateMap<CostsModel, CostModel>().ReverseMap();
            CreateMap<CostMVC, CostsModel>().ReverseMap();
        }
    }
}
