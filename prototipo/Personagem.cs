namespace prototipo;

    public class Personagem
    {
        public double Fome;

        public double Sede;

        public double triste;
        public string arquivo_da_foto;

        public Personagem()
        {

        }
        

        public void SetFome(double fome)
        {
            Fome = fome;
        }

        public double GetFome()
        {
            return Fome;
        }

        public void SetSede(double s)
        {
            Sede = s;
        }

        public double GetSede()
        {
            return Sede;
        }

         public void Settriste(double t)
        {
            triste = t;
        }

        public double Gettriste()
        {
            return triste;
        }

        public string GetArquivo()
        {
            return arquivo_da_foto;
        }
    }