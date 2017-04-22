using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PocketVeterinary.Models
{
    [XmlRoot("rss")]
    public class Rss
    {
        [XmlElement("channel")]
        public Channel Channel { get; set; }
    }

    public class Channel
    {
        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("item")]
        public ObservableCollection<ItemParsing> Items { get; set; }

        public Channel()
        {
            this.Items = new ObservableCollection<ItemParsing>();
        }
    }

    public class ItemParsing
    {
        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }
    }
}
