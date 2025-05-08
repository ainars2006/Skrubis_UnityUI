using UnityEngine;

public class DropDown : MonoBehaviour
{
    public GameObject imageA; // Car frame
    public GameObject imageB; // Motorcycle frame

    // Car panels
    public GameObject DzinejsA;
    public GameObject dzinejsB;

    public GameObject VirsbuveA;
    public GameObject VirsbuveB;
    public GameObject VirsbuveC;

    public GameObject riepaA;
    public GameObject riepaB;
    public GameObject riepaC;

    // Bike panels
    public GameObject DzinejsABike;
    public GameObject dzinejsBBike;

    public GameObject VirsbuveABike;
    public GameObject VirsbuveBBike;
    public GameObject VirsbuveCBike;

    public GameObject riepaABike;
    public GameObject riepaBBike;
    public GameObject riepaCBike;
     void Start()
    {
        // Hide all bike parts at launch
        DzinejsABike.SetActive(false);
        dzinejsBBike.SetActive(false);

        VirsbuveABike.SetActive(false);
        VirsbuveBBike.SetActive(false);
        VirsbuveCBike.SetActive(false);

        riepaABike.SetActive(false);
        riepaBBike.SetActive(false);
        riepaCBike.SetActive(false);
    }
    public void Dropdown(int index)
    {
        bool isCar = index == 0;

        // Frame switching
        imageA.SetActive(isCar);
        imageB.SetActive(!isCar);

        // Car parts visibility
        DzinejsA.SetActive(isCar);
        dzinejsB.SetActive(isCar);

        VirsbuveA.SetActive(isCar);
        VirsbuveB.SetActive(isCar);
        VirsbuveC.SetActive(isCar);

        riepaA.SetActive(isCar);
        riepaB.SetActive(isCar);
        riepaC.SetActive(isCar);

        // Bike parts visibility
        DzinejsABike.SetActive(!isCar);
        dzinejsBBike.SetActive(!isCar);

        VirsbuveABike.SetActive(!isCar);
        VirsbuveBBike.SetActive(!isCar);
        VirsbuveCBike.SetActive(!isCar);

        riepaABike.SetActive(!isCar);
        riepaBBike.SetActive(!isCar);
        riepaCBike.SetActive(!isCar);
    }
}
