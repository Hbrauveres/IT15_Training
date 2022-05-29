public static class PizzaServices
{
    private static List<Pizza> Pizzas {get;}

    static PizzaServices()
    {
        Pizzas = new List<Pizza>
        {
            new Pizza {Id=1, Name="Calabresa", IsGlutenFree=false, Preco=35.90m },
            new Pizza {Id=2, Name="Vegetariana", IsGlutenFree=true, Preco=40.99m}
        };
    }

    public static IEnumerable<Pizza> GetAll()
    {
        return Pizzas.OrderBy(p => p.Name).ToArray();
    }

    public static Pizza? GetPizza(int id)
    {
        return Pizzas.FirstOrDefault(p => p.Id == id);
    }

    public static void Add(Pizza pizza)
    {
        Pizzas.Add(pizza);
    }

    public static void Delete(int id)
    {
        var pizza = GetPizza(id);
        if(pizza is null) return;
        Pizzas.Remove(pizza);
    }
}