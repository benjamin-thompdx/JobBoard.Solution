using System.Collections.Generic;

namespace JobBoard.Models
{
  public class JobOpening
  {
    public Contact ContactInfo { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    private static List<JobOpening> _newJobOpening = new List<JobOpening> {};

    public JobOpening (string title, string description, Contact contactinfo)
    {
      Title = title;
      Description = description;
      ContactInfo = contactinfo;
      _newJobOpening.Add(this);
      Id = _newJobOpening.Count;
    }

     public static List<JobOpening> GetAll()
    {
      return _newJobOpening;
    }

      public static void ClearAll()
    {
      _newJobOpening.Clear();
    }

      public static JobOpening Find(int searchId)
    {
      return _newJobOpening[searchId-1];
    }

  }
}