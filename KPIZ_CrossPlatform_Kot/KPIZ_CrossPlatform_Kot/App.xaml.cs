using CommunityToolkit.Mvvm.Messaging;
using KPIZ_CrossPlatform_Kot.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Refit;
using KPIZ_CrossPlatform_Kot.Abstractions;
using System.Net.Http;
using AutoMapper;
using KPIZ_CrossPlatform_Kot.Models;
using KPIZ_CrossPlatform_Kot.Profiles;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace KPIZ_CrossPlatform_Kot
{
    public partial class App : Application
    {
        public new static App Current => (App)Application.Current;
        public IServiceProvider Services { get; }
        public App()
        {
            InitializeComponent();
            Services = ConfigureServices();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
        private IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<MainPageViewModel>();
            services.AddSingleton<IMessenger, WeakReferenceMessenger>();
            services.AddAutoMapper(m => m.AddProfile<ApplicationProfile>());
            services.AddRefitClient<IPunkApi>()
                .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://api.punkapi.com/v2/"))
                .ConfigurePrimaryHttpMessageHandler(_ => new HttpClientHandler
                {
                    ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; }

                });
            return services.BuildServiceProvider();
        }
    }
}
