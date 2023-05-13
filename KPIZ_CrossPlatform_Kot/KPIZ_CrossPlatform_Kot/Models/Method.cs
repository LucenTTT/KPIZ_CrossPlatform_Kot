using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace KPIZ_CrossPlatform_Kot.Models
{
    public class Method : ObservableObject
    {
        private ObservableCollection<MashTemp> _mashTemp;
        private Fermentation _fermentation;
        private string _twist;

        [AliasAs("mash_temp")]
        public ObservableCollection<MashTemp> MashTemp { get => _mashTemp; set => SetProperty(ref _mashTemp, value); }

        [AliasAs("fermentation")]
        public Fermentation Fermentation { get => _fermentation; set => SetProperty(ref _fermentation, value); }

        [AliasAs("twist")]
        public string Twist { get => _twist; set => SetProperty(ref _twist, value); }

        public Method()
        {
        }
    }
}
