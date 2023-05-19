using Fat_Secret_MVVM.Model;
using Fat_Secret_MVVM.View;
using Fat_Secret_MVVM.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Fat_Secret_MVVM.ViewModel
{
    internal class StatisticWindow : BindingHelper
    {
        #region Commands
        public BindableCommand bc { get;set; }
        #endregion

        #region Svoystva
        public static string date {get;set;}
        public int belki { get;set;}
        public int uglevodi {get;set;}
        public int zhiri { get; set; }
        public string result { get;set;}
        #endregion


        public StatisticWindow()
        {
            load_info();
            bc = new BindableCommand(_ => back());
        }

        public void back()
        {
            MainWindow win = new MainWindow();
            win.Show();
            Window3 win1 = Application.Current.Windows.OfType<Window3>().FirstOrDefault();
            if (win1 != null)
            {
                win1.Close();
            }
        }

        private void load_info()
        {
            foreach(Mymodel2 model in MenuWindow.Mymodels2)
            {
                int first_dot = model.date.IndexOf(".");
                int second_dot = model.date.LastIndexOf(".");
                string month = model.date.Substring(first_dot + 1, second_dot - first_dot - 1);

                if(month == MainWindowViewModel.curr_date_datetime.Month.ToString())
                {
                    foreach (Mymodel m2 in model.list)
                    {
                        if(m2.name == "Белок")
                        {
                            belki = belki + m2.calories;
                        }
                        else if(m2.name == "Углеводы")
                        {
                            uglevodi = uglevodi + m2.calories;
                        }
                        else
                        {
                            zhiri = zhiri + m2.calories;
                        }
                    }
                }
                
            }

            if(belki >= 10000)
            {
                result = result + " Вы едите слишком  много белка!\n";
            }
            if(uglevodi >= 10000)
            {
                result = result + " Вы едите слишком много углеводов!\n";
            }
            if(zhiri >= 10000)
            {
                result = result + " Вы едите слишком много жиров!\n";
            }
            if(belki < 10000 & uglevodi < 10000 & zhiri < 10000)
            {
                result = result + " Вы отлично питаетесь, так держать!";
            }
        }
    }
}
