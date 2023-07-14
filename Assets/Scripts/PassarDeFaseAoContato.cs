using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassarDeFaseAoContato : MonoBehaviour
{
    [Header("Tag do gameObject que recebera a cura")]
    public string outroTag;
    public string cena;

    void OnCollisionEnter(Collision outro)
    {
        if (outro.gameObject.CompareTag(outroTag))
        {
            // Destroy(gameObject);
            // gameObject.transform.position = new Vector3(-13.18f,0.64f,7.06f);
            SceneManager.LoadScene(cena);
        }
    }
}
