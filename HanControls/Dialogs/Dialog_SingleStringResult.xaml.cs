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

namespace HanControls.Dialogs
{
    /// <summary>
    /// Dialog_SingleStringResult.xaml 的交互逻辑
    /// </summary>
    public partial class Dialog_SingleStringResult : Window
    {
        public Dialog_SingleStringResult()
        {
            InitializeComponent();
            this.Owner = App.Current.MainWindow;
        }

        private void Completed(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
