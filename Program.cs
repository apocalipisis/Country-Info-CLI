List<Country> countries = new();

string entry = String.Empty;
while (!entry.Equals("esc", StringComparison.OrdinalIgnoreCase))
{
    if (entry == null) break;

    Console.Write("\nDigite um pais (Digite esc para sair): ");
    entry = Console.ReadLine();
    if (entry.Equals("esc", StringComparison.OrdinalIgnoreCase)) break;

    var countryRegistred = false;
    foreach (var country in countries)
    {
        if (country.Name.Equals(entry, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine($"País:\t\t{country.Name}");
            Console.WriteLine($"Capital:\t{country.Capital}");
            Console.WriteLine($"População:\t{country.Population}");
            countryRegistred = true;
            break;
        }
    }

    if (!countryRegistred)
    {
        var name = entry;

        Console.Write("\nDigite a capital(Digite esc para sair): ");
        entry = Console.ReadLine();
        if (entry.Equals("esc", StringComparison.OrdinalIgnoreCase)) break;
        var capital = entry;

        Console.Write("\nDigite a população (Digite esc para sair): ");
        entry = Console.ReadLine();
        if (entry.Equals("esc", StringComparison.OrdinalIgnoreCase)) break;
        var population = entry;

        countries.Add(new Country(name, capital, population));
        Console.WriteLine("País cadastrado");
        Console.WriteLine("_______________");
    }
}



public record Country(string? Name, string? Capital, string? Population);
