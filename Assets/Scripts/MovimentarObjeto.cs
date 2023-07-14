using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovimentarObjeto : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField]
    private float acceleration = 20, desacceleration = 0.25f;

    [SerializeField]
    private Velocidade velocidadeComponent;

    private Vector3 oldMovementInput;
    public Vector3 MovementInput {get; set;}

    private void Awake(){
        rb = GetComponent<Rigidbody>();
        if(!TryGetComponent<Velocidade>(out velocidadeComponent)){
            print("Adicione o componente <color=orange> Velocidade</color> ao gameobject.");
        }
    }

    void FixedUpdate() {
        if(MovementInput.magnitude > 0 && velocidadeComponent.velocidade >= 0 ){
            oldMovementInput = MovementInput;
            velocidadeComponent.velocidade += acceleration * velocidadeComponent.velocidadeMaxima * Time.deltaTime;
        }    
        else{
            velocidadeComponent.velocidade -= desacceleration * (velocidadeComponent.velocidadeMaxima - 1.5f) * Time.deltaTime;
        }
        velocidadeComponent.velocidade = Mathf.Clamp(velocidadeComponent.velocidade, 0, velocidadeComponent.velocidadeMaxima);
        rb.velocity = oldMovementInput * velocidadeComponent.velocidade;
    }
}
