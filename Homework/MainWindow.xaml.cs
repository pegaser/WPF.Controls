using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.Windows;

namespace Homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            await this.ShowMessageAsync("This is the title", "Some message");
        }
        private void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            ToggleSwitch toggleSwitch = sender as ToggleSwitch;
            if (toggleSwitch != null)
            {
                if (toggleSwitch.IsOn == true)
                {
                    progress.IsActive = true;
                    progress.Visibility = Visibility.Visible;
                }
                else
                {
                    progress.IsActive = false;
                    progress.Visibility = Visibility.Collapsed;
                }
            }
        }
    }
}
