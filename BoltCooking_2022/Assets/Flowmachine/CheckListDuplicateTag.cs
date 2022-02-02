using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ludiq;

[IncludeInSettings(true)]
public class CheckListDuplicateTag : MonoBehaviour
{       
    public List<GameObject> hitList;
    bool hasDuplicates = false;
    void Start()
    {
        bool someBool;
        string gameObjectTag = "placeholder"; 
        someBool = CheckListForDuplicate(gameObjectTag, hitList);
    }

    public bool CheckListForDuplicate(string gameObjectTag, List<GameObject> hitList)
    { 
    var hashset = new HashSet<GameObject>();
        foreach (var ray in hitList)
        {
            if(ray.tag == gameObjectTag)
            {
                if (!hashset.Add(ray))
                {
                    Debug.Log("List contains duplicate values.");
                    hasDuplicates = true;
                    return (hasDuplicates);
                }
            }
        }
        return (hasDuplicates);
    }


}
