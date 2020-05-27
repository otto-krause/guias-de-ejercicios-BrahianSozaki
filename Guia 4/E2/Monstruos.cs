namespace E2
{
    public abstract class Monstruos
    {
        protected int respeto;
        public int Respeto { get => respeto; }
        public Monstruos (int respeto){
            this.respeto = respeto;
        } 

        public abstract void asustar();
        public abstract void reir();
    }
}