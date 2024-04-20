using MauiIcons.Core;

namespace BikeStoreApp
{
    public partial class MainPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            // Temporary Workaround for url styled namespace in xaml
            _ = new MauiIcon();
        }

    }

}
