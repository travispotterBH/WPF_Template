using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WPF_Template.UserControls
{
    public partial class StandardCloseAndOkButtons : UserControl
    {
        public static readonly DependencyProperty OkProperty =
            DependencyProperty.Register(
                "Ok",
                typeof(ICommand),
                typeof(StandardCloseAndOkButtons),
                new UIPropertyMetadata(null));
        public ICommand Ok
        {
            get { return (ICommand)GetValue(OkProperty); }
            set { SetValue(OkProperty, value); }
        }

        public static readonly DependencyProperty CancelProperty =
            DependencyProperty.Register(
                "Cancel",
                typeof(ICommand),
                typeof(StandardCloseAndOkButtons),
                new UIPropertyMetadata(null));
        public ICommand Cancel
        {
            get { return (ICommand)GetValue(CancelProperty); }
            set { SetValue(CancelProperty, value); }
        }
        public StandardCloseAndOkButtons()
        {
            InitializeComponent();
        }
    }

}
