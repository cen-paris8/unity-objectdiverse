using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuy
{
    public string name;
    public int power;

    public BadGuy(string NewName, int NewPower)
    {
        name = NewName;
        power = NewPower;
    }

    public int CompareTo(BadGuy other)
    {
        if (other == null)
        {
            return 1;
        }
        return power - other.power;
    }
   
}
