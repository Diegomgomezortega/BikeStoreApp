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
        NavigationPage.SetHasNavigationBar(this, false); // Ocultar la barra de navegaci�n
        LoginCommand = new Command(OnLoginButtonClicked);
        BindingContext = this;
    }
    public async void OnLoginButtonClicked()
    {
        // Aqu� puedes realizar la l�gica de inicio de sesi�n

        // Navegar a la p�gina deseada despu�s del inicio de sesi�n
        await Navigation.PushAsync(new HomePage());
    }
}