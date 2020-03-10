using System.Collections.Generic;

namespace JobBoard.Models
{
  public class JobOpening
  {
    //public Contact ContactInfo { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    private static List<JobOpening> _newJobOpening = new List<JobOpening>{};

    public JobOpening(string title, string description)
    {
      Title = title;
      Description = description;
      // ContactInfo.Name = name;
      // ContactInfo.Email = email;
      // ContactInfo.PhoneNumber = phoneNumber;
      _newJobOpening.Add(this);
    }

     public static List<JobOpening> GetAll()
    {
      return _newJobOpening;
    }

  }
}