using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityInfo.API.Model;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "city1",
                    Description = "D1"
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "city2",
                    Description = "D2"
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "city3",
                    Description = "D3"
                },
            };
        }
    }
}