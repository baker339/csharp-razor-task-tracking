using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Tasker.Pages
{
    public class CreateTaskModel : PageModel
    {
        private ApplicationDbContext _context;
        public CreateTaskModel(ApplicationDbContext context)
        {
            _context = context;
        }
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