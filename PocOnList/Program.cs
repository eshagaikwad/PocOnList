public class Program
{
    
    public static void Main(string[] args)
    { 
       
       List<string> listOfNames = new List<string>(); //C =>created a List

        Console.WriteLine("Reading the list");

        AddElementsToList(listOfNames); //Adding Elements to List

        PrintList(listOfNames);//Printing List

        Console.WriteLine();     
        UpdateToList(listOfNames );//U=>Updated in List

        Console.WriteLine();
        DeleteFromList(listOfNames );   //D==>Deleted from List

    }
    public static void PrintList(List<string> listOfNames)
    {
        //R=>Read a list
        foreach (string name in listOfNames)
        {
            Console.WriteLine(name);
        }

    }
    public static void AddElementsToList(List<string> listOfNames)
    {

        listOfNames.Add("Esha");
        listOfNames.Add("Preet");
        listOfNames.Add("Daksh");
        listOfNames.Add("Akriti");

    }
    public static void UpdateToList(List<string> listOfNames)
    {
        Console.WriteLine("After Update");
        listOfNames[0] = "Gayatri";
        PrintList(listOfNames);

    }
    public static void DeleteFromList(List<string> listOfNames)
    {
        Console.WriteLine("After deletion");
        listOfNames.RemoveAt(listOfNames.Count - 1);
        PrintList(listOfNames);
    }


}
