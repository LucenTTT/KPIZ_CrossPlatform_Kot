using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;

namespace KPIZ_CrossPlatform_Kot.Models
{
    public class Fermentation : ObservableObject
    {
        private Temp _temp;

        [AliasAs("temp")]
        public Temp Temp { get => _temp; set => SetProperty(ref _temp, value); }
    }
}
