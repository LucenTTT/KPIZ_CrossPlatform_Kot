using AutoMapper;
using KPIZ_CrossPlatform_Kot.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KPIZ_CrossPlatform_Kot.Profiles
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            SourceMemberNamingConvention = new LowerUnderscoreNamingConvention();
            DestinationMemberNamingConvention = new PascalCaseNamingConvention();
            CreateMap<VolumeDto, Volume>();
            CreateMap<TempDto, Temp>();
            CreateMap<MethodDto, Method>();
            CreateMap<MashTempDto, MashTemp>();
            CreateMap<MaltDto, Malt>();
            CreateMap<IngredientsDto, Ingredients>();
            CreateMap<HopDto, Hop>();
            CreateMap<FermentationDto, Fermentation>();
            CreateMap<BoilVolumeDto, BoilVolume>();
            CreateMap<AmountDto, Amount>();
            CreateMap<BeerDto, Beer>();
        }
    }
}
