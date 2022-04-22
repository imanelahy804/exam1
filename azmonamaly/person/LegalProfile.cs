using System.ComponentModel.DataAnnotations;
public class LegalProfile:Profile , WriteForFile
{

    public DateTime DateofRegistration { get; set; }
    [Required(ErrorMessage = "name is required")]
    public int Income { get; set; }
    public enum Taxation {
        Exempt,
        NoteExept,
    }



    public static void writefile(string path)
    {
       LegalProfile user = new LegalProfile();
        Console.WriteLine("pls enter your name:");
        user.Name = Console.ReadLine();
        Console.WriteLine("pls enter your addres:");
        user.Addres = Console.ReadLine();
        
        bool t = true;
        DateTime ddate= DateTime.Now;
        while (t)
        {
            Console.WriteLine("enter  Date of Registration:");
            string dat = Console.ReadLine();
            var date = dat.Split(',');
             ddate= new DateTime(Convert.ToInt32(date[0]), Convert.ToInt32(date[1]), Convert.ToInt32(date[2]));
            user.DateofRegistration = ddate;
            if (ddate < DateTime.Now)
            {
                t = false;
            }
        }
       

        Console.WriteLine("1-Exempt 2-NoteExept");
        int c=Convert.ToInt32( Console.ReadLine())-1;
        Console.WriteLine("enter  Date of icome:");
        user.Income =Convert.ToInt32( Console.ReadLine());
        
        var age =user.agemaker(ddate);
        string line = $"{user.Name},{user.Addres},{user.DateofRegistration},{user.Income},{age},{Convert.ToString(c)}";


       
       
        File.AppendAllText(path, line);
    }
   override public   double agemaker(DateTime date)
    {
        DateTime dt = DateTime.Now;
        var resultdat = (dt - date).TotalDays;
        return resultdat;
    }
}