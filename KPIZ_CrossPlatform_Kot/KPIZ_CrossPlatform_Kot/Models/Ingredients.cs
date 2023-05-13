using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Text.Json.Serialization;

namespace KPIZ_CrossPlatform_Kot.Models
{
    public class Ingredients : ObservableObject
    {
        private ObservableCollection<Malt> _malt;
        private ObservableCollection<Hop> _hops;
        private string _yeast;

        [JsonPropertyName("malt")]
        public ObservableCollection<Malt> Malt { get => _malt; set => SetProperty(ref _malt, value); }

        [JsonPropertyName("hops")]
        public ObservableCollection<Hop> Hops { get => _hops; set => SetProperty(ref _hops, value); }

        [JsonPropertyName("yeast")]
        public string Yeast { get => _yeast; set => SetProperty(ref _yeast, value); }

        public Ingredients()
        {
            ObservableCollection<Malt> malt = new ObservableCollection<Malt>();
            ObservableCollection<Hop> hops = new ObservableCollection<Hop>();
        }
    }
}
