using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsPS5Project.BuisenessLogicLayer.ViewModels;

namespace WinFormsPS5Project.Presentation.ModelServices.Interfaces
{
    interface ICostPres
    {
        List<CostsModel> Cost { get; set; }
    }
}
