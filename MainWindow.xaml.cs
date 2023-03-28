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

namespace KMN
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Processing processing = new Processing();



        void GameProcess()
        {
            processing.Set_Pl_Name(Nick.Text);

            if (processing.gaming() == 1)
            {
                Result.Content = "Победа";
                NameWinner.Content = processing.Get_Pl_Name();
            }
            if (processing.gaming() == 0)
            {
                Result.Content = "Проигрышь";
                NameWinner.Content = processing.Get_Bot_Name();
            }
            if (processing.gaming() == 2)
            {
                Result.Content = "Ничья";
                NameWinner.Content = "Никто";
            }
        }

        private void K_Click(object sender, RoutedEventArgs e)
        {
            processing.Set_Pl_Itm("камень");
            processing.BotRnd();

            vibor.Content = processing.Get_Pl_Itm();
            viborBota.Content = processing.Get_Bot_Itm();

            GameProcess();

        }
        private void N_Click(object sender, RoutedEventArgs e)
        {
            processing.Set_Pl_Itm("ножницы");
            processing.BotRnd();

            vibor.Content = processing.Get_Pl_Itm();
            viborBota.Content = processing.Get_Bot_Itm();
            
            GameProcess();
        }
        private void B_Click(object sender, RoutedEventArgs e)
        {
            processing.Set_Pl_Itm("бумага");
            processing.BotRnd();

            vibor.Content = processing.Get_Pl_Itm();
            viborBota.Content = processing.Get_Bot_Itm();

            GameProcess();
        }
    }
}
