using System.Collections.Generic;

namespace KPIZ_CrossPlatform_Kot
{
    public class AmountDto
    {
        public double value { get; set; }
        public string unit { get; set; }
    }

    public class BoilVolumeDto
    {
        public int value { get; set; }
        public string unit { get; set; }
    }

    public class FermentationDto
    {
        public TempDto temp { get; set; }
    }

    public class HopDto
    {
        public string name { get; set; }
        public AmountDto amount { get; set; }
        public string add { get; set; }
        public string attribute { get; set; }
    }

    public class IngredientsDto
    {
        public List<MaltDto> malt { get; set; }
        public List<HopDto> hops { get; set; }
        public string yeast { get; set; }
    }

    public class MaltDto
    {
        public string name { get; set; }
        public AmountDto amount { get; set; }
    }

    public class MashTempDto
    {
        public TempDto temp { get; set; }
        public int? duration { get; set; }
    }

    public class MethodDto
    {
        public List<MashTempDto> mash_temp { get; set; }
        public FermentationDto fermentation { get; set; }
        public string twist { get; set; }
    }

    public class BeerDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public string tagline { get; set; }
        public string first_brewed { get; set; }
        public string description { get; set; }
        public string image_url { get; set; }
        public double abv { get; set; }
        public double? ibu { get; set; }
        public int target_fg { get; set; }
        public double target_og { get; set; }
        public int? ebc { get; set; }
        public double? srm { get; set; }
        public double? ph { get; set; }
        public double attenuation_level { get; set; }
        public VolumeDto volume { get; set; }
        public BoilVolumeDto boil_volume { get; set; }
        public MethodDto method { get; set; }
        public IngredientsDto ingredients { get; set; }
        public List<string> food_pairing { get; set; }
        public string brewers_tips { get; set; }
        public string contributed_by { get; set; }
    }

    public class TempDto
    {
        public int value { get; set; }
        public string unit { get; set; }
    }

    public class VolumeDto
    {
        public int value { get; set; }
        public string unit { get; set; }
    }

}