using Fat_Secret_MVVM.View;
using Fat_Secret_MVVM.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;

namespace Fat_Secret_MVVM.ViewModel
{
    internal class MainWindowViewModel: BindingHelper
    {
        #region Команды
        public BindableCommand swipenext { get; set; }
        public BindableCommand swipeback { get; set; }
        public BindableCommand click1 { get; set; }
        public BindableCommand click2 { get; set; }
        public BindableCommand click3 { get; set; }
        public BindableCommand click4 { get; set; }
        public BindableCommand click5 { get; set; }
        public BindableCommand click6 { get; set; }
        public BindableCommand click7 { get; set; }
        public BindableCommand click8 { get; set; }
        public BindableCommand click9 { get; set; }
        public BindableCommand click10 { get; set; }
        public BindableCommand click11 { get; set; }
        public BindableCommand click12 { get; set; }
        public BindableCommand click13 { get; set; }
        public BindableCommand click14 { get; set; }
        public BindableCommand click15 { get; set; }
        public BindableCommand click16 { get; set; }
        public BindableCommand click17 { get; set; }
        public BindableCommand click18 { get; set; }
        public BindableCommand click19 { get; set; }
        public BindableCommand click20 { get; set; }
        public BindableCommand click21 { get; set; }
        public BindableCommand click22 { get; set; }
        public BindableCommand click23 { get; set; }
        public BindableCommand click24 { get; set; }
        public BindableCommand click25 { get; set; }
        public BindableCommand click26 { get; set; }
        public BindableCommand click27 { get; set; }
        public BindableCommand click28 { get; set; }
        public BindableCommand click29 { get; set; }
        public BindableCommand click30 { get; set; }
        public BindableCommand click31 { get; set; }
        public BindableCommand stat { get; set; }

        #endregion

        #region Свойства
        private string Date;
        private string Date2;
        private string Date3;
        private string Date4;
        private string Date5;
        private string Date6;
        private string Date7;
        private string Date8;
        private string Date9;
        private string Date10;
        private string Date11;
        private string Date12;
        private string Date13;
        private string Date14;
        private string Date15;
        private string Date16;
        private string Date17;
        private string Date18;
        private string Date19;
        private string Date20;
        private string Date21;
        private string Date22;
        private string Date23;
        private string Date24;
        private string Date25;
        private string Date26;
        private string Date27;
        private string Date28;
        private string Date29;
        private string Date30;
        private string Date31;

