using BindingTips.Models;
using BindingTips.ViewModels;
using BindingTips.Views;

namespace BindingTips
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
       
        }

        private async void Btn_InfoPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InfoPage());
        }

    }

}
