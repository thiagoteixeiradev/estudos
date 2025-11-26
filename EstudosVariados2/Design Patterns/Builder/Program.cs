using Builder;

HamburguerBuilder hamburguerBuilder = new();


//X-Salada
var xSalada = new HamburguerBuilder().SetTemSalada().SetTemQueijo()
    .SetTipoPao("Pão de Centeio").SetTipoCarne("Bovina").Build();

//X-Bacon
var xBacon = new HamburguerBuilder().SetTemSalada().SetTemQueijo().SetTemBacon()
    .SetTipoPao("Pão de Centeio").SetTipoCarne("Bovina").Build();

//Escrever
Console.WriteLine(xSalada.GetDescricao());
Console.WriteLine(xBacon.GetDescricao());