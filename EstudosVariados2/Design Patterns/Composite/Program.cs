using Composite;

FuncionarioComposite three = new("Romario");
FuncionarioLeaf liderado1 = new("João");
FuncionarioLeaf liderado2 = new("Alberto");
FuncionarioLeaf liderado3 = new("Johnathan");

three.Add(liderado1);
three.Add(liderado2);
three.Add(liderado3);

Console.WriteLine(three.Operation());