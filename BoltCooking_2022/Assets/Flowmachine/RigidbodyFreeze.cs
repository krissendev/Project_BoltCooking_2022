using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ludiq;

[IncludeInSettings(true)]
public class RigidbodyFreeze : MonoBehaviour
{
    [SerializeField] public Rigidbody m_Rigidbody;
    void Start()
    {
        Freeze();
    }

    public void Freeze()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Rigidbody.constraints = RigidbodyConstraints.FreezeAll;
    }

}
