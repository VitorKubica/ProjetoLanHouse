using System;
using System.Collections.Generic;

namespace Checkpoint1.Models
{
    public class Reserva
    {
        public List<Tuple<Cliente, Computador>> reservas = new List<Tuple<Cliente, Computador>>();
        public void AdicionarReserva(Cliente cliente, Computador computador)
        {
            reservas.Add(new Tuple<Cliente, Computador>(cliente, computador));
        }
    }
    public interface IReserva
    {
        void Reservar(Cliente cliente, Computador computador);

        List<Tuple<Cliente, Computador>> ListarReservas();
    }
}
