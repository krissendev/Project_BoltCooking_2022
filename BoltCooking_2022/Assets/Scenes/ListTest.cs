using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListTest : MonoBehaviour
{
    private void Start()
    {

        int[] arrayToList = new int[6] { 5, 9, 4, 7, 2, 1 };
        List<int> listTest = new List<int>(arrayToList);

        listTest.Remove(listTest[0]);
        listTest.Remove(listTest[0]);
        listTest.Remove(listTest[1]);
        int enumerator = 0;
        foreach (var integer in listTest)
        {
            
            Debug.Log(listTest[enumerator] + " / " + integer);
            enumerator++;
        }


    }

}
