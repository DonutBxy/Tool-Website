using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tool_Website.data;
using Tool_Website.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Tool_Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly toolcontext db;  
        public IndexModel(toolcontext db) => this.db = db;
        public List<product> Products { get; set; } = new List<product>();  
        public product FeaturedProduct { get; set; }  
        public async Task OnGetAsync()
        {
            Products = await db.Products.ToListAsync();
            FeaturedProduct = Products.ElementAt(0);
        }
    }
}
