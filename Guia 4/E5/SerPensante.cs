using System.Collections.Generic;
namespace E5
{
    public abstract class SerPensante
    {
        protected int inteligencia;
        protected List<string> conocimientos;
        protected  List<string> intereses;

        protected SerPensante(int inteligencia)
        {
            this.inteligencia = inteligencia;
            conocimientos = new List<string>();
            intereses = new List<string>();//Es mejor iniciar las variables siempre en el cosntructor.
        }

        public abstract void pensar(string tema); //Se supone que piensa un tema y se lo tenia que pasar
        public abstract void estudiar(string conocimientoNuevo);
    }
}