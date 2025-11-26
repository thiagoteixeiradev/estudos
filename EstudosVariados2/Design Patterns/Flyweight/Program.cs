using Flyweight;

var factory = new FlyweightFactory(
    new Carro { Numero = "123asd", Dono = "Romario", Cor = "Vermelho", Marca = "Ford", Modelo = "Ranger"},
    new Carro { Numero = "489qwe", Dono = "Romario", Cor = "Preto", Marca = "Ford", Modelo = "Mirage" },
    new Carro { Numero = "536gsd", Dono = "Gabriel", Cor = "Preto", Marca = "Ford", Modelo = "Aurus" },
    new Carro { Numero = "dad132", Dono = "Leticia", Cor = "Vermelho", Marca = "Mazda", Modelo = "RX8" }
    );
factory.listFlyweights();

addCarToPoliceDatabase(factory, new Carro
{
    Numero = "321asd",
    Dono = "Lucas",
    Cor = "Branco",
    Modelo = "Negrini",
    Marca = "Lexus"
});

factory.listFlyweights();

static void addCarToPoliceDatabase(FlyweightFactory factory, Carro carro)
{
    var flyweight = factory.GetFlyweight(new Carro
    {
        Cor = carro.Cor,
        Modelo = carro.Modelo,
        Marca= carro.Marca,
    });
    flyweight.Operation(carro);
}