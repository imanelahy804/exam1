using System.ComponentModel.DataAnnotations;
public abstract class Profile
{
    [Required(ErrorMessage ="name is required")]
    public string Name { get; set; }
    [Required(ErrorMessage = "addres is required")]
    public string Addres { get; set; }
    public enum ProfileType
    {
        IndividualProfile,
        LegalProfile
    }
    public  virtual double agemaker(DateTime date)
    {
        DateTime dt = DateTime.Now;
        var resultdat= (dt - date).TotalMinutes;
        return resultdat;
    }
    

}