using App17.Helpers;
using App17.Models;
using App17.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App17.Pages
{
    public partial class CalcPage : ContentPage
    {
        public CalcPage(User user=null)
        {
            InitializeComponent();
            BindingContext = new CalcViewModel();

            if (user!=null)
            {
                NameControl.IsEnabled = false;
            }
        }


        public void OnCalculate(object sender, EventArgs args)
        {
            var vm = BindingContext as CalcViewModel;

            vm.CalcCommand.Execute(null);
            Navigation.PushAsync(new UsersPage());
        }
    }
}
