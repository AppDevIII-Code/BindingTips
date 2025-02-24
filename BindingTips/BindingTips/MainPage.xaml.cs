using BindingTips.Models;
using BindingTips.Views;

namespace BindingTips
{
    public partial class MainPage : ContentPage
    {
        public Bill Bill { get; set; } = new Bill();
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
       
        }

        private async void Btn_InfoPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InfoPage());
        }

        private void TipSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double tipRate = Math.Round(TipSlider.Value,0);
            Console.WriteLine($"{tipRate} %");
            Bill.TipRate = (decimal)tipRate;

        }

        private void TotalAmount_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            decimal totalAmount;
            if (decimal.TryParse(TotalAmountEntry.Text, out totalAmount))
            {
                Console.WriteLine($"{totalAmount} $");
                Bill.Amount = totalAmount;
            }   
        }

        private void ProvincesPicker_SelectionChanged(object sender, EventArgs e)
        {
            if(ProvincesPicker.SelectedItem != null)
            {
                var province = ProvincesPicker.SelectedItem as Province;
                Bill.TaxRate = province.TaxRate;
            }

        }

        private void Btn_DecrementSplit_Clicked(object sender, EventArgs e)
        {
            Bill.Split--;
        }

        private void Btn_IncrementSplit_Clicked(object sender, EventArgs e)
        {
            Bill.Split++;
        }
    }

}
