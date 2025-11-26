namespace Builder
{
    public class HamburguerBuilder
    {
        private Hamburger _hamburguer;

        public HamburguerBuilder()
        {
            _hamburguer = new Hamburger();
        }

        public HamburguerBuilder SetTipoPao(string pao)
        {
           _hamburguer.TipoPao = pao;
            return this;
        }

        public HamburguerBuilder SetTipoCarne(string carne)
        {
            _hamburguer.TipoCarne = carne;
            return this;
        }

        public HamburguerBuilder SetTemBacon()
        {
            _hamburguer.TemBacon = true;
            return this;
        }

        public HamburguerBuilder SetTemQueijo()
        {
            _hamburguer.TemQueijo = true;
            return this;
        }

        public HamburguerBuilder SetTemSalada()
        {
            _hamburguer.TemSalada = true;
            return this;
        }

        public Hamburger Build() => _hamburguer;

    }

}