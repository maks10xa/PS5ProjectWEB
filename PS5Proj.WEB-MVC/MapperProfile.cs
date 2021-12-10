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
            //CreateMap<UserModelDTO, UsersModel>().ReverseMap();
            CreateMap<UserMVC, UsersModel>().ReverseMap();
            CreateMap<GamesModel, GameModel>().ReverseMap();
            //CreateMap<GameModelDTO, GamesModel>().ReverseMap();
            CreateMap<GameMVC, GamesModel>().ReverseMap();
            CreateMap<ContactsModel, ContactModel>().ReverseMap();
            CreateMap<ContactModelDTO, ContactsModel>().ReverseMap();
            CreateMap<CostsModel, CostModel>().ReverseMap();
            //CreateMap<CostModelDTO, CostsModel>().ReverseMap();
            CreateMap<CostMVC, CostsModel>().ReverseMap();
        }
    }
}
