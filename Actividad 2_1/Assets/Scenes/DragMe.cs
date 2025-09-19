using UnityEngine;
using UnityEngine.EventSystems;

public class DraggableUI2D : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Vector3 offset;

    public void OnBeginDrag(PointerEventData eventData)
    {
        // Calculate offset when dragging begins
        offset = transform.position - Camera.main.ScreenToWorldPoint(eventData.position);
    }

    public void OnDrag(PointerEventData eventData)
    {
        // Update position during drag
        transform.position = Camera.main.ScreenToWorldPoint(eventData.position) + offset;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // Optional: Implement logic for when dragging ends
    }
}