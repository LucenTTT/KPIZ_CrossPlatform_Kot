using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace KPIZ_CrossPlatform_Kot.Models
{
    public class Volume : ObservableObject
    {
        private double? _value;
        private string _unit;
        
        [JsonProperty("value")]
        public double? Value { get => _value; set => SetProperty(ref _value, value); }

        [JsonProperty("unit")]
        public string Unit { get => _unit; set => SetProperty(ref _unit, value); }
    }
}
