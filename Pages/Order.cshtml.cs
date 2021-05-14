using System;
using System.Threading.Tasks;
using Tool_Website.data;
using Tool_Website.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Tool_Website.Pages
{
    public class OrderModel: PageModel
    {
        private toolcontext db;
        public OrderModel(toolcontext db) => this.db = db;
        [BindProperty(SupportsGet =true)]
        public int Id { get; set; }
        public product Product { get; set;}
        [BindProperty, EmailAddress, Required, Display(Name="Your Email Address")]
        public string OrderEmail { get; set; }
        [BindProperty, Required(ErrorMessage="Please supply a shipping address"), Display(Name="Shipping Address")]
        public string OrderShipping { get; set; } 
        [BindProperty, Display(Name="Quantity")]
        public int OrderQuantity { get; set; } = 1;
        public async Task OnGetAsync() =>  Product = await db.Products.FindAsync(Id);
        
        public async Task<IActionResult> OnPostAsync()
        {
            Product = await db.Products.FindAsync(Id);
            if(ModelState.IsValid){
                return RedirectToPage("OrderSuccess");
            }
            return Page();
        }
    }
}
