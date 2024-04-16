

namespace DiceRoller;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
    private void SortearNumeroAleatorio(object sender, EventArgs e)
    {
        var maxValue = SeletorDeLadosDoDado.SelectedItem;
        var numeroSorteado = new Random().Next(1, (int)maxValue + 1);

        NumeroSorteado.Text = numeroSorteado.ToString();

        UpdateDiceImage((int)maxValue);

    }
    private void UpdateDiceImage(int numSides)
    {
        string imageName;

        switch (numSides)
        {
            case 4:
                imageName = "dice_d4.png";
                break;
            case 6:
                imageName = "dice_d6.png";
                break;
            case 8:
                imageName = "dice_d8.png";
                break;
            case 10:
                imageName = "dice_d10.png";
                break;
            case 12:
                imageName = "dice_d12.png";
                break;
            case 20:
                imageName = "dice_d20.png";
                break;
            case 100:
                imageName = "dice_d100.png";
                break;
            default:
                imageName = "dice_default.png"; // Defina uma imagem padrão para outros valores
                break;
        }
        opa.Source = new FileImageSource {File = imageName};
    }
}