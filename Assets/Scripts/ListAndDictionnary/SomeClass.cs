using System.Collections.Generic;
using UnityEngine;

public class SomeClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<BadGuy> badGuys = new List<BadGuy>
        {
            new BadGuy("Harvey", 50),
            new BadGuy("Magneto", 100),
            new BadGuy("Pip", 5)
        };

        badGuys.Sort();     //Call CompareTo function 

        foreach(BadGuy guy in badGuys)
        {
            print(guy.name + " " + guy.power);
        }
        badGuys.Clear();

    }

}
