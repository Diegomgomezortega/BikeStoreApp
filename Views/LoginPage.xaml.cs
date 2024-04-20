using BikeStoreApp.Models;
using BikeStoreApp.Services;
using BikeStoreApp.ViewModels;
using System.Windows.Input;

namespace BikeStoreApp.Views;

public partial class LoginPage : ContentPage
{
    public ICommand LoginCommand { get; set; }
    public LoginPage()
    {
        InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false); // Ocultar la barra de navegación
        LoginCommand = new Command(OnLoginButtonClicked);
        BindingContext = this;
    }
    public async void OnLoginButtonClicked()
    {
        // Aquí puedes realizar la lógica de inicio de sesión

        // Navegar a la página deseada después del inicio de sesión
        await Navigation.PushAsync(new HomePage());
    }
}