using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.colorTinta = color;
            this.tinta = unidades;
        }

        public ConsoleColor Color { get => this.colorTinta; set => this.colorTinta = value; }
        public float UnidadesDeEscritura { get => this.tinta; set => this.tinta = value; }

        public EscrituraWrapper Escribir(string texto)
        {
            float cantidadLetras = texto.Length;
            float gasto = cantidadLetras * 0.3F;

            this.tinta -= gasto;

            return new EscrituraWrapper(texto, this.colorTinta);
        }

        public bool Recargar(int unidades)
        {
            this.tinta += unidades;
            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Tipo: ");
            return sb.ToString();
        }
    }
}
