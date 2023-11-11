using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_Template.Views
{
    /// <summary>
    /// Interaction logic for SimplePopUpWindow.xaml
    /// </summary>
    public partial class SimplePopUpWindow : Window
    {
        public bool? DialogResult { get; private set; }
        private string m_Prompt;

        public string Prompt
        {
            get { return m_Prompt; }
            set { m_Prompt = value; }
        }

        public SimplePopUpWindow(string prompt)
        {
            InitializeComponent();
            Prompt = prompt;
            DataContext = this;
        }

        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }

        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
