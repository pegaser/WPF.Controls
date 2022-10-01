﻿using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace Selections
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void chbMyCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            txbMyTextBlock1.Text = "The CheckBox is checked.";
        }

        private void chbMyCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            txbMyTextBlock1.Text = "The CheckBox is unchecked.";
        }

        private void chbMyCheckBox_Indeterminate(object sender, RoutedEventArgs e)
        {
            txbMyTextBlock1.Text = "The CheckBox is in the indeterminate state.";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cmbMyComboBox.ItemsSource = new Countries();
        }

        private void lsbMyListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txbMyTextBlock2.Text = $"You selected {(lsbMyListBox.SelectedItem as ListBoxItem).Content.ToString()}.";
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton? radioButton = sender as RadioButton;
            if (radioButton is not null)
                txbMyTextBlock3.Text = $"Seleccionaste: {radioButton.Content.ToString()}.";
        }
    }
    class Countries : ObservableCollection<string>
    {
        public Countries()
        {
            Add("España");
            Add("Francia");
            Add("Perú");
            Add("México");
            Add("Italia");
        }
    }
}
