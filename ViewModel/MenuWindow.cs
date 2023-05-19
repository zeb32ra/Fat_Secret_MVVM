using Fat_Secret_MVVM.ViewModel.Helpers;
using Fat_Secret_MVVM.View;
using Fat_Secret_MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.VisualBasic;

namespace Fat_Secret_MVVM.ViewModel
{
    internal class MenuWindow: BindingHelper
    {
        #region Commands
        public BindableCommand cl_back { get; set; }
        public BindableCommand ch1 { get; set; }
        public BindableCommand ch2 { get; set; }
        public BindableCommand ch3 { get; set; }
        public BindableCommand ch4 { get; set; }
        public BindableCommand ch5 { get; set; }
        public BindableCommand back_save { get; set; }
        #endregion

        #region Svoystva
        public static string str_date { get; set; }
        public static string check1_num { get; set; } = "1";
        public static string check2_num { get; set; } = "2";
        public static string check3_num { get; set; } = "3";
        public static string check4_num { get; set; } = "4";
        public static string check5_num { get; set; } = "5";
        public static List<Mymodel> Mymodels { get; set; } = new List<Mymodel>();
        public static List<Mymodel> Mymodels_copy { get; set; } = new List<Mymodel>();
        public static List<Mymodel2> Mymodels2 { get; set; } = Generics.MyDeserialize<List<Mymodel2>>("MVVM.json");
        private int total_cal;
        public int cal
        {
            get { return total_cal; }
            set
            {
                total_cal = value;
                OnPropertyChanged();
            }
        }

        public bool isch1 { get; set; }
        public bool isch2 { get; set; }
        public bool isch3 { get; set; }
        public bool isch4 { get; set; }
        public bool isch5 { get; set; }


        #endregion

        public MenuWindow() 
        {
            load();
            cl_back = new BindableCommand(_ => back());
            ch1 = new BindableCommand(_ => check1());
            ch2 = new BindableCommand(_ => check2());
            ch3 = new BindableCommand(_ => check3());
            ch4 = new BindableCommand(_ => check4());
            ch5 = new BindableCommand(_ => check5());
            back_save = new BindableCommand(_ => back_with_save());
        }

        private void load()
        {
            if (Mymodels2 == null)
            {
                Mymodels2 = new List<Mymodel2>();
            }
            foreach(Mymodel2 m in Mymodels2)
            {

                if(m.date == str_date)
                {
                    foreach (Mymodel mod1 in m.list)
                    {
                        if(mod1.number == check1_num)
                        {
                            isch1 = true;
                            check1();
                        }
                        else if(mod1.number == check2_num){
                            isch2 = true;
                            check2();
                        }
                        else if (mod1.number == check3_num)
                        {
                            isch3 = true;
                            check3();
                        }
                        else if (mod1.number == check4_num)
                        {
                            isch4 = true;
                            check4();
                        }
                        else if (mod1.number == check5_num)
                        {
                            isch5 = true;
                            check5();
                        }
                    }
                }
            }
        }

        public void back()
        {
            cal = 0;
            Mymodels.Clear();

            MainWindowViewModel.curr_string_date = MainWindowViewModel.curr_date_datetime.ToString("MMMM, yyyy");
            MainWindow win1 = new MainWindow();
            win1.Show();
            Window2 win = Application.Current.Windows.OfType<Window2>().FirstOrDefault();
            if(win != null)
            {
                win.Close();
            }
        }

        public void back_with_save()
        {
         
            int pos = 0;
            bool found = false;
            for(int i =0; i < Mymodels2.Count; i++)
            {
                if (Mymodels2[i].date == str_date)
                {
                    pos = i;
                    found = true;
                }
            }
            if (found)
            {
                Mymodels2.RemoveAt(pos);
            }

            Mymodel2 model2 = new Mymodel2(str_date, Mymodels);
            Mymodels2.Add(model2);
            Generics.MySerialize(Mymodels2, "MVVM.json");

            cal = 0;
            Mymodels = new List<Mymodel>();

            MainWindowViewModel.curr_string_date = MainWindowViewModel.curr_date_datetime.ToString("MMMM, yyyy");
            MainWindow win1 = new MainWindow();
            win1.Show();
            Window2 win = Application.Current.Windows.OfType<Window2>().FirstOrDefault();
            if(win != null)
            {
                win.Close();
            }
        }

        public int check1()
        {
            Mymodel model = new Mymodel(check1_num, "Белок", 127);
            foreach (Mymodel m in Mymodels)
            {
                if(m.name == model.name & m.number == model.number & m.calories == model.calories)
                {
                    Mymodels.Remove(m);
                    cal = cal - m.calories;
                    return 0;
                }
            }
            Mymodels.Add(model);
            cal = model.calories + cal;
            return 0;
        }
        public int check2()
        {
            Mymodel model = new Mymodel(check2_num, "Белок", 360);
            foreach (Mymodel m in Mymodels)
            {
                if (m.name == model.name & m.number == model.number & m.calories == model.calories)
                {
                    Mymodels.Remove(m);
                    cal = cal - m.calories;
                    return 0;
                }
            }
            Mymodels.Add(model);
            cal = model.calories + cal;
            return 0;
        }
        public int check3()
        {
            Mymodel model = new Mymodel(check3_num, "Углеводы", 560);
            foreach (Mymodel m in Mymodels)
            {
                if (m.name == model.name & m.number == model.number & m.calories == model.calories)
                {
                    Mymodels.Remove(m);
                    cal = cal - m.calories;
                    return 0;
                }
            }
            Mymodels.Add(model);
            cal = model.calories + cal;
            return 0;
        }
        public int check4()
        {
            Mymodel model = new Mymodel(check4_num, "Углеводы", 460);
            foreach (Mymodel m in Mymodels)
            {
                if (m.name == model.name & m.number == model.number & m.calories == model.calories)
                {
                    Mymodels.Remove(m);
                    cal = cal - m.calories;
                    return 0;
                }
            }
            Mymodels.Add(model);
            cal = model.calories + cal;
            return 0;
        }
        public int check5()
        {
            Mymodel model = new Mymodel(check5_num, "Жиры", 420);
            foreach (Mymodel m in Mymodels)
            {
                if (m.name == model.name & m.number == model.number & m.calories == model.calories)
                {
                    Mymodels.Remove(m);
                    cal = cal - m.calories;
                    return 0;
                }
            }
            Mymodels.Add(model);
            cal = model.calories + cal;
            return 0;
        }
    }
}
