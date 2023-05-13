using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using KPIZ_CrossPlatform_Kot.Abstractions;
using KPIZ_CrossPlatform_Kot.Models;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

namespace KPIZ_CrossPlatform_Kot.ViewModels
{
    public class MainPageViewModel : ObservableRecipient
    {
        private IPunkApi _punkApiService;
        private ObservableCollection<Beer> _beers;

        public ObservableCollection<Beer> Beers { get => _beers; set => SetProperty(ref _beers, value); }

        public AsyncRelayCommand RequestCommand { get; } 
        public MainPageViewModel(IMessenger messenger, IPunkApi punkApiService) : base(messenger)
        {
            _punkApiService = punkApiService;
            RequestCommand = new AsyncRelayCommand(OnRequesting);
            Beers = new ObservableCollection<Beer>();
        }

        private async Task OnRequesting()
        {
            try
            {
                Beers = await _punkApiService.GetBeers();
                Debug.WriteLine(Beers);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}