        private Visibility notshow;
        public Visibility notshow1
        {
            get { return notshow; }
            set
            {
                notshow = value;
                OnPropertyChanged();
            }
        }
        public Visibility notshow2
        {
            get { return notshow; }
            set
            {
                notshow = value;
                OnPropertyChanged();
            }
        }
        public Visibility notshow3
        {
            get { return notshow; }
            set
            {
                notshow = value;
                OnPropertyChanged();
            }
        }
        public string date1
        {
            get
            {
                return Date;
            }
            set
            {
                Date = value;
                OnPropertyChanged();
            }
        }
        public string date2
        {
            get { return Date2;}
            set
            {
                Date2= value;
                OnPropertyChanged();
            }
        }
        public string date3
        {
            get { return Date3; }
            set
            {
                Date3 = value;
                OnPropertyChanged();
            }
        }
        public string date4
        {
            get { return Date4; }
            set
            {
                Date4 = value;
                OnPropertyChanged();
            }
        }
        public string date5
        {
            get { return Date5; }
            set
            {
                Date5 = value;
                OnPropertyChanged();
            }
        }
        public string date6
        {
            get { return Date6; }
            set
            {
                Date6 = value;
                OnPropertyChanged();
            }
        }
        public string date7
        {
            get { return Date7; }
            set
            {
                Date7 = value;
                OnPropertyChanged();
            }
        }
        public string date8
        {
            get { return Date8; }
            set
            {
                Date8 = value;
                OnPropertyChanged();
            }
        }
        public string date9
        {
            get { return Date9; }
            set
            {
                Date9 = value;
                OnPropertyChanged();
            }
        }
        public string date10
        {
            get { return Date10; }
            set
            {
                Date10 = value;
                OnPropertyChanged();
            }
        }
        public string date11
        {
            get { return Date11; }
            set
            {
                Date11= value;
                OnPropertyChanged();
            }
        }
        public string date12
        {
            get { return Date12; }
            set
            {
                Date12 = value;
                OnPropertyChanged();
            }
        }
        public string date13
        {
            get { return Date13; }
            set
            {
                Date13 = value;
                OnPropertyChanged();
            }
        }
        public string date14
        {
            get { return Date14; }
            set
            {
                Date14 = value;
                OnPropertyChanged();
            }
        }
        public string date15
        {
            get { return Date15; }
            set
            {
                Date15 = value;
                OnPropertyChanged();
            }
        }
        public string date16
        {
            get { return Date16; }
            set
            {
                Date16 = value;
                OnPropertyChanged();
            }
        }
        public string date17
        {
            get { return Date17; }
            set
            {
                Date17 = value;
                OnPropertyChanged();
            }
        }
        public string date18
        {
            get { return Date18; }
            set
            {
                Date18 = value;
                OnPropertyChanged();
            }
        }
        public string date19
        {
            get { return Date19; }
            set
            {
                Date19 = value;
                OnPropertyChanged();
            }
        }
        public string date20
        {
            get { return Date20; }
            set
            {
                Date20 = value;
                OnPropertyChanged();
            }
        }
        public string date21
        {
            get { return Date21; }
            set
            {
                Date21 = value;
                OnPropertyChanged();
            }
        }
        public string date22
        {
            get { return Date22; }
            set
            {
                Date22 = value;
                OnPropertyChanged();
            }
        }
        public string date23
        {
            get { return Date23; }
            set
            {
                Date23 = value;
                OnPropertyChanged();
            }
        }
        public string date24
        {
            get { return Date24; }
            set
            {
                Date24 = value;
                OnPropertyChanged();
            }
        }
        public string date25
        {
            get { return Date25; }
            set
            {
                Date25 = value;
                OnPropertyChanged();
            }
        }
        public string date26
        {
            get { return Date26; }
            set
            {
                Date26 = value;
                OnPropertyChanged();
            }
        }
        public string date27
        {
            get { return Date27; }
            set
            {
                Date27 = value;
                OnPropertyChanged();
            }
        }
        public string date28
        {
            get { return Date28; }
            set
            {
                Date28 = value;
                OnPropertyChanged();
            }
        }
        public string date29
        {
            get { return Date29; }
            set
            {
                Date29 = value;
                OnPropertyChanged();
            }
        }
        public string date30
        {
            get { return Date30; }
            set
            {
                Date30 = value;
                OnPropertyChanged();
            }
        }
        public string date31
        {
            get { return Date31; }
            set
            {
                Date31 = value;
                OnPropertyChanged();
            }
        }
        public static DateTime curr_date_datetime = DateTime.Now;
        public static string curr_string_date = DateTime.Now.ToString("MMMM, yyyy");
        public string str_date
        {
            get { return curr_string_date; }
            set
            {
                curr_string_date = value;
                OnPropertyChanged();
            }
        }

        private int days_in_curr_date = DateTime.DaysInMonth(curr_date_datetime.Year, curr_date_datetime.Month);
        #endregion


        public MainWindowViewModel()
        {
            Buttons_visibility(days_in_curr_date);
            buttons_text();
            swipenext = new BindableCommand(_ => next());
            swipeback = new BindableCommand(_ => back());
            click1 = new BindableCommand(_ => button1_click());
            click2 = new BindableCommand(_ => button2_click());
            click3 = new BindableCommand((_ => button3_click()));
            click4 = new BindableCommand(_ => button4_click());
            click5 = new BindableCommand(_ => button5_click());
            click6 = new BindableCommand(_ => button6_click());
            click7 = new BindableCommand(_ => button7_click());
            click8 = new BindableCommand(_ => button8_click());
            click9 = new BindableCommand(_ => button9_click());
            click10 = new BindableCommand(_ => button10_click());
            click11 = new BindableCommand(_ => button11_click());
            click12 = new BindableCommand(_ => button12_click());
            click13 = new BindableCommand(_ => button13_click());
            click14 = new BindableCommand(_ => button14_click());
            click15 = new BindableCommand(_ => button15_click());
            click16 = new BindableCommand(_ => button16_click());
            click17 = new BindableCommand(_ => button17_click());
            click18 = new BindableCommand(_ => button18_click());
            click19 = new BindableCommand(_ => button19_click());
            click20 = new BindableCommand(_ => button20_click());
            click21 = new BindableCommand(_ => button21_click());
            click22 = new BindableCommand(_ => button22_click());
            click23 = new BindableCommand(_ => button23_click());
            click24 = new BindableCommand(_ => button24_click());
            click25 = new BindableCommand(_ => button25_click());
            click26 = new BindableCommand(_ => button26_click());
            click27= new BindableCommand(_ => button27_click());
            click28 = new BindableCommand(_ => button28_click());
            click29 = new BindableCommand(_ => button29_click());
            click30 = new BindableCommand(_ => button30_click());
            click31 = new BindableCommand(_ => button31_click());
            stat = new BindableCommand(_ => statistics_click());
        }


