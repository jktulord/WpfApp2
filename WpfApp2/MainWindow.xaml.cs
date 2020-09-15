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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddInt(int line)
        {
            KindaConsol.Items.Add(line);
        }
        private void AddString(string line)
        {
            KindaConsol.Items.Add(line);
        }

        private void OperationOnClick(object sender, RoutedEventArgs e)
        {
            out_block.Text = "Размер :" + N.Text + " на " + M.Text;
            int local_sum = 0;
            int sum = 0;
            
            int n = 1;
            int m = 1;
            try
            {
                n = Convert.ToInt32(N.Text);
                m = Convert.ToInt32(M.Text);

            }
            catch
            {
                out_block.Text = "Ошибка";
            }
            
            int[][] a =
            {
                new int[] { },
                new int[] { },
                new int[] { }
            }; 
            AddString("Масссив");
            string Line = "";
            for e 
            {
                Line = "";
                for (int j = 0; j < m; j++)
                {
                    a[i][j] = j+1;
                    Line += Convert.ToString(j+1) + " ";
                    local_sum += j+1;
                }
                a[i][m] = local_sum / m;
                sum += local_sum;
                local_sum = 0;
                AddString(Line);

            }
            for (int i = 0; i < n; i++)
            {
                AddString("Среднее арифмитическое строки " + Convert.ToString(i+1) +" = " + Convert.ToString(a[i,m]));
            }
            AddString("Среднее общее арифмитическое :"+Convert.ToString(sum / (n * m)));

        }
    }
}


