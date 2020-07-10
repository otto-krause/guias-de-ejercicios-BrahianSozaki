using System.Colection.Generic;
namespace E7
{
    public class Usuario
    {
        private string nombre;
        public string Nombre { get => nombre; }
        List<Publicacion> publicacion;
        public List<Publicacion> Publicacion { get => publicacion; }
        public Usuario(string nombre, List<Publicacion> publicacion)
        {
            this.nombre = nombre;
            this.publicacion = publicacion;
        }
    }
}