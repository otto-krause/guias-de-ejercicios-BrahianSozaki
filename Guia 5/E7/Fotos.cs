namespace E7
{
    public class Fotos
    {
        string directorioDeAlmacenamiento;
        public string DirectorioDeAlmacenamiento { get => directorioDeAlmacenamiento; }
        string fechaDeCreacion;
        public string FechaDeCreacion { get => fechaDeCreacion; }
        string personasEtiquetadas;
        public string PersonasEtiquetadas { get => personasEtiquetadas; }

        public Fotos(string directorioDeAlmacenamiento, string fechaDeCreacion, string personasEtiquetadas)
        {
            this.directorioDeAlmacenamiento = directorioDeAlmacenamiento;
            this.fechaDeCreacion = fechaDeCreacion;
            this.personasEtiquetadas = personasEtiquetadas;
        }

    }
}