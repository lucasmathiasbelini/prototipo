using prototipo;
using Microsoft.Maui.Controls;
using System;

namespace prototipo;

public partial class MainPage : ContentPage
{
    Shaco shaco; 
    fofa fofa;
    top Top;
    Personagem atual;
//----------------------------------------------------------------------------------------------------------\\

    public MainPage()
    {
        InitializeComponent(); 
        shaco = new Shaco(); 
        fofa = new fofa();
        Top = new top();

        atual = fofa;

        progressBar2.Progress = atual.GetFome();
        progressBar.Progress = atual.GetSede();

        var Timer = Application.Current.Dispatcher.CreateTimer();
    Timer.Interval = TimeSpan.FromSeconds(6);
    Timer.Tick += (s, e) => passouTempo();
    Timer.Start();
    }

    void Botao1(object sender, EventArgs args)
    {
       atual.SetSede(atual.GetSede() + 0.2);
       progressBar.Progress = atual.GetSede();

    }

    void Botao2(object sender, EventArgs args)
    {
        atual.SetFome(atual.GetFome() + 0.2);
       progressBar2.Progress = atual.GetFome();

       
    }
//----------------------------------------------------------------------------------------------------------\\

    void botaotroca(object sender, EventArgs args)
    {
        if (atual == fofa)
        {
            atual = Top;
        }
        else if (atual == Top)
        {
            atual = fofa;
        }

        ImagemPersonagem.Source = atual.GetArquivo();
    }
//---------------------------------------------------------------------------------------------------------------\\

void passouTempo()
{

        atual.SetFome(atual.GetFome() - 0.2);
       progressBar2.Progress = atual.GetFome();
       atual.SetSede(atual.GetSede() - 0.2);
       progressBar.Progress = atual.GetSede();

}

}


