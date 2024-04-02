using Avalonia.Controls;
using Avalonia.Interactivity;
using Binding.Models;
using Binding.ViewModels;

namespace Binding.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new Lalala();
    }
    private void AddButton_Click(object sender, RoutedEventArgs e)
    {
        var newProduct = new Lalala()
        {
            Name = name.Text,
            Surname = surname.Text,
            FullName = $"{name.Text} {surname.Text}"
        };

        (DataContext as MainWindowViewModel)?.People.Add(newProduct);

        name.Text = string.Empty;
        surname.Text = string.Empty;
    }
}