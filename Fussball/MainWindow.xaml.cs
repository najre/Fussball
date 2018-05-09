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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fussball
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            using (var db = new FussballBundesligaDatenEntities1())
            {
                var queue = from b in db.Teams orderby b.TeamNameLang select b;

                foreach ( var item in queue)
                {
                    BOX.Text = item + System.Environment.NewLine;
                }
            }
        }
    }
}
