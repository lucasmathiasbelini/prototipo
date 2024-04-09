public partial class MainPage : ContentPage
{
    public class Personagem
    {
        public double Fome { get; set; }
        public string ArquivoImagem { get; set; }

        public Personagem(double fome, string arquivoImagem)
        {
            Fome = fome;
            ArquivoImagem = arquivoImagem;
        }

        public void SetFome(double fome)
        {
            Fome = fome;
        }

        public double GetFome()
        {
            return Fome;
        }

        public string GetArquivo()
        {
            return ArquivoImagem;
        }
    }

    Personagem atual;
    Personagem personagem1;
    Personagem personagem2;
    public MainPage()
    {
        InitializeComponent();

        personagem1 = new Personagem(0.0, "caminho_da_imagem1"); 
        personagem2 = new Personagem(0.0, "caminho_da_imagem2"); 
        atual = personagem1; 

        

         shaco = new Shaco();
        
        shaco.SetFome(shaco.GetFome() + 0.1);
        

        
    }

    public void PassouTempo()
    {
        var timer = Application.Current.Dispatcher.CreateTimer();
        timer.Interval = TimeSpan.FromSeconds(10); 
        timer.Tick += (s, e) => PassouTempo(); 
        timer.Start(); 
    }

   

    void BotaoFome(object sender, EventArgs args)
    {
       atual.SetFome(atual.GetFome() + 0.1);
    }

   
}

   

