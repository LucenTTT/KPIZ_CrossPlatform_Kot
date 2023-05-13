using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace KPIZ_CrossPlatform_Kot.Models
{
    public class MashTemp : ObservableObject
    {
        private Temp _temp;
        private int? _duration;

        [JsonPropertyName("temp")]
        public Temp Temp { get => _temp; set => SetProperty(ref _temp, value); }

        [JsonPropertyName("duration")]
        public int? Duration { get => _duration; set => SetProperty(ref _duration, value); }
    }
}
