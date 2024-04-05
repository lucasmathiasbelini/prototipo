
namespace prototipo
{
    public partial class MainPage : ContentPage
    {
        Shaco shaco;
        

        public MainPage()
        {
            InitializeComponent();

            shaco = new Shaco();
            
            
            shaco.SetFome(shaco.GetFome()+0.1);
            progressBar.Progress = shaco.GetFome();

            
            var timer = Application.Current.Dispatcher.CreateTimer();
            timer.Interval = TimeSpan.FromSeconds(10); 
            timer.Tick += (s, e) => PassouTempo(); 
            timer.Start(); 
        }

          void botao1(object sender, EventArgs args)
        {
            shaco.SetFome(shaco.GetFome() + 0.1);
            progressBar.Progress = shaco.GetFome();
        }

        

        void PassouTempo()
        {
            
        }
    }
}
