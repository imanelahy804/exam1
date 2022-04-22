using System.ComponentModel.DataAnnotations;
public class IndividualProfile:Profile , WriteForFile
{
    [Required(ErrorMessage = "name is required")]
    public string LastName { get; set; }
    public DateTime Dateofbirth { get; set; }
    public string PhoneNumber { get; set; }
    public enum Gender { 
        male,
        fmale,
    }
    public string Jobe { get; set; }
    public int Age { get; set; }





    public static void writefile( string path)
    {
        IndividualProfile individualProfile = new IndividualProfile();
        Console.WriteLine("pls enter your name:");
        individualProfile.Name = Console.ReadLine();
        Console.WriteLine("pls enter your lastname:");
        individualProfile.LastName = Console.ReadLine();
        Console.WriteLine("pls enter your addres:");
        individualProfile.Addres = Console.ReadLine();
        Console.WriteLine("enter yoir birthday:");
        string dat = Console.ReadLine();
        var date = dat.Split(',');
        DateTime ddate= new DateTime(Convert.ToInt32(date[0]), Convert.ToInt32(date[1]), Convert.ToInt32(date[2]));
        individualProfile.Dateofbirth = ddate;
        var age= individualProfile.agemaker(ddate);
        individualProfile.Age=Convert.ToInt32( age);
        Console.WriteLine("pls enter your phone:");
        individualProfile.PhoneNumber = Console.ReadLine();
        Console.WriteLine("pls enter your job:");
        individualProfile.Jobe = Console.ReadLine();
        string line = $"{individualProfile.Name},{individualProfile.LastName},{individualProfile.Addres},{individualProfile.Dateofbirth},{individualProfile.PhoneNumber},{individualProfile.Jobe},{age}";
       
       
        File.AppendAllText(path,line);
    }
    public override  double agemaker(DateTime date)
    {
        DateTime dt = DateTime.Now;
        var age1 = (dt - date).TotalDays;
        var age = age1 / 365;
        return age;
    }
    public static int operator +(IndividualProfile p1, IndividualProfile p2)
    {
        return p1.Age * p2.Age;
    }
}