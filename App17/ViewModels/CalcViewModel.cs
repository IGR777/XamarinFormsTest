using App17.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace App17.ViewModels
{
    public class CalcViewModel : INotifyPropertyChanged
    {

        string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }


        double _arg1;
        public double Arg1
        {
            get
            {
                return _arg1;
            }
            set
            {
                _arg1 = value;
                OnPropertyChanged("Arg1");
            }
        }


        double _arg2;
        public double Arg2
        {
            get
            {
                return _arg2;
            }
            set
            {
                _arg2 = value;
                OnPropertyChanged("Arg2");
            }
        }


        double _result;
        public double Result
        {
            get
            {
                return _result;
            }
            set
            {
                _result = value;
                OnPropertyChanged("Result");
            }
        }

        public ICommand CalcCommand
        {
            get
            {
                return new Command(()=>
                {
                    Result = Arg1 + Arg2;
                    UserHelper.Instance.AddOrUpdate(new Models.User
                    {
                        Name = Name,
                        Result = Result
                    });

                });
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}

