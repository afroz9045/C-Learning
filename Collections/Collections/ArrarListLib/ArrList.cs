using System.Collections;
namespace ArrarListLib
{
    public class ArrList
    {
       
        public static  void ArrListCreate()
        {
            ArrayList myList = new ArrayList();
            myList.Add(13);
            myList.Add("Afroz");
            myList.Add(13.8);
            myList.Add(14);
            myList.Add("something");
            myList.Insert(2, "khan");
            myList.RemoveAt(5);

            foreach (var i in myList)
            {
                Console.WriteLine(i);
            }
        }
    }
}