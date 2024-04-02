namespace Shaco.Forms;

    public partial class MainPage : ContentPage
    {
        Shaco Shaco; 

        public MainPage()
        {
            InitializeComponent();

            Shaco = new Shaco(); 
        }

        void botao1(object sender, EventArgs args) 
        {   
           
            Shaco.SetFome(Shaco.GetFome() + 0.1);
        }
    }
