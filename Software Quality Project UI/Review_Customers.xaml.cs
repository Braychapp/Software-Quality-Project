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

namespace Software_Quality_Project_UI
{
    /// <summary>
    /// Interaction logic for Review_Customers.xaml
    /// </summary>
    public partial class Review_Customers : Window
    {
        public Review_Customers()
        {
            InitializeComponent();
            //put the customer history here
            //using a placeholder for now but PLEASE DELETE BEFORE SUBMISSION
            //below this line it needs to grab the existing customers orders information from the SQL Database
            ExistingCustomers.Text = "tripID: 12345678910\nbuyerID: 67836\ndriverID: 932874\ndate ordered: 2022-12-03\ncargo: tables\nweight: 127.53KG\nstart location: Toronto\nend location: Mississauga\nprice: $1504.98\nstatus: completed\n\n\n";
        }
    }
}
