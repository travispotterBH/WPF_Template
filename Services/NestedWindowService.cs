using System.Windows;
using WPF_Template.Interface;

namespace WPF_Template.Services
{
    public static class NestedWindowService
    {
        public static void ShowWindowAsDialog(Window window, Window owner, ViewModel ownerViewModel)
        {
            window.Owner = owner;
            (window.DataContext as ViewModel).ParentViewModel = ownerViewModel;
            window.ShowDialog();
        }
    }
}
