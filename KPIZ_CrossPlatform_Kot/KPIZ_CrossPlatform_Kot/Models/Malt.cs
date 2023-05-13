using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace KPIZ_CrossPlatform_Kot.Models
{
    public class Malt : ObservableObject
    {
        private string _name;
        private Volume _amount;

        [JsonProperty("name")]
        public string Name { get => _name; set => SetProperty(ref _name, value); }

        [JsonProperty("amount")]
        public Volume Amount { get => _amount; set => SetProperty(ref _amount, value); }
    }
}
