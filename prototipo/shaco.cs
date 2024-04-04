
namespace prototipo
{
    public class Shaco
    
    
    {
        double Agua;
        protected string Imagem = "shaco.png";
        double Fome;

        public Shaco()
        {
            Agua = 0;
            Fome = 0;
        }

        public double GetAgua()
        {
            return Agua;
        }

        public double GetFome()
        {
            return Fome;
        }

        public void SetAgua(double s)
        {
            if (s < 0)
                Agua = 0;
            else if (s > 1)
                Agua = 1;
            else
                Agua = s;
        }

        public void SetFome(double s)
        {
            if (s < 0)
                Fome = 0;
            else if (s > 1)
                Fome = 1;
            else
                Fome = s;
        }
    }
}