        private int Buttons_visibility(int d)
        {
            if(d == 29)
            {
                notshow3 = Visibility.Hidden;
                notshow1= Visibility.Hidden;
                return 0;
            }
            else
            {
                notshow3 = Visibility.Visible;
                notshow1= Visibility.Visible;
            }
            if (d == 28)
            {
                notshow2 = Visibility.Hidden;
                notshow1 = Visibility.Hidden;
                notshow3 = Visibility.Hidden;
                return 0;
            }
            else
            {
                notshow2 = Visibility.Visible;
                notshow1 = Visibility.Visible;
                notshow3 = Visibility.Visible;
            }
            if (d == 30)
            {
                notshow1 = Visibility.Hidden;
                return 0;
            }
            else
            {
                notshow1 = Visibility.Visible;
            }
            return 0;
        }

        private void buttons_text()
        {
            date1 = "1";
            date2 = "2";
            date3 = "3";
            date4 = "4";
            date5 = "5";
            date6 = "6";
            date7 = "7";
            date8 = "8";
            date9 = "9";
            date10 = "10";
            date11 = "11";
            date12 = "12";
            date13 = "13";
            date14 = "14";
            date15 = "15";
            date16 = "16";
            date17 = "17";
            date18 = "18";
            date19 = "19";
            date20 = "20";
            date21 = "21";
            date22 = "22";
            date23 = "23";
            date24 = "24";
            date25 = "25";
            date26 = "26";
            date27 = "27";
            date28 = "28";
            date29 = "29";
            date30 = "30";
            date31 = "31";
        }

        public void next()
        {
            int month = curr_date_datetime.Month;
            int year = curr_date_datetime.Year;
            int day = 1;
            month += 1;
            if(month == 13)
            {
                month = 1;
                curr_date_datetime = new DateTime(year + 1, month, day);    
            }
            else
            {
                curr_date_datetime = new DateTime(year, month, day);
            }
            days_in_curr_date = DateTime.DaysInMonth(curr_date_datetime.Year, curr_date_datetime.Month);
            Buttons_visibility(days_in_curr_date);
            buttons_text();
            str_date = curr_date_datetime.ToString("MMMM, yyyy");
        }

        public void back()
        {
            int month = curr_date_datetime.Month;
            int year = curr_date_datetime.Year;
            int day = 1;
            month -= 1;
            if (month == 0)
            {
                month = 12;
                curr_date_datetime = new DateTime(year - 1, month, day);
            }
            else
            {
                curr_date_datetime = new DateTime(year, month, day);
            }
            days_in_curr_date = DateTime.DaysInMonth(curr_date_datetime.Year, curr_date_datetime.Month);
            Buttons_visibility(days_in_curr_date);
            buttons_text();
            str_date = curr_date_datetime.ToString("MMMM, yyyy");
        }

