using System.Collections.Generic;
using System.Linq;
using System;

namespace Ejercicio
{
    public class Riley
    {
        int nivelDeFelicidad;
        string emocionDominante;
        List<Recuerdo> recuerdos;
        public List<Recuerdo> Recuerdos { get => recuerdos; }
        List<Recuerdo> recuerdosCentrales;
        public List<Recuerdo> RecuerdosCentrales { get => recuerdosCentrales; }
        List<Recuerdo> recuerdosNegados;
        List<Recuerdo> memoriaLargoPlazo;
        Recuerdo recuerdo;
        int reduccionPorcentual;
        public Riley(string emocionDominante, List<Recuerdo> recuerdosCentrales)
        {
            this.nivelDeFelicidad = 1000;
            this.emocionDominante = emocionDominante;
            this.recuerdos = new List<Recuerdo>();
            this.recuerdosCentrales = recuerdosCentrales;
            this.recuerdosNegados = new List<Recuerdo>();
            this.memoriaLargoPlazo = new List<Recuerdo>();
        }
        public void agregarEvento(string descripcion, DateTime fecha, string emocionDominanteMomento){
            Recuerdo recuerdo = new Recuerdo(descripcion, fecha, emocionDominanteMomento);
            recuerdos.Add(recuerdo);
        }
        public void asentarRecuerdo(){
            foreach(var i in recuerdos){
                switch(i.EmocionDominante){
                    case "Alegre":
                                foreach(var j in recuerdosCentrales)
                                    if(nivelDeFelicidad > 500 && !i.Descripcion.Contains(j.Descripcion)) recuerdosCentrales.Add(i);//posible cambiarlo por linq
                    break;
                    case "Triste":
                                foreach(var j in recuerdosCentrales)//no funciona aunque sea practicamente la misma linea de codigo arriba
                                    if (!i.Descripcion.Contains(j.Descripcion)) recuerdosCentrales.Add(i);//posible cambiarlo por linq
                                reduccionPorcentual = 10 * nivelDeFelicidad / 100;
                                if (reduccionPorcentual <= nivelDeFelicidad) nivelDeFelicidad -= reduccionPorcentual;
                                else nivelDeFelicidad = 1;
                    break;
                }
            }
        }
        public List<Recuerdo> recuerdosDelDia(){
            return recuerdos.Take(5).ToList();
        }
        public List<Recuerdo> recuerdosDificles(){
            return recuerdos.Where( i => i.Descripcion.Split(" ").Count() > 10 ).ToList();
        }

        public List<Recuerdo> negarRecuerdo(){
            switch (emocionDominante){
                case "Alegre":
                        recuerdosNegados = recuerdos.Where(i => i.EmocionDominante != "Alegre").ToList();
                break;
                case "Triste":
                        recuerdosNegados = recuerdos.Where(i => i.EmocionDominante == "Alegre").ToList();
                break;
            }
            return recuerdosNegados;
        }
        public void dormir(string palabraClave){
            //Asentamiento
            asentarRecuerdo();//No funciona esto nada mas

            //Asentamiento Selectivo
            foreach(var i in recuerdos) 
                foreach(var j in recuerdosCentrales)
                    if (i.Descripcion.Contains(palabraClave) && !i.Descripcion.Contains(j.Descripcion)) recuerdosCentrales.Add(i);

            //Profundizacion
            foreach(var i in recuerdos)
                foreach(var j in negarRecuerdo())
                    if(!i.Descripcion.Contains(j.Descripcion)) memoriaLargoPlazo.Add(i);

            //Control hormonal
            if(recuerdos.TrueForAll(i => i.EmocionDominante == "Alegre")){
                reduccionPorcentual = 15 * nivelDeFelicidad / 100;
                if (reduccionPorcentual <= nivelDeFelicidad) nivelDeFelicidad -= reduccionPorcentual;
                else nivelDeFelicidad = 1;
                recuerdosCentrales = recuerdosCentrales.Except(recuerdosCentrales.Take(3)).ToList();
            }
            else
                foreach(var i in memoriaLargoPlazo) 
                    foreach(var j in recuerdosCentrales)
                        if(i.Descripcion.Contains(j.Descripcion)){
                            reduccionPorcentual = 15 * nivelDeFelicidad / 100;
                            if (reduccionPorcentual <= nivelDeFelicidad) nivelDeFelicidad -= reduccionPorcentual;
                            else nivelDeFelicidad = 1;
                            List<DateTime> fechas = new List<DateTime>();
                            recuerdosCentrales.ForEach(i => fechas.Add(i.Fecha));
                            fechas = fechas.OrderBy(i => i.Year).Except(fechas.Take(3)).ToList();
                        }

            //Restauración cognitiva
            if(nivelDeFelicidad + 100 > 1000) nivelDeFelicidad = 1000;
            else nivelDeFelicidad += 100;

            //Liberación de recuerdos del día
            recuerdos.Clear();

        }

        public List<Recuerdo> Rememorar(){//incompleto
            List<DateTime> fechas = new List<DateTime>();
            memoriaLargoPlazo.OrderBy(i => i.Fecha.Year);
            memoriaLargoPlazo.ForEach(i => fechas.Add(i.Fecha));
            int edad = DateTime.Now.Year - fechas.First().Year;

            List<Recuerdo> recuerdosMasAntiguos = memoriaLargoPlazo.Where(i => DateTime.Now.Year - i.Fecha.Year < edad / 2).ToList();
            return recuerdosMasAntiguos;
        }

        public void memoriasCompuestas(Recuerdo dejavu){
            bool esAlegre = false;
            switch(emocionDominante){
                case "Alegre y otro/s":
                        recuerdosNegados = recuerdos.Where(i => i.EmocionDominante != "Alegre").ToList();
                        esAlegre = true;
                break;
                case "Triste y otro/s":
                        recuerdosNegados = recuerdos.Where(i => i.EmocionDominante == "Alegre").ToList();
                break;
            }

            foreach(var i in recuerdos){
                if (i.EmocionDominante.Contains("Alegre"))
                    foreach(var j in recuerdosCentrales)
                        if(nivelDeFelicidad > 500 && !i.Descripcion.Contains(j.Descripcion)) recuerdosCentrales.Add(i);//posible cambiarlo por linq
                else
                    if (i.EmocionDominante.Contains("Triste"))
                        foreach(var k in recuerdosCentrales)//no funciona aunque sea practicamente la misma linea de codigo arriba
                            if (!i.Descripcion.Contains(k.Descripcion)) recuerdosCentrales.Add(i);//posible cambiarlo por linq
                        reduccionPorcentual = 10 * nivelDeFelicidad / 100;
                        if (reduccionPorcentual <= nivelDeFelicidad) nivelDeFelicidad -= reduccionPorcentual;
                        else nivelDeFelicidad = 1;
            }

            List<Recuerdo> recuerdosRepetidosMLP = memoriaLargoPlazo.Distinct().ToList();
            recuerdosRepetidosMLP.OrderBy(i => i.Descripcion);
            List<int> cantidadDeRepeticiones = new List<int>();

            int count = 0;
            foreach(var i in memoriaLargoPlazo){
                foreach(var j in recuerdosRepetidosMLP) if (i.Descripcion == j.Descripcion) count++;
                cantidadDeRepeticiones.Add(count);
                count = 0;
            }

            memoriaLargoPlazo.Contains(dejavu);



        }

    }
}