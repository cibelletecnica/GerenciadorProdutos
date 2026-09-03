using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorProdutos
{
    public abstract class Produto
    { 
        // Encapsulamento através de propriedades automáticas
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal PrecoBase { get; set; }

        // Contrutor da classe base
        protected  Produto(string nome, decimal precoBase)
        {
            Nome = nome;
            PrecoBase = precoBase;
        }

        // Método abastrato que força a subclasse a implementar o polimorfismo
        public abstract decimal CalcularPrecoFinal();

    }
}
