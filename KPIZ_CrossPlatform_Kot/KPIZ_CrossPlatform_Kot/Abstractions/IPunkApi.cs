using KPIZ_CrossPlatform_Kot.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace KPIZ_CrossPlatform_Kot.Abstractions
{
    public interface IPunkApi
    {
        [Get("/beers")]
        Task<IEnumerable<Beer>> GetBeers();

        [Get("/beers?beer_name={beer_name}")]
        Task<IEnumerable<Beer>> GetBeers([AliasAs("beer_name")] string beerName);
    }
}
