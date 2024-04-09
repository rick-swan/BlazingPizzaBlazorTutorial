namespace BlazingPizza.Data;

public record PizzaDto(int Id, string Name, decimal Price);

public interface IPizzaService
{
    Task<PizzaDto[]> GetPizzasAsync();
}

public class PizzaService : IPizzaService
{
    public async Task<PizzaDto[]> GetPizzasAsync()
    {
        await Task.Delay(1000);
        return new[]
        {
            new PizzaDto(1, "Margherita", 9.99m),
            new PizzaDto(2, "Pepperoni", 11.50m),
            new PizzaDto(3, "Hawaiian", 12.75m),
            new PizzaDto(4, "Meat Feast", 13.99m),
        };
    }
}