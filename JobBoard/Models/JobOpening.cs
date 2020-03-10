using System.Collections.Generic;

namespace JobBoard.Models
{
  public class JobOpening
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public Contact(string name, string email, string phoneNumber)
    {
      Name = name;
      Email = email;
      PhoneNumber = phoneNumber;
    }
    private static List<JobOpening> _newJobOpening = new List<JobOpening>{};

    public JobOpening(string title, string description)
    {
      Title = title;
      Description = description;

      _newJobOpening.Add(this);
    }

     public static List<JobOpening> GetAll()
    {
      return _newJobOpening;
    }

  }
}