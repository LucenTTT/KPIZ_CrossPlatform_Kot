using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace KPIZ_CrossPlatform_Kot.Models
{
    public class Ingredient : ObservableObject
    {
        private ObservableCollection<Malt> _malt;
        private ObservableCollection<Hop> _hops;
        private string _yeast;

        [JsonProperty("malt")]
        public ObservableCollection<Malt> Malt { get => _malt; set => SetProperty(ref _malt, value); }

        [JsonProperty("hops")]
        public ObservableCollection<Hop> Hops { get => _hops; set => SetProperty(ref _hops, value); }

        [JsonProperty("yeast")]
        public string Yeast { get => _yeast; set => SetProperty(ref _yeast, value); }

        public Ingredient()
        {
            Malt = new ObservableCollection<Malt>();
            Hops = new ObservableCollection<Hop>();
        }
    }
}
