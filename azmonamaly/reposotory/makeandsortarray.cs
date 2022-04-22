public class makeandsortarray
{

    public static void bubbl(int[] arr)
    {

        int temp;
        for (int j = 0; j <= arr.Length - 2; j++)
        {
            for (int i = 0; i <= arr.Length - 2; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    temp = arr[i + 1];
                    arr[i + 1] = arr[i];
                    arr[i] = temp;
                }
            }
        }

    }
    public static List<int> makeagelist(string path)
    {
        List<int> list = new List<int>();
        string[] lines = System.IO.File.ReadAllLines(path + "IndividualProfile.txt");
        for (int i = 0; i < lines.Length; i++)
        {
            string line = lines[i];
            var sp = line.Split(',');
            var agee =float.Parse (sp[6]);
            list.Add(Convert.ToInt32( agee));
        }
         lines = System.IO.File.ReadAllLines(path + "LegalProfile.txt");
        for (int i = 0; i < lines.Length; i++)
        {
            string line = lines[i];
            var sp = line.Split(',');
            var agee = float.Parse(sp[4]);
            list.Add(Convert.ToInt32(agee));
        }

        return list;
    }
    
}