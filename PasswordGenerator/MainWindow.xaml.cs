using System;
using System.Windows;

namespace PasswordGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool NeedSpecificChars { get; set;}

        private Generator generator;

        public MainWindow()
        {
            generator = new Generator();
            InitializeComponent();
            
        }

        private void NeedSpecific_Checked(object sender, RoutedEventArgs e)
        {
            NeedSpecificChars = true;
        }

        private void NeedSpecific_Unchecked(object sender, RoutedEventArgs e)
        {
            NeedSpecificChars = false;
        }

        private void Generate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                generator.Size = Convert.ToInt32(PasswordLength.Text);
                generator.IsSpecial = NeedSpecificChars;
                Password.Text = generator.Generate();
            }
            catch (FormatException error)
            {
                Password.Text = error.Message;
            }
        }
    }
}
