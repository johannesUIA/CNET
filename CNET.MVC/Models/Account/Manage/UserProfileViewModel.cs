using System.ComponentModel.DataAnnotations;
using CNET.MVC.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CNET.MVC.DataAccess;

namespace CNET.MVC.Models.Account.Manage
{
    public class UserProfileViewModel : PageModel
    {
        public string Username { get; set; }

        [TempData] public string StatusMessage { get; set; }

        [BindProperty] public ManageController Input { get; set; }

        [Display(Name = "Phone number")] public string PhoneNumber { get; set; }
    }
}