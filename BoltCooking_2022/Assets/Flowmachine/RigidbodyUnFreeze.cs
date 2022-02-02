using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ludiq;

[IncludeInSettings(true)]
public class RigidbodyUnFreeze : MonoBehaviour
{
    [SerializeField] public Rigidbody m_Rigidbody;

    public void UnFreeze()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Rigidbody.constraints = RigidbodyConstraints.None;
    }

}
