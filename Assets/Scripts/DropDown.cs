using UnityEngine;

public class DropDown : MonoBehaviour
{
    public GameObject imageA; // Car frame
    public GameObject imageB; // Motorcycle frame

    // Car panels
    public GameObject DzinejsA;
    public GameObject dzinejsB;
    public GameObject dzinejsC;

    public GameObject VirsbuveA;
    public GameObject VirsbuveB;
    public GameObject VirsbuveC;

    public GameObject riepaA;
    public GameObject riepaB;
    public GameObject riepaC;

    // Bike panels
    public GameObject DzinejsABike;
    public GameObject dzinejsBBike;
    public GameObject dzinejsCBike;

    public GameObject VirsbuveABike;
    public GameObject VirsbuveBBike;
    public GameObject VirsbuveCBike;

    public GameObject riepaABike;
    public GameObject riepaBBike;
    public GameObject riepaCBike;

    public void Dropdown(int index)
    {
        bool isCar = index == 0;

        // Frame switching
        imageA.SetActive(isCar);
        imageB.SetActive(!isCar);

        // Car parts visibility
        DzinejsA.SetActive(isCar);
        dzinejsB.SetActive(isCar);
        dzinejsC.SetActive(isCar);

        VirsbuveA.SetActive(isCar);
        VirsbuveB.SetActive(isCar);
        VirsbuveC.SetActive(isCar);

        riepaA.SetActive(isCar);
        riepaB.SetActive(isCar);
        riepaC.SetActive(isCar);

        // Bike parts visibility
        DzinejsABike.SetActive(!isCar);
        dzinejsBBike.SetActive(!isCar);
        dzinejsCBike.SetActive(!isCar);

        VirsbuveABike.SetActive(!isCar);
        VirsbuveBBike.SetActive(!isCar);
        VirsbuveCBike.SetActive(!isCar);

        riepaABike.SetActive(!isCar);
        riepaBBike.SetActive(!isCar);
        riepaCBike.SetActive(!isCar);
    }
}
