using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Software_Quality_Project_UI
{
    /// <summary>
    /// Interaction logic for EditConfig.xaml
    /// </summary>
    public partial class EditConfig : Window
    {
        public EditConfig()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            {
                Title = "Open File";
            }
            openFileDialog.Filter = "Log files (.*log)|*.log|All files(*.*)|*.*|Config files (*.config)|*.config";
            if (openFileDialog.ShowDialog() == true)
            {
                _TextBox.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Title = "Save File"
            };
            saveFileDialog.Filter = "Log files (.*log)|*.log|All files(*.*)|*.*|Config files (*.config)|*.config";
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, _TextBox.Text);
            }
        }
        }
    }
