using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentarCelular : MonoBehaviour
{
    private MovimentarObjeto agentMover;

    private void Awake() {
        agentMover = GetComponent<MovimentarObjeto>();
    }

    void Update()
    {
        Vector3 dir = Vector3.zero;
        agentMover.MovementInput = new Vector3(Input.acceleration.x,0.0f,Input.acceleration.y);

    }
    
}
