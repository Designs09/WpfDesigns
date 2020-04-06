﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class WPFBasics : Window
    {
        public WPFBasics()
        {
            InitializeComponent();

        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"The description text is: {this.DescriptionText.Text}");
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {

            this.WeldCheckBox.IsChecked =
            this.AssemblyCheckBox.IsChecked =
            this.PlasamaCheckBox.IsChecked =
            this.LaserCheckBox.IsChecked =
            this.PurchaseCheckBox.IsChecked =
            this.LatheCheckBox.IsChecked =
            this.DrillCheckBox.IsChecked =
            this.FoldCheckBox.IsChecked =
            this.RollCheckBox.IsChecked =
            this.SawCheckBox.IsChecked = false;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            this.LengthTextBox.Text += ((CheckBox)sender).Content;
        }

        private void FinishDropDown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.NoteText == null) return;

            var comb = (ComboBox)sender;
            var item = (ComboBoxItem)comb.SelectedValue;

            this.NoteText.Text = (string)item.Content;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FinishDropDown_SelectionChanged(this.FinishDropDown, null);
        }

        private void SupplierNameText_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.MassText.Text = this.SupplierNameText.Text;
        }
    }
}
