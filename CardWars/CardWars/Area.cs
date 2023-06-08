namespace CardWars
{
  struct Area
  {
    public string Name;
    public string Type;
    public int AreaSQM;
    public static List<Area> Biomes = new List<Area>();
    
    public Area(string Name, string Type, int AreaSQM)
    {
      this.Name = Name;
      this.Type = Type;
      this.AreaSQM = AreaSQM;

    }

    public void Effect() { }
  }
}
