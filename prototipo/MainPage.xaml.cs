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
    }

    void Botao1(object sender, EventArgs args)
    {
      progressBar2.Progress = shaco.GetSede() + 0.1;
       
    }

    void Botao2(object sender, EventArgs args)
    {

       progressBar.Progress = shaco.GetFome() + 0.1;
       
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

}


