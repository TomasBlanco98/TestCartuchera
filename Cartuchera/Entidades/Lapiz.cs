using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;
        ConsoleColor IAcciones.Color { get => ConsoleColor.Gray; set => throw new NotImplementedException(); }
        float IAcciones.UnidadesDeEscritura { get => this.tamanioMina; set => this.tamanioMina = value; }

        public Lapiz(int unidades)
        {
            this.tamanioMina = unidades;
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            int cantidadLetras = texto.Length;
            float gasto = cantidadLetras * 0.3F;

            this.tamanioMina -= gasto;

            return new EscrituraWrapper(texto, ConsoleColor.Gray);
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine();
            return sb.ToString();
        }
    }
}
