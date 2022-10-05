using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AssignMent1
{
    /// <summary>
    /// Interaction logic for NameS.xaml
    /// </summary>
    public partial class NameS : UserControl
    {
        public string name { get; set; } = "by Homer Simpson | Node.js | Posted on Thursday, November 28th 2019,4:36:09 pm";
        public NameS()
        {
            InitializeComponent();
            this.DataContext = this;
        }
       
    }
}
