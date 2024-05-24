using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public string CityName => City.Name;
        public string ImgPath => Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Images", Id.ToString()+".jpg");
    }
}
