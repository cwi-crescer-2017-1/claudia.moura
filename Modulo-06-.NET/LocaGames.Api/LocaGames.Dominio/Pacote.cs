namespace LocaGames.Dominio
{
    public class Pacote
    {
        public int IdPacote { get; private set; }
        public string Nome { get; private set; }
        public double DescontoPacote { get; private set; }

        protected Pacote() { }

        public Pacote(string nome, double desconto)
        {
            Nome = nome;
            DescontoPacote = desconto;
        }
    }
}
