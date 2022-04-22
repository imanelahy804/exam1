try
{
    Console.WriteLine("pls enter the path to save your loges:");
    string path = Console.ReadLine();

    if (File.Exists(path))
    {
        path = "C:\\";
    }
    var pathin = path + "IndividualProfile.txt";
    var f = File.Create(pathin);
    f.Close();
    var pathl = path + "LegalProfile.txt";
    var f2 = File.Create(pathl);
    f2.Close();
    Console.WriteLine("1-IndividualProfile 2-LegalProfile");
    var p = Console.ReadKey();
    bool t = true;
    switch (p.Key)
    {
        case ConsoleKey.D1:
            while (t)
            {
                IndividualProfile.writefile(pathin);
                Console.WriteLine("Do you want to continue?y&n");
                string co = Console.ReadLine();
                co.ToLower();
                if (co == "n" || co == "no")
                {
                    t = false;
                }
            }
            break;
        case ConsoleKey.D2:
            while (t)
            {
                LegalProfile.writefile(pathl);
                Console.WriteLine("Do you want to continue?y&n");
                string co = Console.ReadLine();
                co.ToLower();
                if (co == "n" || co == "no")
                {
                    t = false;
                }
            }
            break;
        default:
            break;


    }
    List<int> list = makeandsortarray.makeagelist(path);
    int[] listarr = new int[list.Count];
    for (int i = 0; i < list.Count; i++)
    {
        listarr[i]=list[i];
        Console.WriteLine(i);

    }
    Console.WriteLine("sort :");
    makeandsortarray.bubbl(listarr);
    foreach (int i in listarr)
    {
        Console.WriteLine(i);
    }


}
catch (FileNotFoundException)
{
    Console.WriteLine("the path error");

}


