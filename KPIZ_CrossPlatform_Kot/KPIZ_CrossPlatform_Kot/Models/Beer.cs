using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace KPIZ_CrossPlatform_Kot.Models
{
    public class Beer : ObservableObject
    {
        private int _id;
        private string _name;
        private string _tagline;
        private string _firstBrewed;
        private string _description;
        private string _imageUrl;
        private double _abv;
        private double? _ibu;
        private int _targetFg;
        private double _targetOg;
        private int? _ebc;
        private double? _srm;
        private double? _ph;
        private double _attenuationLevel;
        private Volume _volume;
        private BoilVolume _boilVolume;
        private Method _method;
        private Ingredients _ingredients;
        private ObservableCollection<string> _foodPairing;
        private string _brewersTips;
        private string _contributedBy;

        [AliasAs("id")]
        public int Id { get => _id; set => SetProperty(ref _id, value); }

        [AliasAs("name")]
        public string Name { get => _name; set => SetProperty(ref _name, value); }

        [AliasAs("tagline")]
        public string Tagline { get => _tagline; set => SetProperty(ref _tagline, value); }

        [AliasAs("first_brewed")]
        public string FirstBrewed { get => _firstBrewed; set => SetProperty(ref _firstBrewed, value);}

        [AliasAs("description")]
        public string Description { get => _description; set => SetProperty(ref _description, value); }

        [AliasAs("image_url")]
        public string ImageUrl { get => _imageUrl; set => SetProperty(ref _imageUrl, value); }

        [AliasAs("abv")]
        public double Abv { get => _abv; set => SetProperty(ref _abv, value); }

        [AliasAs("ibu")]
        public double? Ibu { get => _ibu; set => SetProperty(ref _ibu, value); }

        [AliasAs("target_fg")]
        public int TargetFg { get => _targetFg; set => SetProperty(ref _targetFg, value); }

        [AliasAs("target_og")]
        public double TargetOg { get => _targetOg; set => SetProperty(ref _targetOg, value); }

        [AliasAs("ebc")]
        public int? Ebc { get => _ebc; set => SetProperty(ref _ebc, value); }

        [AliasAs("srm")]
        public double? Srm { get => _srm; set => SetProperty(ref _srm, value); }

        [AliasAs("ph")]
        public double? Ph { get => _ph; set => SetProperty(ref _ph, value); }

        [AliasAs("attenuation_level")]
        public double AttenuationLevel { get  => _attenuationLevel; set => SetProperty(ref _attenuationLevel, value); }

        [AliasAs("volume")]
        public Volume Volume { get => _volume; set => SetProperty(ref _volume, value); }

        [AliasAs("boil_volume")]
        public BoilVolume BoilVolume { get => _boilVolume; set => SetProperty(ref _boilVolume, value); }

        [AliasAs("method")]
        public Method Method { get => _method; set => SetProperty(ref _method, value); }

        [AliasAs("Ingredients")]
        public Ingredients Ingredients { get => _ingredients; set => SetProperty(ref _ingredients, value);}

        [AliasAs("food_pairing")]
        public ObservableCollection<string> FoodPairing { get => _foodPairing; set => SetProperty(ref _foodPairing, value); }

        [AliasAs("brewers_tips")]
        public string BrewersTips { get => _brewersTips; set => SetProperty(ref _brewersTips, value); }

        [AliasAs("contributed_by")]
        public string ContributdBy { get => _contributedBy; set => SetProperty(ref _contributedBy, value); }

        public Beer()
        {
        }
    }
}
