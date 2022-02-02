using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ludiq;

[IncludeInSettings(true)]
public class RaycastHitAll : MonoBehaviour
{
    RaycastHit[] SomeRayArray;
    List<RaycastHit> SomeRayList;
    Vector3 rayPosition;
    Vector3 rayDirection;
    private float rayLength;

    void Start()
    {
        SomeRayArray = CastRayArray(rayPosition, rayDirection, rayLength);
        SomeRayList = CastRayList(rayPosition, rayDirection, rayLength);
    }
    public  RaycastHit[] CastRayArray(Vector3 rayPosition, Vector3 rayDirection, float rayLength)
    {
        RaycastHit[] hits;
        hits = Physics.RaycastAll(rayPosition, rayDirection, rayLength);
        return (hits);
    }

    public List<RaycastHit> CastRayList(Vector3 rayPosition, Vector3 rayDirection, float rayLength)
    {
        RaycastHit[] hits;
        hits = Physics.RaycastAll(rayPosition, rayDirection, rayLength);
        List<RaycastHit> hitList = new List<RaycastHit>(hits);
        return (hitList);
    }
    
}
