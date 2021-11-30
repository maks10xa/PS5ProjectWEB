using AutoMapper;
using PS5Project.Web.MVC.Models;
using WinFormsPS5Project.BuisenessLogicLayer.ViewModels;
using WinFormsPS5Project.DataAccessLayer.ViewModels;

namespace WinFormsPS5Project.Presentation
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<UsersModel, UserModel>().ReverseMap();
            CreateMap<UserDTO, UsersModel>().ReverseMap();
            //CreateMap<GamesModel, GameModel>().ReverseMap();
            //CreateMap<GameViewModel, GamesModel>().ReverseMap();
            //CreateMap<ContactsModel, ContactModel>().ReverseMap();
            //CreateMap<ContactViewModel, ContactsModel>().ReverseMap();
            //CreateMap<CostsModel, CostModel>().ReverseMap();
            //CreateMap<CostViewModel, CostsModel>().ReverseMap();
        }
    }
}
