using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace KPIZ_CrossPlatform_Kot.Models
{
    public class Ingredients : ObservableObject
    {
        private ObservableCollection<Malt> _malt;
        private List<Hop> _hops;
        private string _yeast;

        [AliasAs("malt")]
        public ObservableCollection<Malt> Malt { get => _malt; set => SetProperty(ref _malt, value); }

        [AliasAs("hops")]
        public List<Hop> Hops { get => _hops; set => SetProperty(ref _hops, value); }

        [AliasAs("yeast")]
        public string Yeast { get => _yeast; set => SetProperty(ref _yeast, value); }

        public Ingredients()
        {
        }
    }
}
