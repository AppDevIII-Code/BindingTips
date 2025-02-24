using BindingTips.Models;


namespace BindingTips.DataRepos
{
    public static class ProvincesRepo
    {
        public static List<Province> Provinces = new List<Province>()
        {
            new Province(){ Name="Quebec", TaxRate=14.975m},
            new Province(){ Name="Ontario", TaxRate=13m},
            new Province(){ Name="Alberta", TaxRate=5m},
            new Province(){ Name="British Columbia", TaxRate=12m},
            new Province(){ Name="Prince Edward Island", TaxRate=15m},
            new Province(){ Name="Manitoba", TaxRate=12m},
            new Province(){ Name="New Brunswick", TaxRate=15m},
            new Province(){ Name="Nova Scotia", TaxRate=15m},
            new Province(){ Name="Nunavut", TaxRate=5m},
            new Province(){ Name="Saskatchewan", TaxRate=11m},
            new Province(){ Name="Newfoundland and Labrador", TaxRate=15m},
            new Province(){ Name="Northwest Territories", TaxRate=5m},
            new Province(){ Name="Yukon", TaxRate=5m}
        };

    }
}
