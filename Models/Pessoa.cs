namespace Checkpoint1.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, string telefone)
        {
            if (nome == "")
            {
                throw new Exception("Nome nao pode ser nulo ou vazio");
            }
            Nome = nome;
            Telefone = telefone;
        }

        public string Nome { get; set; }
        public string Telefone { get; set; }

        public virtual void EntrarNaLanHouse()
        {
          
            Console.WriteLine("Pessoa entrou na Lan House");
      
        }

    }
}

