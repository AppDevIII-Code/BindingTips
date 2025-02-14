using BindingTips.Views;

namespace BindingTips
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Btn_InfoPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InfoPage());
        }
    }

}
