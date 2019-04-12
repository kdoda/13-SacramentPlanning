﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using _13_Sacrament_Planning.Models;

namespace _13_Sacrament_Planning.Pages.Students
{
    public class DetailsModel : PageModel
    {
        private readonly _13_Sacrament_Planning.Models.SacramentPlanningContext _context;

        public DetailsModel(_13_Sacrament_Planning.Models.SacramentPlanningContext context)
        {
            _context = context;
        }

        public Hymn Hymn { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Hymn = await _context.Hymn.FirstOrDefaultAsync(m => m.ID == id);

            if (Hymn == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
