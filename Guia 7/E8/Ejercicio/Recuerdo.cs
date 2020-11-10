using System;
namespace Ejercicio
{
    public class Recuerdo
    {
        string descripcion;
        public string Descripcion { get => descripcion; }
        DateTime fecha;
        public DateTime Fecha { get => fecha; }
        string emocionDominante;
        public string EmocionDominante { get => emocionDominante; }
        public Recuerdo(string descripcion, DateTime fecha, string emocionDominante)
        {
            this.descripcion = descripcion;
            this.fecha = fecha;
            this.emocionDominante = emocionDominante;
        }

    }
}