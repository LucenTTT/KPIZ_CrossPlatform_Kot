using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
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
        private double? _abv;
        private double? _ibu;
        private double? _targetFg;
        private double? _targetOg;
        private double? _ebc;
        private double? _srm;
        private double? _ph;
        private double? _attenuationLevel;
        private Volume _volume;
        private Volume _boilVolume;
        private Method _method;
        private Ingredient _ingredients;
        private ObservableCollection<string> _foodPairing;
        private string _brewersTips;
        private string _contributedBy;

        [JsonProperty("id")]
        public int Id { get => _id; set => SetProperty(ref _id, value); }

        [JsonProperty("name")]
        public string Name { get => _name; set => SetProperty(ref _name, value); }

        [JsonProperty("tagline")]
        public string Tagline { get => _tagline; set => SetProperty(ref _tagline, value); }

        [JsonProperty("first_brewed")]
        public string FirstBrewed { get => _firstBrewed; set => SetProperty(ref _firstBrewed, value);}

        [JsonProperty("description")]
        public string Description { get => _description; set => SetProperty(ref _description, value); }

        [JsonProperty("image_url")]
        public string ImageUrl { get => _imageUrl; set => SetProperty(ref _imageUrl, value); }

        [JsonProperty("abv")]
        public double? Abv { get => _abv; set => SetProperty(ref _abv, value); }

        [JsonProperty("ibu")]
        public double? Ibu { get => _ibu; set => SetProperty(ref _ibu, value); }

        [JsonProperty("target_fg")]
        public double? TargetFg { get => _targetFg; set => SetProperty(ref _targetFg, value); }

        [JsonProperty("target_og")]
        public double? TargetOg { get => _targetOg; set => SetProperty(ref _targetOg, value); }

        [JsonProperty("ebc")]
        public double? Ebc { get => _ebc; set => SetProperty(ref _ebc, value); }

        [JsonProperty("srm")]
        public double? Srm { get => _srm; set => SetProperty(ref _srm, value); }

        [JsonProperty("ph")]
        public double? Ph { get => _ph; set => SetProperty(ref _ph, value); }

        [JsonProperty("attenuation_level")]
        public double? AttenuationLevel { get  => _attenuationLevel; set => SetProperty(ref _attenuationLevel, value); }

        [JsonProperty("volume")]
        public Volume Volume { get => _volume; set => SetProperty(ref _volume, value); }

        [JsonProperty("boil_volume")]
        public Volume BoilVolume { get => _boilVolume; set => SetProperty(ref _boilVolume, value); }

        [JsonProperty("method")]
        public Method Method { get => _method; set => SetProperty(ref _method, value); }

        [JsonProperty("Ingredients")]
        public Ingredient Ingredients { get => _ingredients; set => SetProperty(ref _ingredients, value);}

        [JsonProperty("food_pairing")]
        public ObservableCollection<string> FoodPairing { get => _foodPairing; set => SetProperty(ref _foodPairing, value); }

        [JsonProperty("brewers_tips")]
        public string BrewersTips { get => _brewersTips; set => SetProperty(ref _brewersTips, value); }

        [JsonProperty("contributed_by")]
        public string ContributdBy { get => _contributedBy; set => SetProperty(ref _contributedBy, value); }

        public Beer()
        {
            FoodPairing = new ObservableCollection<string>();
        }
    }
}
