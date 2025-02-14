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

        private void TipSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Math.Round(TipSlider.Value);
        }

        private void TotalAmount_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            double totalAmount;
            if (double.TryParse(TotalAmountEntry.Text, out totalAmount))
            {
                Console.WriteLine(totalAmount);
            }   
        }
    }

}
