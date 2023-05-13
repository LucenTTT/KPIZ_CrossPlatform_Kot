using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;

namespace KPIZ_CrossPlatform_Kot.Models
{
    public class Hop : ObservableObject
    {
        private string _name;
        private Amount _amount;
        private string _add;
        private string _attribute;

        [AliasAs("name")]
        public string Name { get => _name; set => SetProperty(ref _name, value); }

        [AliasAs("amount")]
        public Amount Amount { get => _amount; set => SetProperty(ref _amount, value); }

        [AliasAs("add")]
        public string Add { get => _add; set => SetProperty(ref _add, value); }

        [AliasAs("attriibute")]
        public string Attribute { get => _attribute; set => SetProperty(ref _attribute, value); }
    }
}
