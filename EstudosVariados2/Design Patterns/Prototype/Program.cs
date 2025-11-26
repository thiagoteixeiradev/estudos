using Prototype;

InimigoA inimigo1 = new();
inimigo1.Nome = "Moob";
inimigo1.hp = 10;
inimigo1.dano = 1;
inimigo1.cor = "Blue";
inimigo1.Arma.Nome = "Faca";
inimigo1.Arma.Dano = 2;

Inimigo inimigo2 = new InimigoA();
inimigo2 = inimigo1.Clone();