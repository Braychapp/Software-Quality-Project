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
    /// Interaction logic for AdminMenu.xaml
    /// </summary>
    public partial class AdminMenu : Window
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void Go_To_Config_Click(object sender, RoutedEventArgs e)
        {
            EditConfig edit = new EditConfig();
            edit.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();

        }

        //code copied from https://stackoverflow.com/questions/58744/copy-the-entire-contents-of-a-directory-in-c-sharp
        //from tboswell and edited by User1
        private void BackupDatabase_Click(object sender, RoutedEventArgs e)
        {

            var targetPath = Directory.GetCurrentDirectory();
            //need to create a variable that has the directory of the Database and make that the sourcePath but for now it won't be that

            var sourcePath = "C:\\temp";

            //Now Create all of the directories
            foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
            }

            //Copy all the files & Replaces any files with the same name
            foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
            {
                File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
            }

            MessageBox.Show("Database has been cloned and placed in the current working directory");
        }

    }
}
