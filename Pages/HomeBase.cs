using Microsoft.AspNetCore.Components;
using MyWebsite.Blazor.Controllers;
using MyWebsite.Blazor.Model;

namespace MyWebsite.Blazor.Pages
{
    public class HomeBase : ComponentBase
    {
        protected PortfolioController portfolio = new PortfolioController();
        protected List<Portfolio> portfolioList = new List<Portfolio>();

        protected override Task OnInitializedAsync()
        {
            portfolio.SetPortfolio();
            portfolioList = portfolio.GetPortfolios;
            return base.OnInitializedAsync();
        }
    }
}
