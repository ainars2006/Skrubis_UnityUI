using UnityEngine;
using UnityEngine.UI;

public class ToggleTwoObjects : MonoBehaviour
{
    [Header("UI Toggle")]
    public Toggle toggle;

    [Header("Target Objects")]
    public GameObject objectA;
    public GameObject objectB;

    void Start()
    {
        if (toggle != null)
        {
            toggle.onValueChanged.AddListener(OnToggleChanged);

            // Set both objects based on the toggle's current state
            SetObjectsActive(toggle.isOn);
        }
    }

    public void OnToggleChanged(bool isOn)
    {
        SetObjectsActive(isOn);
    }

    void SetObjectsActive(bool state)
    {
        if (objectA != null) objectA.SetActive(state);
        if (objectB != null) objectB.SetActive(state);
    }
}
