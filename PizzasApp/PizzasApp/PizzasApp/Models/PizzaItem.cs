namespace PizzasApp;

public class PizzaItem
{
    public const int DefaultSize = 12;
    
    public int Id { get; set; }

    public int OrderId { get; set; }

    public PizzaSpecial Special { get; set; }

    public int SpecialId { get; set; }

    public int Size { get; set; }

    public List<PizzaItemsTopping> Toppings { get; set; }

    public decimal GetBasePrice()
    {
        return ((decimal)Size / (decimal)DefaultSize) * Special.BasePrice;
    }

    public int MinimumSize { get; set; }

    public int MaximumSize { get; set; }

    public decimal GetTotalPrice()
    {
        return GetBasePrice();
    }

    public string GetFormattedTotalPrice()
    {
        return GetTotalPrice().ToString("0.00");
    }
}
