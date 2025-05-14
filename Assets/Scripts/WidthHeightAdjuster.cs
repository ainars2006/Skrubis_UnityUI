using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WidthHeightAdjuster : MonoBehaviour
{
    [Header("UI Sliders")]
    public Slider widthSlider;
    public Slider heightSlider;

    [Header("Resizable GameObjects")]
    public GameObject imageA, imageB;

    public GameObject DzinejsA, dzinejsB, dzinejsC;
    public GameObject VirsbuveA, VirsbuveB, VirsbuveC;
    public GameObject riepaA, riepaB, riepaC, riepaD, riepaE, riepaF;
    public GameObject carDropZone1, carDropZone2, carDropZone3, carDropZone4;

    public GameObject DzinejsABike, dzinejsBBike, dzinejsCBike;
    public GameObject VirsbuveABike, VirsbuveBBike, VirsbuveCBike;
    public GameObject riepaABike, riepaBBike, riepaCBike, riepaDBike, riepaEBike, riepaFBike;
    public GameObject bikeDropZone1, bikeDropZone2, bikeDropZone3, bikeDropZone4;

    [Header("Scale Limits")]
    public float minWidth = 0.1f;
    public float maxWidth = 3f;
    public float minHeight = 0.1f;
    public float maxHeight = 3f;

    private List<GameObject> allObjects = new List<GameObject>();

    void Start()
    {
        AddAllObjects();

        if (widthSlider != null)
        {
            widthSlider.minValue = 0f;
            widthSlider.maxValue = 1f;
            widthSlider.onValueChanged.AddListener(OnWidthSliderChanged);
        }

        if (heightSlider != null)
        {
            heightSlider.minValue = 0f;
            heightSlider.maxValue = 1f;
            heightSlider.onValueChanged.AddListener(OnHeightSliderChanged);
        }

        // Apply initial values
        UpdateWidths(widthSlider?.value ?? 0f);
        UpdateHeights(heightSlider?.value ?? 0f);
    }

    void AddAllObjects()
    {
        allObjects.AddRange(new GameObject[]
        {
            imageA, imageB,
            DzinejsA, dzinejsB, dzinejsC,
            VirsbuveA, VirsbuveB, VirsbuveC,
            riepaA, riepaB, riepaC, riepaD, riepaE, riepaF,
            carDropZone1, carDropZone2, carDropZone3, carDropZone4,
            DzinejsABike, dzinejsBBike, dzinejsCBike,
            VirsbuveABike, VirsbuveBBike, VirsbuveCBike,
            riepaABike, riepaBBike, riepaCBike, riepaDBike, riepaEBike, riepaFBike,
            bikeDropZone1, bikeDropZone2, bikeDropZone3, bikeDropZone4
        });
    }

    public void OnWidthSliderChanged(float value)
    {
        UpdateWidths(value);
    }

    public void OnHeightSliderChanged(float value)
    {
        UpdateHeights(value);
    }

    void UpdateWidths(float sliderValue)
    {
        float targetWidth = Mathf.Lerp(minWidth, maxWidth, sliderValue);

        foreach (GameObject obj in allObjects)
        {
            if (obj != null)
            {
                Vector3 scale = obj.transform.localScale;
                scale.x = targetWidth;
                obj.transform.localScale = scale;
            }
        }
    }

    void UpdateHeights(float sliderValue)
    {
        float targetHeight = Mathf.Lerp(minHeight, maxHeight, sliderValue);

        foreach (GameObject obj in allObjects)
        {
            if (obj != null)
            {
                Vector3 scale = obj.transform.localScale;
                scale.y = targetHeight;
                obj.transform.localScale = scale;
            }
        }
    }
}
