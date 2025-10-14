using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewComponents.Portfolio
{
    public class PortfolioList:ViewComponent
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EFPortfolioDal());
        public IViewComponentResult Invoke()
        {
            var values = portfolioManager.TGetList();
            return View(values);
        }
    }
}
