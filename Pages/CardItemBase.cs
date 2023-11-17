using Microsoft.AspNetCore.Components;

namespace MyWebsite.Blazor.Pages
{
    public class CardItemBase : ComponentBase
    {
        [Parameter]
        public string _title { get; set; } = string.Empty;
        [Parameter]
        public string _description { get; set; } = string.Empty;
        [Parameter]
        public string _imagePath { get; set; } = string.Empty;
        [Parameter]
        public string _projectLink { get; set; } = string.Empty;
    }
}
