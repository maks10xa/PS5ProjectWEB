using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SimpleInjector;
using SimpleInjector.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsPS5Project.BuisenessLogicLayer.Services;
using WinFormsPS5Project.BuisenessLogicLayer.Services.Interfaces;
using WinFormsPS5Project.DataAccessLayer.Models;
using WinFormsPS5Project.DataAccessLayer.Repositories;
using WinFormsPS5Project.DataAccessLayer.Repositories.Interfaces;
using WinFormsPS5Project.Presentation.ModelServices;
using WinFormsPS5Project.Presentation.ModelServices.Interfaces;

namespace WinFormsPS5Project.Presentation
{
    public static class DependencyInjections
    {
        public static Container Bootstrap()
        {
            var container = new Container();

            container.Register<IUserAccaunt, UserAccount>(Lifestyle.Singleton);
            container.Register<IUserService, UserService>();
            container.Register<IGameService, GameService>(); 


            container.Register(() =>
            {
                var options = new DbContextOptionsBuilder<PS5ProjContext>().UseSqlServer("Server=localhost;Database=PS5Proj;Trusted_Connection=True;").Options;
                return new PS5ProjContext(options);
            }, Lifestyle.Singleton);

            container.Register<IUserRepo, UserRepo>();
            container.Register<IGameRepo, GameRepo>();

            AutoRegisterWindowsForms(container);

            container.Register<MapperProvider>();
            container.RegisterSingleton(() => GetMapper(container));
            container.Verify();

            return container;

        }

        private static void AutoRegisterWindowsForms(Container container)
        {
            var types = container.GetTypesToRegister<Form>(typeof(Program).Assembly);

            foreach (var type in types)
            {
                var registration =
                    Lifestyle.Transient.CreateRegistration(type, container);

                registration.SuppressDiagnosticWarning(
                    DiagnosticType.DisposableTransientComponent,
                    "Forms should be disposed by app code; not by the container.");

                container.AddRegistration(type, registration);
            }
        }

        private static IMapper GetMapper(Container container)
        {
            var mp = container.GetInstance<MapperProvider>();
            return mp.GetMapper();
        }

        //private static void RegisterForm<TForm>(this Container container) where TForm : Form
        //{
        //    var registration = Lifestyle.Transient.CreateRegistration<TForm>(container);
        //    registration.SuppressDiagnosticWarning(DiagnosticType.DisposableTransientComponent, "Done manually.");
        //    container.AddRegistration<TForm>(registration);
        //}
    }
}

