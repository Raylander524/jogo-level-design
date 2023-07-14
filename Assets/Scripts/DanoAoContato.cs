using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanoAoContato : MonoBehaviour
{
    [Header("Tag do gameObject que recebera a cura")]
    public string outroTag;

    void OnCollisionEnter(Collision outro)
    {
        if (outro.gameObject.CompareTag(outroTag))
        {
            // Destroy(gameObject);
            gameObject.transform.position = new Vector3(-13.18f,0.64f,7.06f);
        }
    }
}
