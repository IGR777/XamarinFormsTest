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
    public partial class UsersPage : ContentPage
    {
        public UsersPage()
        {
            InitializeComponent();
            BindingContext = new UserViewModel();
        }

        public void OnItemTapped(object sender, ItemTappedEventArgs args)
        {
            Navigation.PushAsync(new CalcPage(args.Item as User));
        }

        public void OnAddTapped(object sender, EventArgs args)
        {
            Navigation.PushAsync(new CalcPage());
        }
    }
}
