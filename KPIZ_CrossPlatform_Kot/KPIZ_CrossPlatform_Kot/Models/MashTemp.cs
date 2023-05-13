using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace KPIZ_CrossPlatform_Kot.Models
{
    public class MashTemp : ObservableObject
    {
        private Volume _temp;
        private double _duration;

        [JsonProperty("temp")]
        public Volume Temp { get => _temp; set => SetProperty(ref _temp, value); }

        [JsonProperty("duration")]
        public double Duration { get => _duration; set => SetProperty(ref _duration, value); }
    }
}
