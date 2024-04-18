namespace Checkpoint1.Models
{
    public class Computador
    {
        public Computador(string idComputador)
        {
            IdComputador = idComputador;
            Disponivel = true;
        }

        public string IdComputador { get; set; }
        public bool Disponivel { get; set; }

        protected bool Status()
        {
            return true;
        }
    }
}
