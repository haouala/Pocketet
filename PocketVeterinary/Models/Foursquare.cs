using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PocketVeterinary.Models
{


    [DataContract]
    public class Meta
    {
        [DataMember(Name = "code")]
        public int code { get; set; }
        [DataMember(Name = "requestId")]
        public string requestId { get; set; }
    }
    [DataContract]
    public class Ne
    {
        [DataMember(Name = "lat")]
        public double lat { get; set; }
        [DataMember(Name = "lng")]
        public double lng { get; set; }
    }

    [DataContract]
    public class Sw
    {
        [DataMember(Name = "lat")]
        public double lat { get; set; }


        [DataMember(Name = "lng")]
        public double lng { get; set; }
    }


    [DataContract]
    public class SuggestedBounds
    {
        [DataMember(Name = "ne")]
        public Ne ne { get; set; }

        [DataMember(Name = "sw")]
        public Sw sw { get; set; }
    }

    [DataContract]
    public class Item2
    {

        [DataMember(Name = "summary")]
        public string summary { get; set; }

        [DataMember(Name = "type")]
        public string type { get; set; }

        [DataMember(Name = "reasonName")]
        public string reasonName { get; set; }
    }

    [DataContract]
    public class Reasons
    {


        [DataMember(Name = "count")]
        public int count { get; set; }


        [DataMember(Name = "items")]
        public List<Item2> items { get; set; }
    }

    [DataContract]
    public class Contact
    {

        [DataMember(Name = "phone")]
        public string phone { get; set; }

        [DataMember(Name = "formattedPhone")]
        public string formattedPhone { get; set; }
    }

    [DataContract]
    public class Location
    {

        [DataMember(Name = "lat")]
        public double lat { get; set; }

        [DataMember(Name = "lng")]
        public double lng { get; set; }

        [DataMember(Name = "distance")]
        public int distance { get; set; }

        [DataMember(Name = "cc")]
        public string cc { get; set; }

        [DataMember(Name = "country")]
        public string country { get; set; }

        [DataMember(Name = "formattedAddress")]
        public List<string> formattedAddress { get; set; }

        [DataMember(Name = "address")]
        public string address { get; set; }

        [DataMember(Name = "crossStreet")]
        public string crossStreet { get; set; }

        [DataMember(Name = "postalCode")]
        public string postalCode { get; set; }

        [DataMember(Name = "city")]
        public string city { get; set; }

        [DataMember(Name = "state")]
        public string state { get; set; }
    }

    [DataContract]
    public class Icon
    {

        [DataMember(Name = "prefix")]
        public string prefix { get; set; }

        [DataMember(Name = "suffix")]
        public string suffix { get; set; }
    }

    [DataContract]
    public class Category
    {
        [DataMember(Name = "id")]
        public string id { get; set; }

        [DataMember(Name = "name")]
        public string name { get; set; }

        [DataMember(Name = "pluralName")]
        public string pluralName { get; set; }

        [DataMember(Name = "shortName")]
        public string shortName { get; set; }

        [DataMember(Name = "icon")]
        public Icon icon { get; set; }

        [DataMember(Name = "primary")]
        public bool primary { get; set; }
    }

    [DataContract]
    public class Stats
    {

        [DataMember(Name = "checkinsCount")]
        public int checkinsCount { get; set; }

        [DataMember(Name = "usersCount")]
        public int usersCount { get; set; }

        [DataMember(Name = "tipCount")]
        public int tipCount { get; set; }
    }

    [DataContract]
    public class Photos
    {
        [DataMember(Name = "count")]
        public int count { get; set; }

        [DataMember(Name = "groups")]
        public List<object> groups { get; set; }
    }

    [DataContract]
    public class HereNow
    {

        [DataMember(Name = "count")]
        public int count { get; set; }

        [DataMember(Name = "summary")]
        public string summary { get; set; }

        [DataMember(Name = "groups")]
        public List<object> groups { get; set; }
    }

    [DataContract]
    public class Photo
    {

        [DataMember(Name = "prefix")]
        public string prefix { get; set; }

        [DataMember(Name = "suffix")]
        public string suffix { get; set; }
    }
    [DataContract]
    public class User
    {
        [DataMember(Name = "id")]
        public string id { get; set; }

        [DataMember(Name = "firstName")]
        public string firstName { get; set; }

        [DataMember(Name = "gender")]
        public string gender { get; set; }

        [DataMember(Name = "photo")]
        public Photo photo { get; set; }

        [DataMember(Name = "lastName")]
        public string lastName { get; set; }
    }

    [DataContract]
    public class Item3
    {

        [DataMember(Name = "id")]
        public string id { get; set; }

        [DataMember(Name = "createdAt")]
        public int createdAt { get; set; }

        [DataMember(Name = "prefix")]
        public string prefix { get; set; }

        [DataMember(Name = "suffix")]
        public string suffix { get; set; }

        [DataMember(Name = "width")]
        public int width { get; set; }

        [DataMember(Name = "height")]
        public int height { get; set; }

        [DataMember(Name = "user")]
        public User user { get; set; }

        [DataMember(Name = "visibility")]
        public string visibility { get; set; }
    }

    [DataContract]
    public class FeaturedPhotos
    {

        [DataMember(Name = "count")]
        public int count { get; set; }

        [DataMember(Name = "items")]
        public List<Item3> items { get; set; }
    }

    [DataContract]
    public class Venue
    {

        [DataMember(Name = "id")]
        public string id { get; set; }

        [DataMember(Name = "name")]
        public string name { get; set; }

        [DataMember(Name = "contact")]
        public Contact contact { get; set; }

        [DataMember(Name = "location")]
        public Location location { get; set; }

        [DataMember(Name = "categories")]
        public List<Category> categories { get; set; }

        [DataMember(Name = "verified")]
        public bool verified { get; set; }

        [DataMember(Name = "stats")]
        public Stats stats { get; set; }

        [DataMember(Name = "allowMenuUrlEdit")]
        public bool allowMenuUrlEdit { get; set; }

        [DataMember(Name = "photos")]
        public Photos photos { get; set; }

        [DataMember(Name = "hereNow")]
        public HereNow hereNow { get; set; }

        [DataMember(Name = "featuredPhotos")]
        public FeaturedPhotos featuredPhotos { get; set; }
    }

    [DataContract]
    public class Todo
    {
        [DataMember(Name = "count")]
        public int count { get; set; }
    }

    [DataContract]
    public class Photo2
    {
        [DataMember(Name = "prefix")]
        public string prefix { get; set; }

        [DataMember(Name = "suffix")]
        public string suffix { get; set; }
    }


    [DataContract]
    public class User2
    {
        [DataMember(Name = "id")]
        public string id { get; set; }

        [DataMember(Name = "firstName")]
        public string firstName { get; set; }

        [DataMember(Name = "gender")]
        public string gender { get; set; }

        [DataMember(Name = "photo")]
        public Photo2 photo { get; set; }


        [DataMember(Name = "type")]
        public string type { get; set; }

        [DataMember(Name = "lastName")]
        public string lastName { get; set; }
    }

    [DataContract]
    public class Tip
    {
        [DataMember(Name = "id")]
        public string id { get; set; }

        [DataMember(Name = "createdAt")]
        public int createdAt { get; set; }

        [DataMember(Name = "text")]
        public string text { get; set; }

        [DataMember(Name = "type")]
        public string type { get; set; }

        [DataMember(Name = "canonicalUrl")]
        public string canonicalUrl { get; set; }

        [DataMember(Name = "logView")]
        public bool logView { get; set; }

        [DataMember(Name = "todo")]
        public Todo todo { get; set; }

        [DataMember(Name = "user")]
        public User2 user { get; set; }
    }

    [DataContract]
    public class Item
    {
        [DataMember(Name = "reasons")]
        public Reasons reasons { get; set; }

        [DataMember(Name = "venue")]
        public Venue venue { get; set; }

        [DataMember(Name = "referralId")]
        public string referralId { get; set; }

        [DataMember(Name = "tips")]
        public List<Tip> tips { get; set; }
    }

    [DataContract]
    public class Group
    {

        [DataMember(Name = "type")]
        public string type { get; set; }

        [DataMember(Name = "name")]
        public string name { get; set; }

        [DataMember(Name = "items")]
        public List<Item> items { get; set; }
    }

    [DataContract]
    public class Response
    {

        [DataMember(Name = "suggestedRadius")]
        public int suggestedRadius { get; set; }

        [DataMember(Name = "headerLocation")]
        public string headerLocation { get; set; }

        [DataMember(Name = "headerFullLocation")]
        public string headerFullLocation { get; set; }

        [DataMember(Name = "headerLocationGranularity")]
        public string headerLocationGranularity { get; set; }

        [DataMember(Name = "query")]
        public string query { get; set; }

        [DataMember(Name = "totalResults")]
        public int totalResults { get; set; }

        [DataMember(Name = "suggestedBounds")]
        public SuggestedBounds suggestedBounds { get; set; }


        [DataMember(Name = "groups")]
        public List<Group> groups { get; set; }
    }

    [DataContract]
    public class RootObject
    {
        [DataMember(Name = "meta")]
        public Meta meta { get; set; }

        [DataMember(Name = "response")]
        public Response response { get; set; }
    }



}
