using System.Collections.Generic;
using WinFormsPS5Project.BuisenessLogicLayer.ViewModels;
using WinFormsPS5Project.Presentation.ModelServices.Interfaces;

namespace WinFormsPS5Project.Presentation.ModelServices
{
    public class CostPres : ICostPres
    {
        public List<CostsModel> Cost { get; set; }

        public CostPres()
        {
            Cost = new List<CostsModel>();
        }
    }
}
