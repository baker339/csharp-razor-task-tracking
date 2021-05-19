using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Tasker.Pages
{
    public class CreateTask : PageModel
    {
        public void OnGet()
        {
            
        }

        [BindProperty]
        public Task NewTask { get; set; }

        public IActionResult OnPost()
        {
            return RedirectToPage("Index");
        }
    }
}