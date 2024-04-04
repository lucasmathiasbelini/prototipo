
namespace prototipo
{
    public partial class MainPage : ContentPage
    {
        Shaco shaco;
        

        public MainPage()
        {
            InitializeComponent();

            shaco = new Shaco();

            
            var timer = Application.Current.Dispatcher.CreateTimer();
            timer.Interval = TimeSpan.FromSeconds(1); 
            timer.Tick += (s, e) => PassouTempo(); 
            timer.Start(); 
        }

        

        void PassouTempo()
        {
            
        }
    }
}
