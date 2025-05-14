using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler
{
    public AudioSource dropSound; // Reference to the AudioSource

    public void OnDrop(PointerEventData eventData)
    {
        Draggable draggable = eventData.pointerDrag.GetComponent<Draggable>();
        if (draggable != null)
        {
            draggable.transform.SetParent(transform);
            draggable.transform.localPosition = Vector3.zero; // Snap to center

            if (dropSound != null)
            {
                dropSound.Play();
            }
        }
    }
}
