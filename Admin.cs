using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace SoftwareQuality
{
    internal class Admin
    {
        private string Name { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }


        // Admin may access general configuration options for TMS, such as selecting directories for log files
        private void SelectLogDirectory(string directoryPath)
        {
            try
            {
                Directory.SetCurrentDirectory(directoryPath);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Specified directory does not exist: " + e.Message);
            }

        }

        // targeting IP address and ports for all DBMS communications
        private void SetIPAddressAndPort(int newIp, int port)
        {

        }

        // Admin may review logfiles without leaving the TMS application
        private void ReviewLogFile(string filePathName)
        {
            try
            {
                string text = System.IO.File.ReadAllText(filePathName);
            }
            catch (Exception e)
            {
                Console.WriteLine("Issue reading file: " + e.Message);
            }
            
        }

        // Admin may initiate a backup job on the local TMS Database, specifying the directory for the backup files to be produced
        private void InitiateDatabaseBackup(string backupFiles)
        {

        }



        private void AlterRates (decimal newRate)
        {

        }

        private void AlterCarrierData()
        {

        }

        private void AlterRouteTable()
        {

        }
    }
}
