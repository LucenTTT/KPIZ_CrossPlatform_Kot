using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace KPIZ_CrossPlatform_Kot.Models
{
    public class Hop : ObservableObject
    {
        private string _name;
        private Volume _amount;
        private string _add;
        private string _attribute;

        [JsonProperty("name")]
        public string Name { get => _name; set => SetProperty(ref _name, value); }

        [JsonProperty("amount")]
        public Volume Amount { get => _amount; set => SetProperty(ref _amount, value); }

        [JsonProperty("add")]
        public string Add { get => _add; set => SetProperty(ref _add, value); }

        [JsonProperty("attriibute")]
        public string Attribute { get => _attribute; set => SetProperty(ref _attribute, value); }
    }
}
