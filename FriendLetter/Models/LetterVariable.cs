namespace FriendLetter.Models
{
  public class LetterVariable
  {
    private string _recipient;
    private string _sender;
    private string _vacationLocation;
    private string _souveniers;

    public string GetRecipient()
    {
      return _recipient;
    }

    public void SetRecipient(string newRecipient)
   {
     _recipient = newRecipient;
   }



   public string GetSender()
    {
      return _sender;
    }

    public void SetSender(string newSender)
    {
      _sender = newSender;
    }

    public string GetVacationLocation()
     {
       return _vacationLocation;
     }

     public void SetVacationLocation(string newVacationLocation)
     {
       _vacationLocation = newVacationLocation;
     }


     public string GetSouveniers()
      {
        return _souveniers;
      }

      public void SetSouveniers(string newSouveniers)
      {
        _souveniers = newSouveniers;
      }
  }
}
