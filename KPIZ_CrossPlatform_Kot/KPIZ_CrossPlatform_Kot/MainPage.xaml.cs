using CommunityToolkit.Mvvm.Messaging;
using KPIZ_CrossPlatform_Kot.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KPIZ_CrossPlatform_Kot
{
    public partial class MainPage : ContentPage
    {
        private MainPageViewModel _viewModel;
        private readonly IMessenger _messenger;
        public MainPage()
        {
            _messenger = App.Current.Services.GetService<IMessenger>();
            _viewModel = App.Current.Services.GetService<MainPageViewModel>();
            BindingContext = _viewModel;
            InitializeComponent();
        }
    }
}
