using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Pages.Members
{
    public class IndexModel : PageModel
    {
        private readonly PetIdentityContext _identityContext;

        public IndexModel(PetIdentityContext identityContext)
        {
            _identityContext = identityContext;
        }

        public IList<Member> Member { get; set; } = default!;

        public async Task OnGetAsync()
        {
            // Luăm utilizatorii din sistemul de Login (Identity)
            var identityUsers = await _identityContext.Users.ToListAsync();

            // Îi transformăm în lista de "Member" pe care o așteaptă pagina ta
            Member = identityUsers.Select(u => new Member
            {
                // Mapăm ID-ul (atenție, Identity are ID string, Member are probabil int sau string)
                // Dacă ID-ul tău e int, folosim un contor sau ignorăm ID-ul pentru afișare simplă
                Email = u.Email,
                Name = u.UserName, // Folosim UserName ca nume implicit
                Phone = u.PhoneNumber ?? "Fără telefon",
                City = "Nespecificat" // Identity nu reține orașul implicit
            }).ToList();
        }
    }
}