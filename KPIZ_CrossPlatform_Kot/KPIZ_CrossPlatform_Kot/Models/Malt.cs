﻿using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;

namespace KPIZ_CrossPlatform_Kot.Models
{
    public class Malt : ObservableObject
    {
        private string _name;
        private Amount _amount;

        [AliasAs("name")]
        public string Name { get => _name; set => SetProperty(ref _name, value); }

        [AliasAs("amount")]
        public Amount Amount { get => _amount; set => SetProperty(ref _amount, value); }
    }
}
