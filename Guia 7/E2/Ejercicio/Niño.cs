namespace Ejercicio
{
    public class Niño : Malevolo
    {
        private int maquillajes;
        private int actitudDelNiño;
        public int ActitudDelNiño { get => actitudDelNiño; }
        private int actitudDelNiñoNormal;
        private int caramelos;
        private bool esTerrorifico;

        // 0 para normal, 1 para empachado y 2 en cama
        private int estado;

        public Niño(int actitudDelNiño,bool esTerrorifico)
        {
            this.maquillajes = 3;
            this.actitudDelNiño = actitudDelNiño;
            this.esTerrorifico = esTerrorifico;
            this.actitudDelNiñoNormal = this.actitudDelNiño;
        }
        public void recibirCaramelos(int caramelos) => this.caramelos += caramelos;
        public void comerCaramelos(int caramelos){
            if(this.caramelos < caramelos) this.caramelos = 0;
            else this.caramelos -= caramelos;

            if (caramelos == 10){
                estado++;
            }

            switch (estado)
            {
                case 1:
                    actitudDelNiño = actitudDelNiño / 2;
                    break;
                case 2:
                    actitudDelNiño = 0;
                    break;
            }
            
        }
        public int TrajeEsTerrorifico(){
            if (esTerrorifico) return 5;
            else return 2;
        }
        public void asustar(Adultos adulto){
            Niño niño = new Niño(actitudDelNiño, esTerrorifico);
            caramelos += adulto.seAsusta(niño);
        }
        public int cantidadDeCaramelos(){
            return caramelos;
        }
        public int capacidadDeSusto(){
            if(actitudDelNiño < 1 || actitudDelNiño > 10){
                throw new System.Exception("El glamour super los rangos. Debe estar comprendido entre 1-10");
            }else{
                return (maquillajes + TrajeEsTerrorifico())* actitudDelNiño;
            }
        }
        
    }
}