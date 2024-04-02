using System.Collections.ObjectModel;
using Binding.Models;

namespace Binding.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<Lalala> People { get; set; } = new ();
}