using Microsoft.AspNetCore.Components;
using MyWebsite.Blazor.Controllers;

namespace MyWebsite.Blazor.Pages
{
    public class AboutBase : ComponentBase
    {
        protected string _name = string.Empty;
        protected string _title = string.Empty;
        protected string _email = string.Empty;
        protected string _github = string.Empty;
        protected string _resume = string.Empty;

        protected override Task OnInitializedAsync()
        {
            UserController user = new UserController();

            _name = user.LoadUser().Name;
            _title = user.LoadUser().Title;
            _email = user.LoadUser().Email;
            _github = user.LoadUser().Github;
            _resume = user.LoadUser().Resume;

            return base.OnInitializedAsync();
        }
    }
}
