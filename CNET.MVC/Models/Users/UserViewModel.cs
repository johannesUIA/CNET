using CNET.MVC.Entities;
using CNET.MVC.Repositories;

namespace CNET.MVC.Models.Users
{
    public class UserViewModel
    {
        public string Name { get; set; }
      
        public string Email { get; set; }

        public List<UserEntity> Users { get; set; }
        
        public bool IsAdmin { get; set; }
    }
}