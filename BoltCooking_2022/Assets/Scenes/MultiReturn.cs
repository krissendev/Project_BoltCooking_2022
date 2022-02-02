using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiReturn : MonoBehaviour
{
    [SerializeField] int someInt;
    void Start()
    {
        string DebugMessage;
        DebugMessage = CheckInt(someInt);
        Debug.Log(DebugMessage);
    }

    string CheckInt(int someInt)
    {
        if (someInt <0)
        {
            return ("this is a low number");
        }
        else if (someInt == 0)
        {
            return ("middleground, a peaceful state of existence");
        }
        else if (someInt == 1)
        {
            return ("you are number one");
        }
        else if (someInt == 2)
        {
            return ("fool me once, shame on you; fool me twice, shame on me");
        }
        else if(someInt ==3)
        {
            return ("all good things are three");
        }
        else if(someInt >3)
        {
            return ("numerous like sandcorn in a desert");
        }

        else
        {
            return ("something is out of bounds?");
        }
    }

}
