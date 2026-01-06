using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Pages.Adoptionrequests
{
    public class DeleteModel : PageModel
    {
        private readonly WebApplication2.Data.WebApplication2Context _context;

        public DeleteModel(WebApplication2.Data.WebApplication2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Adoptionrequest Adoptionrequest { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adoptionrequest = await _context.Adoptionrequest.FirstOrDefaultAsync(m => m.ID == id);

            if (adoptionrequest == null)
            {
                return NotFound();
            }
            else
            {
                Adoptionrequest = adoptionrequest;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adoptionrequest = await _context.Adoptionrequest.FindAsync(id);
            if (adoptionrequest != null)
            {
                Adoptionrequest = adoptionrequest;
                _context.Adoptionrequest.Remove(Adoptionrequest);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
