using System.Xml.Linq;
using UnityEngine;

public class OOP : MonoBehaviour
{
    public string myName;
    public bool ShowName;

    private int number;
    public int number_2;

    public int Number { get; private set; }

    public void Log()
    {
        number++;

        Number = number;

        if (ShowName && (number == number_2 || string.IsNullOrEmpty(myName)))
        {

        }

        if (myName.Length > 0)
        {

        }

        if (number == number_2 || !string.IsNullOrEmpty(myName))
        {

        }

        if ((number % 2) == 0)
        {
            Debug.Log(MyNeme(true, myName));
        }
        else
        {
            Debug.Log($"{number} cant be devided by 2");
        }
    }

    public string MyNeme(bool print, string name)
    {
        if (print)
        {
            return name;
        }
        else
        {
            return null;
        }
    }
}