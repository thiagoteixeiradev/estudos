using Template_Method;

Filme filme1 = new(1, "Titanic", 1997, 4.9);
Filme filme2 = new(2, "Click", 2006, 4.7);
Filme filme3 = new(3, "Náufrago", 2000, 4.8);
Filme filme4 = new(4, "Invencível", 2014, 5);
Filme filme5 = new(5, "O Grande Dragão Branco", 1988, 4.6);
Filme filme6 = new(6, "A bela e a fera", 2000, 4);

List<Filme> listaFilmes = new List<Filme>()
{
    filme1, filme2, filme3, filme4, filme5, filme6
};

OrdenadorTemplate ordenador;

ordenador = new OrdenarPorTitulo();
var estoque = ordenador.Ordenar(listaFilmes);

foreach (var filme in estoque)
{
    Console.WriteLine($"Id: {filme.Id} - Título: {filme.Titulo} - Ano: {filme.Ano} - Avaliação: {filme.Avaliacao}");
}