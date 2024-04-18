namespace Checkpoint1.Models
{
    public class Cliente : Pessoa
    {
        public Cliente(string nome, string telefone, string idCliente) : base(nome, telefone)
        {
            IdCliente = idCliente;
        }

        private List<Cliente> clientes = new List<Cliente>();

        internal void CadastrarCliente(Cliente novoCliente)
        {
            clientes.Add(novoCliente);
        }
        public string IdCliente { get; set; }

        public override void EntrarNaLanHouse()
        {
            Console.WriteLine("Cliente entrou na Lan House");
        }
    }
}
