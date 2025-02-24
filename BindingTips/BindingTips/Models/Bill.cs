
using System.ComponentModel;



namespace BindingTips.Models
{

    public class Bill : INotifyPropertyChanged
    {
        decimal MIN_TIP_RATE = 0;
        decimal MAX_TIP_RATE = 100;
        decimal MAX_TAX_RATE = 100;
        decimal MIN_TAX_RATE = 0;

        // Implementing the interface
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        // Calculated properties
        public decimal TipAmount { get => (TipRate / MAX_TIP_RATE) * Amount; }        
        public decimal TaxAmount { get => (TaxRate / MAX_TAX_RATE) * Amount; }
        public decimal TotalAmount { get => Amount + TaxAmount + TipAmount;}
        public decimal SplitAmount { get => TotalAmount / Split;}

        // Backed properties
        private decimal _amount =0;
        public decimal Amount
        {
            get { return _amount; }
            set
            {
                if(value >=0)
                {
                    _amount=value;
                    OnPropertyChanged(nameof(TaxAmount));
                    OnPropertyChanged(nameof(TipAmount));
                    OnPropertyChanged(nameof(TotalAmount));
                    OnPropertyChanged(nameof(SplitAmount));
                }
            }
        }

        private decimal _tipRate=0;
        public decimal TipRate
        {
            get { return _tipRate; }
            set
            {
                if (value >= 0)
                {
                    _tipRate = value;

                    OnPropertyChanged(nameof(TipRate));
                    OnPropertyChanged(nameof(TipAmount));
                    OnPropertyChanged(nameof(TotalAmount));
                    OnPropertyChanged(nameof(SplitAmount));
                }
            }
        }
        
        private decimal _taxRate=0;
        public decimal TaxRate { 
            get { return _taxRate; }
            set
            {
                if(value >MIN_TAX_RATE && value<MAX_TAX_RATE)
                {
                    _taxRate = value;
                    OnPropertyChanged(nameof(TaxRate));
                    OnPropertyChanged(nameof(TaxAmount));
                    OnPropertyChanged(nameof(TotalAmount));
                    OnPropertyChanged(nameof(SplitAmount));
                }
                   
            }
        }

        private int _split = 1;


        public int Split {
            get { 
                return _split; 
            }
            set 
            {
                _split = value <= 0 ? 1 : value;
                OnPropertyChanged(nameof(Split));
                OnPropertyChanged(nameof(SplitAmount));
            } 
        }

    }
}
