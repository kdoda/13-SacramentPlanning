﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using _13_Sacrament_Planning.Models;

namespace _13_Sacrament_Planning.Pages.Members
{
    public class CreateModel : PageModel
    {
        private readonly _13_Sacrament_Planning.Models.SacramentPlanningContext _context;

        public CreateModel(_13_Sacrament_Planning.Models.SacramentPlanningContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Member Member { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Member.Add(Member);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}