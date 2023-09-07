using Lab10Ex2.Models;

//Seed();

using var ctx = new AutovehiculDbContext();

var vehiclesByYear = ctx.Autovehicul.OrderByDescending(e => e.AnFabricatie).ToList();

static void Seed()
{
    using var ctx = new AutovehiculDbContext();

    var toyota = new Producator
    {
        Nume = "Toyota",
        Tara = "Japonia"
    };

    var bmw = new Producator
    {
        Nume = "BMW",
        Tara = "Germania"
    };

    var dacia = new Producator
    {
        Nume = "Dacia",
        Tara = "Romania"
    };

    var ferrari = new Producator
    {
        Nume = "Ferarri",
        Tara = "Italia"
    };

    ctx.Autovehicul.Add(
        new Autovehicul
        {
            Model = "Logan",
            SerieSasiu = "WWBUAUDOO0929",
            AnFabricatie = 2019,
            Producator = dacia
        });

    ctx.Autovehicul.Add(
    new Autovehicul
    {
        Model = "Sandero",
        SerieSasiu = "WWAAPPC331",
        AnFabricatie = 2021,
        Producator = dacia
    });

    ctx.Autovehicul.Add(
  new Autovehicul
  {
      Model = "116",
      SerieSasiu = "PPSSLLCC22991",
      AnFabricatie = 2006,
      Producator = bmw
  });

    ctx.Autovehicul.Add(
new Autovehicul
{
    Model = "488",
    SerieSasiu = "FFF1111222",
    AnFabricatie = 2023,
    Producator = ferrari
});

    ctx.Autovehicul.Add(
new Autovehicul
{
    Model = "Corolla",
    SerieSasiu = "TTTT101028373656",
    AnFabricatie = 2023,
    Producator = toyota
});

    ctx.SaveChanges();
}