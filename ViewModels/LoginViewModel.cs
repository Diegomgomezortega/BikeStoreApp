using BikeStoreApp.Models;
using BikeStoreApp.Views;

namespace BikeStoreApp.ViewModels
{
    public class LoginViewModel
    {
        private List<User> UserCollection = new List<User>();
        public Command LoginCommand { get; set; }
        
        public LoginViewModel()
        {
            LoginCommand = new Command(SignIn);
            UserCollection = GetUserCollection(10);

        }
        public async static void SignIn()
        {
            //await Navigation.PushAsync(new HomePage());
        }

        public List<User> GetUserCollection(int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                var user = new User()
                {
                    Name = $"UserName {i.ToString()}",
                    Email = $"email{i.ToString()}@gmail.com",
                    Surname = $"UserName {i.ToString()}",
                    UserId = i,
                };
                UserCollection.Add(user);
            }
            return UserCollection;
        }
    }
}
