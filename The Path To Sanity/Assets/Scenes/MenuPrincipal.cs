using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public  void Sair()
    {
        Debug.Log("saiu");
        Application.Quit();
    }

    public void Jogar()
    {
        SceneManager.LoadScene(1);
    }
}
