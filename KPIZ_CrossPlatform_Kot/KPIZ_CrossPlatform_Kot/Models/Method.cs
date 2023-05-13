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
    public class Method : ObservableObject
    {
        private ObservableCollection<MashTemp> _mashTemp;
        private Fermentation _fermentation;
        private string _twist;

        [JsonPropertyName("mash_temp")]
        public ObservableCollection<MashTemp> MashTemp { get => _mashTemp; set => SetProperty(ref _mashTemp, value); }

        [JsonPropertyName("fermentation")]
        public Fermentation Fermentation { get => _fermentation; set => SetProperty(ref _fermentation, value); }

        [JsonPropertyName("twist")]
        public string Twist { get => _twist; set => SetProperty(ref _twist, value); }

        public Method()
        {
            MashTemp = new ObservableCollection<MashTemp>();
        }
    }
}
