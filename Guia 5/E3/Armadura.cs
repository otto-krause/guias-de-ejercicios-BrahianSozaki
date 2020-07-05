namespace E3
{
    public class Armadura
    {
        string nombre;
        public string Nombre { get => nombre; }
        string material;
        public string Material { get => material; }
        public Armadura(string nombre, string material)
        {
            this.nombre = nombre;
            this.material = material;
        }
    }
}