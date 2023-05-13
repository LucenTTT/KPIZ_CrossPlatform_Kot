using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace KPIZ_CrossPlatform_Kot.Models
{
    public class Fermentation : ObservableObject
    {
        private Volume _temp;

        [JsonProperty("temp")]
        public Volume Temp { get => _temp; set => SetProperty(ref _temp, value); }
    }
}
