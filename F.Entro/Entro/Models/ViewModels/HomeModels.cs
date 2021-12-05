using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entro.Models.ViewModels
{
    public class HomeModels
    {
        public About about { get; set; }
        public Concert concert { get; set; }
        public List<Gallery> gallery { get; set; }
        public Setting setting { get; set; }
        public Slider slider { get; set; }
        public List<Social> social { get; set; }


    }
}
