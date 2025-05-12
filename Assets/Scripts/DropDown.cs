using UnityEngine;

public class DropDown : MonoBehaviour
{
    public GameObject imageA;
    public GameObject imageB;

    public GameObject DzinejsA;
    public GameObject dzinejsB;
    public GameObject dzinejsC;

    public GameObject VirsbuveA;
    public GameObject VirsbuveB;
    public GameObject VirsbuveC;

    public GameObject riepaA;
    public GameObject riepaB;
    public GameObject riepaC;
    public GameObject riepaD;
    public GameObject riepaE;
    public GameObject riepaF;

    public GameObject carDropZone1;
    public GameObject carDropZone2;
    public GameObject carDropZone3;
    public GameObject carDropZone4;

    public GameObject DzinejsABike;
    public GameObject dzinejsBBike;
    public GameObject dzinejsCBike;

    public GameObject VirsbuveABike;
    public GameObject VirsbuveBBike;
    public GameObject VirsbuveCBike;

    public GameObject riepaABike;
    public GameObject riepaBBike;
    public GameObject riepaCBike;
    public GameObject riepaDBike;
    public GameObject riepaEBike;
    public GameObject riepaFBike;

    public GameObject bikeDropZone1;
    public GameObject bikeDropZone2;
    public GameObject bikeDropZone3;
    public GameObject bikeDropZone4;

    public GameObject ScrollA;
    public GameObject ScrollB;

    void Start()
    {
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

        ScrollB.SetActive(false);
    }

    public void Dropdown(int index)
    {
        bool isCar = index == 0;

        ScrollA.SetActive(isCar);
        ScrollB.SetActive(!isCar);

        imageA.SetActive(isCar);
        imageB.SetActive(!isCar);

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
