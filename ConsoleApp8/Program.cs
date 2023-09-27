




using ConsoleApp8;
using System.Data;
using System.Text.Json;

//Way1
//Car car = new Car { Vendor = "Vaz", Model = "Priora", Year = 2012 };

//string jsonStr = JsonSerializer.Serialize(car);

//File.WriteAllText("../../../car.json", jsonStr);


//Way2

List<Car> cars = new List<Car>() {
    new(){ Vendor = "Vaz", Model = "Priora", Year = 2013 },
    new(){ Vendor = "Vaz", Model = "Granta", Year = 2012 },
    new(){ Vendor = "Vaz", Model = "Kalina", Year = 2012 },
    new(){ Vendor = "Vaz", Model = "2107", Year = 2012 },
    new(){ Vendor = "Vaz", Model = "2106", Year = 2012 },
    new(){ Vendor = "Vaz", Model = "Vesta", Year = 2012 }
};
//JsonSerializerOptions options = new JsonSerializerOptions();
//options.WriteIndented = true;
//string jsonStr = JsonSerializer.Serialize(cars,options);
//File.WriteAllText("../../../cars.json", jsonStr);



//List<Car> list = new List<Car>();

//string jsonCars = File.ReadAllText("../../../cars.json");

//list = JsonSerializer.Deserialize<List<Car>>(jsonCars);

//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}


//List<Country> countries = new List<Country>();
//string jsonCountry = File.ReadAllText("../../../country.json");

//countries = JsonSerializer.Deserialize<List<Country>>(jsonCountry);
//foreach (var item in countries)
//{
//    if (item.code=="AZ")
//    {
//        Console.WriteLine("Yasasin Azerbaycan");
//        Console.WriteLine(item);

//    }
//    if (item.code =="AR")
//    {
//        Console.WriteLine("Cehenneme getdi status");
//        Console.WriteLine("ermeni .......");
//    }
//}