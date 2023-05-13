using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Text.Json.Serialization;

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

        [JsonPropertyName("id")]
        public int Id { get => _id; set => SetProperty(ref _id, value); }

        [JsonPropertyName("name")]
        public string Name { get => _name; set => SetProperty(ref _name, value); }

        [JsonPropertyName("tagline")]
        public string Tagline { get => _tagline; set => SetProperty(ref _tagline, value); }

        [JsonPropertyName("first_brewed")]
        public string FirstBrewed { get => _firstBrewed; set => SetProperty(ref _firstBrewed, value);}

        [JsonPropertyName("description")]
        public string Description { get => _description; set => SetProperty(ref _description, value); }

        [JsonPropertyName("image_url")]
        public string ImageUrl { get => _imageUrl; set => SetProperty(ref _imageUrl, value); }

        [JsonPropertyName("abv")]
        public double Abv { get => _abv; set => SetProperty(ref _abv, value); }

        [JsonPropertyName("ibu")]
        public double? Ibu { get => _ibu; set => SetProperty(ref _ibu, value); }

        [JsonPropertyName("target_fg")]
        public int TargetFg { get => _targetFg; set => SetProperty(ref _targetFg, value); }

        [JsonPropertyName("target_og")]
        public double TargetOg { get => _targetOg; set => SetProperty(ref _targetOg, value); }

        [JsonPropertyName("ebc")]
        public int? Ebc { get => _ebc; set => SetProperty(ref _ebc, value); }

        [JsonPropertyName("srm")]
        public double? Srm { get => _srm; set => SetProperty(ref _srm, value); }

        [JsonPropertyName("ph")]
        public double? Ph { get => _ph; set => SetProperty(ref _ph, value); }

        [JsonPropertyName("attenuation_level")]
        public double AttenuationLevel { get  => _attenuationLevel; set => SetProperty(ref _attenuationLevel, value); }

        [JsonPropertyName("volume")]
        public Volume Volume { get => _volume; set => SetProperty(ref _volume, value); }

        [JsonPropertyName("boil_volume")]
        public BoilVolume BoilVolume { get => _boilVolume; set => SetProperty(ref _boilVolume, value); }

        [JsonPropertyName("method")]
        public Method Method { get => _method; set => SetProperty(ref _method, value); }

        [JsonPropertyName("Ingredients")]
        public Ingredients Ingredients { get => _ingredients; set => SetProperty(ref _ingredients, value);}

        [JsonPropertyName("food_pairing")]
        public ObservableCollection<string> FoodPairing { get => _foodPairing; set => SetProperty(ref _foodPairing, value); }

        [JsonPropertyName("brewers_tips")]
        public string BrewersTips { get => _brewersTips; set => SetProperty(ref _brewersTips, value); }

        [JsonPropertyName("contributed_by")]
        public string ContributdBy { get => _contributedBy; set => SetProperty(ref _contributedBy, value); }

        public Beer()
        {
        }
    }
}
