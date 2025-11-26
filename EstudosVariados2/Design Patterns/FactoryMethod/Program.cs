using FactoryMethod.Creator;
using FactoryMethod.Product;

Tela tela1 = new ConcreteTelaWebCreator().CriaTela();
Tela tela2 = new ConcreteTelaSmartphoneCreator().CriaTela();
Tela tela3 = new ConcreteTelaSmartwatchCreator().CriaTela();
Tela tela4 = new ConcreteTelaSmartTVCreator().CriaTela();

Console.WriteLine("Tela Web =>" + tela1.GetMessageText());
Console.WriteLine("Tela SmartPhone =>" + tela2.GetMessageText());
Console.WriteLine("Tela SmartWatch =>" + tela3.GetMessageText());
Console.WriteLine("Tela SmartTV =>" + tela4.GetMessageText());