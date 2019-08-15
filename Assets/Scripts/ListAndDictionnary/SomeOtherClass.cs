using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Dictionary<string, BadGuy> badGuys = new Dictionary<string, BadGuy>();

        BadGuy bg1 = new BadGuy("Harvey", 50);
        BadGuy bg2 = new BadGuy("Magneto", 100);

        badGuys.Add("gangster", bg1);
        badGuys.Add("mutant", bg2);

        BadGuy temp = null;

        if (badGuys.TryGetValue("birds", out temp))
        {
            //success
        }
        else
        {
            //failed
        }
    }

}
