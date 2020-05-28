using System.Collections.Generic;
namespace E5
{
    public abstract class SerPensante
    {
        protected int inteligencia;
        protected List<string> conocimientos = new List<string>();
        protected  List<string> intereses = new List<string>();

        protected SerPensante(int inteligencia)
        {
            this.inteligencia = inteligencia;
        }
        public abstract void pensar();
        public abstract void estudiar(string conocimientoNuevo);
    }
}