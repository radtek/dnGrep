﻿using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace dnGREP.WPF
{
    /// <summary>
    /// Interaction logic for TestPattern.xaml
    /// </summary>
    public partial class TestPattern : ThemedWindow
    {
        private TestPatternViewModel inputData = new TestPatternViewModel();

        public TestPattern()
        {
            InitializeComponent();
            this.DataContext = inputData;
        }

        private void FormKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                Close();
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            inputData.SaveSettings();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnCopyFile_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(inputData.ReplaceOutputText);
        }
    }
}
