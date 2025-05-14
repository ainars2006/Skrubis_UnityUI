using UnityEngine;
using UnityEngine.UI;

public class DisplayInput : MonoBehaviour
{
    public InputField inputField1;
    public InputField inputField2;
    public Text displayText;

    public void DisplayValues()
    {
        string text1 = inputField1.text;
        string text2 = inputField2.text;

        displayText.text = text1+text2;
    }
}
