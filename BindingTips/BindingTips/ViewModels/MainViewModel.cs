using BindingTips.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace BindingTips.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        #region Interface implementation
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Observed Properties
        private Bill _bill = new Bill();
        public Bill Bill { 
            get => _bill;
            set
            {
                _bill = value;
                OnPropertyChanged(nameof(Bill));
            }
        }
        private Province _selectedProvince;
        public Province SelectedProvince
        {
            get => _selectedProvince;
            set
            {
                _selectedProvince = value;
                Bill.TaxRate = _selectedProvince.TaxRate;
                OnPropertyChanged(nameof(SelectedProvince));
            }
        }

        public double TipValueInput
        {
            get => (double)Bill.TipRate;
            set
            {
                Bill.TipRate = (decimal)Math.Round(value, 0);
                OnPropertyChanged(nameof(TipValueInput));
            }
        }
        public string AmountTextInput { 
            get => Bill.Amount.ToString();
            set
            {
                decimal totalAmount;
                if (decimal.TryParse(value, out totalAmount))
                {
                    Console.WriteLine($"{totalAmount} $");
                    Bill.Amount = totalAmount;
                    OnPropertyChanged(nameof(AmountTextInput));
                }
                else if(string.IsNullOrEmpty(value))
                {
                    Bill.Amount = 0m;
                    OnPropertyChanged(nameof(AmountTextInput));
                }
            }
        }
        #endregion

        #region Commands
        public ICommand IncreaseSplit { get; set; }
        public ICommand DecreaseSplit { get; set; }

        #endregion


        public MainViewModel()
        {

            IncreaseSplit = new Command(IncreaseExecute);
            DecreaseSplit = new Command(DecreaseExecute);
            Bill = new Bill();
        }

        #region Commands methods
  
   
        private void IncreaseExecute()
        {
            Bill.Split++;

        }

        private void DecreaseExecute()
        {
            Bill.Split--;

        }
        #endregion
    }
}
