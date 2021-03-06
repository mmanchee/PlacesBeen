using System;
using System.Collections.Generic;

namespace PlacesBeen.Models
{
  public class Place
  {
    public string CityName { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
    public int Id { get; }
    public static List<Place> _instances = new List<Place> { };
    // public string Description { get; set; }
    // public int Id { get; }
    public Place(string cityName, string description, string image)
    {
      CityName = cityName;
      Description = description;
      Image = image;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static List<Place> GetAll()
    {
      Console.WriteLine();
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Place Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}