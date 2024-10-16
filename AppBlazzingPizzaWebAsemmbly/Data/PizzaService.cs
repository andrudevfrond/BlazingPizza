using System.Text.RegularExpressions;

namespace BlazingPizza.Data;

public class PizzaService
{
    public async Task<Pizzas[]> GetPizzasAsync()
    {
        Pizzas[] pizzas = new Pizzas[4];

        for (int i = 0; i < pizzas.Length; i++) { 
            pizzas[i] = new Pizzas() { 
                PizzaId = i,
                Description = "Pizza deliciosa" + pizzas[i],
                Name = "Pizza" + pizzas[i],
                Price = 200,
                Vegan = false,
                Vegetarian = true,
            };
        }

        return await Task.FromResult(pizzas);
    }
}
