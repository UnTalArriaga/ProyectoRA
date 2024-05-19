using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Canvas : MonoBehaviour
{
    [SerializeField] private GameObject Menu, Pausa, Juego;
    private bool pause = false;
    public void pausa()
    {
        Pausa.SetActive(true);
        Juego.SetActive(false);
    }

    public void reanudar()
    {
        Pausa.SetActive(false);
        Juego.SetActive(true);
    }

    public void reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void jugar() {
        Juego.SetActive(true);
        Menu.SetActive(false); 
        
    }

    public void Home()
    {
        Menu.SetActive(true);
        Pausa.SetActive(false);
    }
}
