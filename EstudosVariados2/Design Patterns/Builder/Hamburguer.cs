namespace Builder
{
    public class Hamburger
    {
        // ... Propriedades (já estavam corretas em PascalCase)
        public string TipoPao { get; set; }
        public string TipoCarne { get; set; }
        public bool TemBacon { get; set; }
        public bool TemQueijo { get; set; }
        public bool TemSalada { get; set; }

        public string GetDescricao()
        {
            return $"Hamburguer com pão {TipoPao}," +
                $"carne {TipoCarne}:" +
                $" Bacon: {TemBacon}," +
                $" Salada: {TemSalada}," +
                $" Queijo: {TemQueijo}.";
        }
    }
}