using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WPF_Template.UserControls
{
    public partial class StandardImportAndExportButtons : UserControl
    {
        public static readonly DependencyProperty ImportProperty =
            DependencyProperty.Register(
                "Import",
                typeof(ICommand),
                typeof(StandardImportAndExportButtons),
                new UIPropertyMetadata(null));
        public ICommand Import
        {
            get { return (ICommand)GetValue(ImportProperty); }
            set { SetValue(ImportProperty, value); }
        }

        public static readonly DependencyProperty ExportProperty =
            DependencyProperty.Register(
                "Export",
                typeof(ICommand),
                typeof(StandardImportAndExportButtons),
                new UIPropertyMetadata(null));
        public ICommand Export
        {
            get { return (ICommand)GetValue(ExportProperty); }
            set { SetValue(ExportProperty, value); }
        }
        public StandardImportAndExportButtons()
        {
            InitializeComponent();
        }
    }

}
