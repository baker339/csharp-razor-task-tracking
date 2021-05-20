using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Tasker.Pages
{
    public class Index : PageModel
    {
        public IEnumerable<Task> Tasks;
        private ApplicationDbContext _context;
        public Index(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Tasks = _context.Tasks.OrderBy(x => x.Priority);
        }
    }
}