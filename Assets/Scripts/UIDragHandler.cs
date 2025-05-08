using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIDragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform rectTransform;
    private Canvas canvas;
    private CanvasGroup canvasGroup;

    private GameObject clone;

    [SerializeField] private float dragSpeed = 2f; // Speed multiplier for dragging

    private RectTransform originalPanelRect;

    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        canvas = GetComponentInParent<Canvas>();

        if (canvas == null)
        {
            Debug.LogWarning("Canvas is null! Ensure this object is a child of a Canvas.");
        }

        if (canvasGroup == null)
        {
            Debug.LogWarning("CanvasGroup component is missing on this GameObject.");
        }

        // Store the reference to the original panel (the parent object)
        originalPanelRect = GetComponentInParent<RectTransform>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        // Clone the item and drag the clone
        if (canvas == null)
        {
            Debug.LogError("Canvas is null, cannot instantiate clone.");
            return;
        }

        // Instantiate clone and make it a sibling
        clone = Instantiate(gameObject, canvas.transform);
        clone.transform.SetAsLastSibling();

        // Get the original object's RectTransform and make the clone 50% bigger
        RectTransform cloneRect = clone.GetComponent<RectTransform>();
        RectTransform originalRect = GetComponent<RectTransform>();
        cloneRect.sizeDelta = originalRect.sizeDelta * 1.5f;  // Make clone 50% bigger

        // Reset the clone's scale to 1x1
        clone.transform.localScale = Vector3.one;

        // Ensure the clone uses the same sprite, etc.
        clone.GetComponent<Image>().sprite = GetComponent<Image>().sprite;

        // Disable raycast blocking on the clone
        clone.AddComponent<CanvasGroup>().blocksRaycasts = false;
        clone.AddComponent<UIDragHandler>().SetAsClone(canvas);

        // Disable interaction with the original object
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        // Move the clone instead of the original object
        if (clone != null)
        {
            Vector2 pos;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(
                canvas.transform as RectTransform,
                eventData.position,
                canvas.worldCamera,
                out pos
            );

            // Update clone's position with drag speed
            clone.GetComponent<RectTransform>().anchoredPosition = Vector2.Lerp(clone.GetComponent<RectTransform>().anchoredPosition, pos, Time.deltaTime * dragSpeed * 10f);
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // When the drag ends, keep the clone at the current position
        if (clone != null)
        {
            // Check if the clone was dropped inside the original panel area
            if (RectTransformUtility.RectangleContainsScreenPoint(originalPanelRect, eventData.position, canvas.worldCamera))
            {
                // Destroy the clone if dropped back to the panel
                Destroy(clone);
            }
            else
            {
                // If not dropped in the panel, just leave the clone where it was dropped
                clone.GetComponent<CanvasGroup>().blocksRaycasts = true; // Re-enable raycasts if needed
            }
        }

        // Re-enable raycasting on the original object
        canvasGroup.blocksRaycasts = true;
    }

    public void SetAsClone(Canvas canvasRef)
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        canvas = canvasRef;
    }
}
