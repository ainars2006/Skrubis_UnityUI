using UnityEngine;
using UnityEngine.EventSystems;

public class UIDropHandler : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;

        if (dropped != null)
        {
            dropped.transform.position = transform.position;
            dropped.GetComponent<CanvasGroup>().blocksRaycasts = true;

            // Optionally: lock it in place by disabling further drag
            Destroy(dropped.GetComponent<UIDragHandler>());
        }
    }
}
