using MyWebsite.Blazor.Model;

namespace MyWebsite.Blazor.Controllers
{
    public class UserController
    {
        public User LoadUser()
        {
            User user = new User()
            {
                Name = "Dicky Dwi Darmawan",
                Title = "Game Developer | Unity Programmer",
                Email = "mailto:darmadicky17@gmail.com",
                Github = "https://github.com/ddky16",
                Resume = "https://docs.google.com/document/d/1xHU0WmagLukw00PvldAchckjETMJYN2mJTNSQ7Z-lFQ/edit?usp=sharing"
            };

            return user;
        }
    }
}
