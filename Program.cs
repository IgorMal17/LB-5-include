using ConsoleLoadingIncludeLoad.Models;
using Microsoft.EntityFrameworkCore;
using AppContext = ConsoleLoadingIncludeLoad.Models.AppContext;

internal class Program
{
    private static void Main(string[] args)
    {
        //using (AppContext db = new AppContext())
        //{
        //    // пересоздадим базу данных
        //    db.Database.EnsureDeleted();
        //    db.Database.EnsureCreated();

        //    Position manager = new Position { Name = "Manager" };
        //    Position developer = new Position { Name = "Developer" };
        //    db.Positions.AddRange(manager, developer);

        //    City washington = new City { Name = "Washington" };
        //    db.Cities.Add(washington);

        //    Country usa = new Country { Name = "USA", Capital = washington };
        //    db.Countries.Add(usa);

        //    Company microsoft = new Company { Name = "Microsoft", Country = usa };
        //    Company google = new Company { Name = "Google", Country = usa };
        //    db.Companies.AddRange(microsoft, google);

        //    User tom = new User { Name = "Tom", Company = microsoft, Position = manager };
        //    User bob = new User { Name = "Bob", Company = google, Position = developer };
        //    User alice = new User { Name = "Alice", Company = microsoft, Position = developer };
        //    User kate = new User { Name = "Kate", Company = google, Position = manager };
        //    db.Users.AddRange(tom, bob, alice, kate);

        //    db.SaveChanges();

        // получаем пользователей
        /*var users = db.Users
            // подгружаем данные по компаниям
            .Include(u => u.Company)  
            .ToList();*/
        /*если данные уже ранее были загружены в контекст данных
        или просто ранее были в него добавлены,
        то можно не использовать метод Include*/
        //var users = db.Users.ToList();

        //foreach (var user in users)
        //    Console.WriteLine($"{user.Name} - {user.Company?.Name}");

        //Console.WriteLine("=====================================");
    }

    /*
     * Загрузка данных из многоуровневой структуры 
     */

    //Console.WriteLine("================================================");
    //Console.WriteLine("============Загрузка методом include============");
    //Console.WriteLine("================================================");

    //using (AppContext db = new AppContext())
    //{
    //    // получаем пользователей
    //    var users = db.Users
    //                    .Include(u => u.Company)  // добавляем данные по компаниям
    //                        .ThenInclude(comp => comp!.Country)      // к компании добавляем страну 
    //                            .ThenInclude(count => count!.Capital)    // к стране добавляем столицу
    //                    .Include(u => u.Position) // добавляем данные по должностям
    //                    .ToList();
    //    foreach (var user in users)
    //    {
    //        Console.WriteLine($"{user.Name} - {user.Position?.Name}");
    //        Console.WriteLine($"{user.Company?.Name} - {user.Company?.Country?.Name} - {user.Company?.Country?.Capital?.Name}");
    //        Console.WriteLine("----------------------");     // для красоты
    //    }
    //}
    //} 
}