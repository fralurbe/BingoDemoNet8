using System.Windows;

namespace BingoDemoNet8;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void GenerarCarton_Click(object sender, RoutedEventArgs e)
    {
        string carton = "Cartón generado: 1, 15, 23, 37, 42";
        MessageBox.Show(carton);
        ResultadoText.Text = carton;
    }
}