﻿using AutoMapper;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using KPIZ_CrossPlatform_Kot.Abstractions;
using KPIZ_CrossPlatform_Kot.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace KPIZ_CrossPlatform_Kot.ViewModels
{
    public class MainPageViewModel : ObservableRecipient
    {
        private IPunkApi _punkApiService;
        private ObservableCollection<Beer> _beers;
        private bool _isLoading;

        private string _beerName;

        public ObservableCollection<Beer> Beers 
        { 
            get => _beers;
            set
            {
                SetProperty(ref _beers, value);
            }
        }
        public string BeerName 
        { 
            get => _beerName;
            set
            {
                SetProperty(ref _beerName, value);
            }
        }

        public bool IsLoading
        {
            get => _isLoading;
            set => SetProperty(ref _isLoading, value);
        }

        public AsyncRelayCommand FindBeerCommand { get; }

        public MainPageViewModel(IMessenger messenger, IPunkApi punkApiService) : base(messenger)
        {
            _punkApiService = punkApiService;
            Beers = new ObservableCollection<Beer>();
            FindBeerCommand = new AsyncRelayCommand(OnFindingBeerAsync);
            IsLoading = true;
        }

        private async Task OnFindingBeerAsync()
        {
            IsLoading = true;
            var beers = string.IsNullOrEmpty(BeerName) ? await _punkApiService.GetBeers() : await _punkApiService.GetBeers(BeerName);
            if (!Beers.SequenceEqual(beers))
            {
                Beers = new ObservableCollection<Beer>(beers);
            }
            IsLoading = false;
        }
    }
}