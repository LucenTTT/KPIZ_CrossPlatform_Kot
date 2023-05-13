using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;

namespace KPIZ_CrossPlatform_Kot.Models
{
    public class Amount : ObservableObject
    {
        private double _value;
        private string _unit;

        [AliasAs("value")]
        public double Value { get => _value; set => SetProperty(ref _value, value); }

        [AliasAs("unit")]
        public string Unit { get => _unit; set => SetProperty(ref _unit, value); }
    }
}