        public void button1_click()
        {
            MenuWindow.str_date = date1 + "." + curr_date_datetime.Month + "." + curr_date_datetime.Year;
            Window2 win2 = new Window2();
            win2.Show();
            MainWindow win = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (win != null)
            {
                win.Close();
            }
        }
        public void button2_click()
        {
            MenuWindow.str_date = date2 + "." + curr_date_datetime.Month + "." + curr_date_datetime.Year;
            Window2 win2 = new Window2();
            win2.Show();
            MainWindow win = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (win != null)
            {
                win.Close();
            }
        }
        public void button3_click()
        {
            MenuWindow.str_date = date3 + "." + curr_date_datetime.Month + "." + curr_date_datetime.Year;
            Window2 win2 = new Window2();
            win2.Show();
            MainWindow win = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (win != null)
            {
                win.Close();
            }
        }
        public void button4_click()
        {
            MenuWindow.str_date = date4 + "." + curr_date_datetime.Month + "." + curr_date_datetime.Year;
            Window2 win2 = new Window2();
            win2.Show();
            MainWindow win = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (win != null)
            {
                win.Close();
            }
        }
        public void button5_click()
        {
            MenuWindow.str_date = date5 + "." + curr_date_datetime.Month + "." + curr_date_datetime.Year;
            Window2 win2 = new Window2();
            win2.Show();
            MainWindow win = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (win != null)
            {
                win.Close();
            }
        }
        public void button6_click()
        {
            MenuWindow.str_date = date6 + "." + curr_date_datetime.Month + "." + curr_date_datetime.Year;
            Window2 win2 = new Window2();
            win2.Show();
            MainWindow win = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (win != null)
            {
                win.Close();
            }
        }
        public void button7_click()
        {
            MenuWindow.str_date = date7 + "." + curr_date_datetime.Month + "." + curr_date_datetime.Year;
            Window2 win2 = new Window2();
            win2.Show();
            MainWindow win = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (win != null)
            {
                win.Close();
            }
        }
        public void button8_click()
        {
            MenuWindow.str_date = date8 + "." + curr_date_datetime.Month + "." + curr_date_datetime.Year;
            Window2 win2 = new Window2();
            win2.Show();
            MainWindow win = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (win != null)
            {
                win.Close();
            }
        }
        public void button9_click()
        {
            MenuWindow.str_date = date9 + "." + curr_date_datetime.Month + "." + curr_date_datetime.Year;
            Window2 win2 = new Window2();
            win2.Show();
            MainWindow win = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (win != null)
            {
                win.Close();
            }
        }
        public void button10_click()
        {
            MenuWindow.str_date = date10 + "." + curr_date_datetime.Month + "." + curr_date_datetime.Year;
            Window2 win2 = new Window2();
            win2.Show();
            MainWindow win = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (win != null)
            {
                win.Close();
            }
        }
        public void button11_click()
        {
            MenuWindow.str_date = date11 + "." + curr_date_datetime.Month + "." + curr_date_datetime.Year;
            Window2 win2 = new Window2();
            win2.Show();
            MainWindow win = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (win != null)
            {
                win.Close();
            }
        }
        public void button12_click()
        {
            MenuWindow.str_date = date12 + "." + curr_date_datetime.Month + "." + curr_date_datetime.Year;
            Window2 win2 = new Window2();
            win2.Show();
            MainWindow win = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (win != null)
            {
                win.Close();
            }
        }
        public void button13_click()
        {
            MenuWindow.str_date = date13 + "." + curr_date_datetime.Month + "." + curr_date_datetime.Year;
            Window2 win2 = new Window2();
            win2.Show();
            MainWindow win = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (win != null)
            {
                win.Close();
            }
        }
        public void button14_click()
        {
            MenuWindow.str_date = date14 + "." + curr_date_datetime.Month + "." + curr_date_datetime.Year;
            Window2 win2 = new Window2();
            win2.Show();
            MainWindow win = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (win != null)
            {
                win.Close();
            }
        }
        public void button15_click()
        {
            MenuWindow.str_date = date15 + "." + curr_date_datetime.Month + "." + curr_date_datetime.Year;
            Window2 win2 = new Window2();
            win2.Show();
            MainWindow win = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (win != null)
            {
                win.Close();
            }
        }
        public void button16_click()
        {
            MenuWindow.str_date = date16 + "." + curr_date_datetime.Month + "." + curr_date_datetime.Year;
            Window2 win2 = new Window2();
            win2.Show();
            MainWindow win = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (win != null)
            {
                win.Close();
            }
        }
        public void button17_click()
        {
            MenuWindow.str_date = date17 + "." + curr_date_datetime.Month + "." + curr_date_datetime.Year;
            Window2 win2 = new Window2();
            win2.Show();
            MainWindow win = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (win != null)
            {
                win.Close();
            }
        }
        public void button18_click()
        {
            MenuWindow.str_date = date18 + "." + curr_date_datetime.Month + "." + curr_date_datetime.Year;
            Window2 win2 = new Window2();
            win2.Show();
            MainWindow win = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (win != null)
            {
                win.Close();
            }
        }
        public void button19_click()
        {
            MenuWindow.str_date = date19 + "." + curr_date_datetime.Month + "." + curr_date_datetime.Year;
            Window2 win2 = new Window2();
            win2.Show();
            MainWindow win = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (win != null)
            {
                win.Close();
            }
        }
        public void button20_click()
        {
            MenuWindow.str_date = date20 + "." + curr_date_datetime.Month + "." + curr_date_datetime.Year;
            Window2 win2 = new Window2();
            win2.Show();
            MainWindow win = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (win != null)
            {
                win.Close();
            }
        }
        public void button21_click()
        {
            MenuWindow.str_date = date21 + "." + curr_date_datetime.Month + "." + curr_date_datetime.Year;
            Window2 win2 = new Window2();
            win2.Show();
            MainWindow win = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (win != null)
            {
                win.Close();
            }
        }
        public void button22_click()
        {
            MenuWindow.str_date = date22 + "." + curr_date_datetime.Month + "." + curr_date_datetime.Year;
            Window2 win2 = new Window2();
            win2.Show();
            MainWindow win = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (win != null)
            {
                win.Close();
            }
        }
        public void button23_click()
        {
            MenuWindow.str_date = date23 + "." + curr_date_datetime.Month + "." + curr_date_datetime.Year;
            Window2 win2 = new Window2();
            win2.Show();
            MainWindow win = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (win != null)
            {
                win.Close();
            }
        }
        public void button24_click()
        {
            MenuWindow.str_date = date24 + "." + curr_date_datetime.Month + "." + curr_date_datetime.Year;
            Window2 win2 = new Window2();
            win2.Show();
            MainWindow win = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (win != null)
            {
                win.Close();
            }
        }
        public void button25_click()
        {
            MenuWindow.str_date = date25 + "." + curr_date_datetime.Month + "." + curr_date_datetime.Year;
            Window2 win2 = new Window2();
            win2.Show();
            MainWindow win = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (win != null)
            {
                win.Close();
            }
        }
        public void button26_click()
        {
            MenuWindow.str_date = date26 + "." + curr_date_datetime.Month + "." + curr_date_datetime.Year;
            Window2 win2 = new Window2();
            win2.Show();
            MainWindow win = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (win != null)
            {
                win.Close();
            }
        }
        public void button27_click()
        {
            MenuWindow.str_date = date27 + "." + curr_date_datetime.Month + "." + curr_date_datetime.Year;
            Window2 win2 = new Window2();
            win2.Show();
            MainWindow win = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (win != null)
            {
                win.Close();
            }
        }
        public void button28_click()
        {
            MenuWindow.str_date = date28 + "." + curr_date_datetime.Month + "." + curr_date_datetime.Year;
            Window2 win2 = new Window2();
            win2.Show();
            MainWindow win = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (win != null)
            {
                win.Close();
            }
        }
        public void button29_click()
        {
            MenuWindow.str_date = date29 + "." + curr_date_datetime.Month + "." + curr_date_datetime.Year;
            Window2 win2 = new Window2();
            win2.Show();
            MainWindow win = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (win != null)
            {
                win.Close();
            }
        }
        public void button30_click()
        {
            MenuWindow.str_date = date30 + "." + curr_date_datetime.Month + "." + curr_date_datetime.Year;
            Window2 win2 = new Window2();
            win2.Show();
            MainWindow win = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (win != null)
            {
                win.Close();
            }
        }
        public void button31_click()
        {
            MenuWindow.str_date = date31 + "." + curr_date_datetime.Month + "." + curr_date_datetime.Year;
            Window2 win2 = new Window2();
            win2.Show();
            MainWindow win = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (win != null)
            {
                win.Close();
            }
        }

        public void statistics_click()
        {
            StatisticWindow.date = curr_date_datetime.ToString("MMMM, yyyy");
            Window3 win3 = new Window3();
            win3.Show();
            MainWindow win = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (win != null)
            {
                win.Close();
            }

        }


    }

}
