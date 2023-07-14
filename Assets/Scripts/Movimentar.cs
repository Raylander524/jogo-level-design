using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movimentar : MonoBehaviour
{
    private MovimentarObjeto agentMover;
    [SerializeField] 
    private Vector2 movementInput;

    private void Awake() {
        agentMover = GetComponent<MovimentarObjeto>();
    }

    public void ObtemEntrada(InputAction.CallbackContext contexto)
    {
        movementInput = contexto.ReadValue<Vector2>();
        agentMover.MovementInput = new Vector3(movementInput.x,0.0f,movementInput.y);
    }
    
}
