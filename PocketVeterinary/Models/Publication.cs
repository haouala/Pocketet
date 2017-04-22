using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketVeterinary.Models
{
    public class Publication
    {
        public int id { get; set; }
        public String name { get; set; }
        public String description { get; set; }
        public String image1 { get; set; }
        public String image2 { get; set; }
        public String image3 { get; set; }
        public String image4 { get; set; }
     
    }
    public class PublicationManager
    {
        public static List<Publication> getListPublication()
        {
            List<Publication> lstPublication = new List<Publication>();
            lstPublication.Add(new Publication { id = 1, name = "first cat", description = "14/03/2014", image1 = "Assets/ser.png", image2 = "Assets/13.png", image3 = "Assets/1.jpg", image4 = "Assets/cat1.jpg" });
            lstPublication.Add(new Publication { id = 2, name = "first dog", description = "14/03/2014", image1 = "Assets/ser.png", image2 = "Assets/13.png", image3 = "Assets/1.jpg", image4 = "Assets/cat1.jpg" });
            lstPublication.Add(new Publication { id = 3, name = "first rabbit", description = "14/03/2014", image1 = "Assets/ser.png", image2 = "Assets/13.png", image3 = "Assets/1.jpg", image4 = "Assets/cat1.jpg" });
            lstPublication.Add(new Publication { id = 4, name = "first horse", description = "14/03/2014", image1 = "Assets/ser.png", image2 = "Assets/13.png", image3 = "Assets/1.jpg", image4 = "Assets/cat1.jpg" });
            return lstPublication;

        }
    }
}
