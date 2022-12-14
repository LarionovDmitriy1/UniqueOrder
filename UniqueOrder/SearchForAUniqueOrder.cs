using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace UniqueOrder;

public class SearchForAUniqueOrder
{
    public static List<char> UniqueInOrder(string enter)
    {
        List<char> result = new List<char>();
        for (int i = 0; i < enter.Length; i++)
        {
            int SavesFromAnError = i + 1;
            if (SavesFromAnError == enter.Length)
            {
                SavesFromAnError = enter.Length - 1;
            }
            else
            {
                if (enter[i] != enter[i + 1])
                {
                    result.Add(enter[i]);
                }
            }
        }
        result.Add(enter[enter.Length - 1]);
        return result;
    }
}
