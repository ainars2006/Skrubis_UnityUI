using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject Riepas;
    public GameObject Virsbuve;
    public GameObject Dzineji;

    public GameObject RiepasButton;
    public GameObject VirsbuveButton;
    public GameObject DzinejiButton;

    void Start()
    {
        Riepas.SetActive(false);
        Virsbuve.SetActive(false);
        Dzineji.SetActive(false);
    }

    public void ShowRiepas()
    {
        Riepas.SetActive(true);
        Virsbuve.SetActive(false);
        Dzineji.SetActive(false);
    }

    public void ShowVirsbuve()
    {
        Riepas.SetActive(false);
        Virsbuve.SetActive(true);
        Dzineji.SetActive(false);
    }

    public void ShowDzineji()
    {
        Riepas.SetActive(false);
        Virsbuve.SetActive(false);
        Dzineji.SetActive(true);
    }
}