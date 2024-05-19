using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Imagen : MonoBehaviour
{
    [SerializeField] private GameObject Escenario1, Escenario2, Escenario3;

    public void Perder1()
    {
        Escenario1.SetActive(false);
    }

    public void Encontrar1()
    {
        Escenario1.SetActive(true);
    }

    public void Perder2()
    {
        Escenario2.SetActive(false);
    }

    public void Encontrar2()
    {
        Escenario2.SetActive(true);
    }

    public void Perder3()
    {
        Escenario3.SetActive(false);
    }

    public void Encontrar3()
    {
        Escenario3.SetActive(true);
    }
}

