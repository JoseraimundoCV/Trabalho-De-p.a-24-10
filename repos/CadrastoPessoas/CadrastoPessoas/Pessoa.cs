using System;

namespace CadastroPessoas
{
    public class Cliente : Pessoa
    {
        public string CodigoCliente;

        public void ExibirDadosCliente()
        {
            Console.WriteLine("Codigo do Cliente: " + CodigoCliente);
            Apresentar();
        }
    }
}
