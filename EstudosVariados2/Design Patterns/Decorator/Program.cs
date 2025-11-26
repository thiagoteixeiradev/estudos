using Decorator;
using Decorator.Concrete;
using Decorator.Decorador;

ICarro carro = new Carro();
ICarro multimidiaDecorator = new KitMultimidiaDecorator(carro);

var result = multimidiaDecorator.RetornarCarro();

Console.WriteLine(result);
