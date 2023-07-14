using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botoes : MonoBehaviour
{

    public string cena;

    public void ComecarJogo(){
        SceneManager.LoadScene(cena);
    }
    
    public void SairJogo(){
        print("Saiu");
        Application.Quit();
    }
}
