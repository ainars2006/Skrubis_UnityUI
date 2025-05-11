using UnityEngine;

public class DropDown : MonoBehaviour
{
    public GameObject imageA; // Car frame
    public GameObject imageB; // Motorcycle frame

    // Car engines
    public GameObject DzinejsA;
    public GameObject dzinejsB;
    public GameObject dzinejsC;

    // Car bodies
    public GameObject VirsbuveA;
    public GameObject VirsbuveB;
    public GameObject VirsbuveC;

    // Car tires (6 total)
    public GameObject riepaA;
    public GameObject riepaB;
    public GameObject riepaC;
    public GameObject riepaD;
    public GameObject riepaE;
    public GameObject riepaF;

    // Car drop zones
    public GameObject carDropZone1;
    public GameObject carDropZone2;
    public GameObject carDropZone3;
    public GameObject carDropZone4;

    // Bike engines
    public GameObject DzinejsABike;
    public GameObject dzinejsBBike;
    public GameObject dzinejsCBike;

    // Bike bodies
    public GameObject VirsbuveABike;
    public GameObject VirsbuveBBike;
    public GameObject VirsbuveCBike;

    // Bike tires (6 total)
    public GameObject riepaABike;
    public GameObject riepaBBike;
    public GameObject riepaCBike;
    public GameObject riepaDBike;
    public GameObject riepaEBike;
    public GameObject riepaFBike;

    // Bike drop zones
    public GameObject bikeDropZone1;
    public GameObject bikeDropZone2;
    public GameObject bikeDropZone3;
    public GameObject bikeDropZone4;

    void Start()
    {
        // Hide all bike parts at launch
        DzinejsABike.SetActive(false);
        dzinejsBBike.SetActive(false);
        dzinejsCBike.SetActive(false);

        VirsbuveABike.SetActive(false);
        VirsbuveBBike.SetActive(false);
        VirsbuveCBike.SetActive(false);

        riepaABike.SetActive(false);
        riepaBBike.SetActive(false);
        riepaCBike.SetActive(false);
        riepaDBike.SetActive(false);
        riepaEBike.SetActive(false);
        riepaFBike.SetActive(false);

        bikeDropZone1.SetActive(false);
        bikeDropZone2.SetActive(false);
        bikeDropZone3.SetActive(false);
        bikeDropZone4.SetActive(false);
    }

    public void Dropdown(int index)
    {
        bool isCar = index == 0;

        // Frame switching
        imageA.SetActive(isCar);
        imageB.SetActive(!isCar);

        // Car parts
        DzinejsA.SetActive(isCar);
        dzinejsB.SetActive(isCar);
        dzinejsC.SetActive(isCar);

        VirsbuveA.SetActive(isCar);
        VirsbuveB.SetActive(isCar);
        VirsbuveC.SetActive(isCar);

        riepaA.SetActive(isCar);
        riepaB.SetActive(isCar);
        riepaC.SetActive(isCar);
        riepaD.SetActive(isCar);
        riepaE.SetActive(isCar);
        riepaF.SetActive(isCar);

        carDropZone1.SetActive(isCar);
        carDropZone2.SetActive(isCar);
        carDropZone3.SetActive(isCar);
        carDropZone4.SetActive(isCar);

        // Bike parts
        DzinejsABike.SetActive(!isCar);
        dzinejsBBike.SetActive(!isCar);
        dzinejsCBike.SetActive(!isCar);

        VirsbuveABike.SetActive(!isCar);
        VirsbuveBBike.SetActive(!isCar);
        VirsbuveCBike.SetActive(!isCar);

        riepaABike.SetActive(!isCar);
        riepaBBike.SetActive(!isCar);
        riepaCBike.SetActive(!isCar);
        riepaDBike.SetActive(!isCar);
        riepaEBike.SetActive(!isCar);
        riepaFBike.SetActive(!isCar);

        bikeDropZone1.SetActive(!isCar);
        bikeDropZone2.SetActive(!isCar);
        bikeDropZone3.SetActive(!isCar);
        bikeDropZone4.SetActive(!isCar);
    }
}
