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
using static sessia2_BJA.Entity.Entity;

namespace sessia2_BJA
{
    /// <summary>
    /// Логика взаимодействия для InfoAgent.xaml
    /// </summary>
    public partial class InfoAgent : Window
    {
        public InfoAgent(Agent agent)
        {
            InitializeComponent();
        }
    }
}
