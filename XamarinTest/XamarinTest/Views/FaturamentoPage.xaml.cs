using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using XamarinTest.Models;
using XamarinTest.Views;
using XamarinTest.ViewModels;

namespace XamarinTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FaturamentoPage : ContentPage
    {
        FaturamentoViewModel viewModel;

        public FaturamentoPage()
        {
            InitializeComponent();


            NavigationPage.SetHasNavigationBar(this, false);

            BindingContext = viewModel = new FaturamentoViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}