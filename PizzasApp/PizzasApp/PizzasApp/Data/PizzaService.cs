namespace PizzasApp.Data;

public class PizzaService
{
    public async Task<List<Pizza>> GetPizzasAsync()
    {
        List<Pizza> pizzas = new();

        pizzas.AddRange(new List<Pizza>
        { 
            new Pizza{PizzaId = 1, Name = "The Baconatorizor", Description = "It has EVERY kind of bacon", Price = 11.99M, Vegan = true, Vegetarian = false},
            new Pizza{PizzaId = 1, Name = "The Baconatorizor", Description = "It has EVERY kind of bacon", Price = 45.99M, Vegan = true, Vegetarian = false},
            new Pizza{PizzaId = 1, Name = "Buffalo chicken", Description = "Spicy chicken, hot sauce, and blue cheese, guaranteed to warm you up", Price = 25.99M, Vegan = true, Vegetarian = false},
            new Pizza{PizzaId = 1, Name = "Veggie Delight", Description = "Traditional Italian pizza with tomatoes and basil", Price = 30.99M, Vegan = true, Vegetarian = false},
            new Pizza{PizzaId = 1, Name = "Veggie Delight", Description = "Traditional Italian pizza with tomatoes and basil", Price = 86.99M, Vegan = true, Vegetarian = false},
            new Pizza{PizzaId = 1, Name = "Classic pepperoni", Description = "It's the pizza you grew up with, but Blazing hot!", Price = 16.99M, Vegan = true, Vegetarian = false},
        });

        return await Task.FromResult(pizzas);
    }
}
