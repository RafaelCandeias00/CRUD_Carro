using CRUD.src.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.src
{
    class Carro
    {
        public Marcas Marca { get; set; }
        public string Modelo { get; set; }
        public int AnoFabricacao { get; set; }

        public Carro(Marcas marca, string modelo, int anoFabricacao)
        {
            Marca = marca;
            Modelo = modelo;
            AnoFabricacao = anoFabricacao;
        }

        public override string ToString()
        {
            return $"Marca: {Marca} | Modelo: {Modelo} | Ana de fabricação: {AnoFabricacao}";
        }

    }
}
