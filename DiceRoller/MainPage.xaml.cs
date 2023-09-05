using System.ComponentModel.Design;

namespace DiceRoller;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    Random rnd = new Random();
    public void OnButtonClicked(object sender, EventArgs args)
    {
        string opcao = DiceOptionsPicker.SelectedItem as string;
        if (opcao == "4")
        {
            int sorte = rnd.Next(1, 5);
            CounterBtn.Text = $"{sorte}";
        }else if (opcao == "6") 
        {
            int sorte = rnd.Next(1, 7);
            CounterBtn.Text = $"{sorte}";
        }else if (opcao == "10")
        {
            int sorte = rnd.Next(1, 11);
            CounterBtn.Text = $"{sorte}";
        }else if (opcao == "20")
        {
            int sorte = rnd.Next(1, 21);
            CounterBtn.Text = $"{sorte}";
        }else
        {
            int sorte = rnd.Next(1, 101);
            CounterBtn.Text = $"{sorte}";
        }
    }
}

   
//if (ctr % 5 == 0)

