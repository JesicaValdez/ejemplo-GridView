using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Auto
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Descripcion { get; set; }
        public string Color { get; set; }
        public DateTime Fecha { get; set; }
        public bool usado { get; set; } 
        public bool Importado { get; set; }

    }

    public class  AutoNegocio
    {
        public List<Auto> listar()
        {
            List<Auto> lista = new List<Auto>();
            lista.Add(new Auto());
            lista.Add(new Auto());

            lista[0].Id = 1;
            lista[0].Marca = "Toyota";
            lista[0].Modelo = "Corolla";
            lista[0].Descripcion = "Auto de alta gama";
            lista[0].Color = "Rojo";
            lista[0].Fecha = DateTime.Now;
            lista[0].usado = true;
            lista[0].Importado = true;

            lista[1].Id = 2;
            lista[1].Marca = "Ford";
            lista[1].Modelo = "Fiesta";
            lista[1].Descripcion = "Auto de alta gama";
            lista[1].Color = "Azul";
            lista[1].Fecha = DateTime.Now;
            lista[1].usado = false;
            lista[1].Importado = false;


            return lista;

        }
    }
}
