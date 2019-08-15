using System.Collections.Generic;
using UnityEngine;

public class SomeClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<BadGuy> badGuys = new List<BadGuy>();

        badGuys.Add(new BadGuy("Harvey", 50));
        badGuys.Add(new BadGuy("Magneto", 100));
        badGuys.Add(new BadGuy("Pip", 5));

        badGuys.Sort();     //Call CompareTo function 

        foreach(BadGuy guy in badGuys)
        {
            print(guy.name + " " + guy.power);
        }
        badGuys.Clear();

    }

}
