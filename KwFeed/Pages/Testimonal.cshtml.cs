using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KwFeed.Pages
{
    public class TestimonalModel : PageModel
    {
        private readonly ILogger<TestimonalModel> _logger;

        public TestimonalModel(ILogger<TestimonalModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}
