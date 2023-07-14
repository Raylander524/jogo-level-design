using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vento : MonoBehaviour
{
    public float forca;
    public float x;
    public float y;
    public float z;

    void OnTriggerStay( Collider outro)
    {
        if (outro.attachedRigidbody)
        {
            outro.attachedRigidbody.AddForce( new Vector3(x,y,z) * forca * 10);
        }
    }
}
