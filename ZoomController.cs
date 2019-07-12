using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>Very basic zoom scaler for Camera if you want to add 2 buttons with plus (ZoonIn)
/// and minus (ZoomOut). Btw, it doesn't work in AR </summary>
public class ZoomController : MonoBehaviour, IPointerClickHandler
{
    public GameObject ZoomIn;
    public GameObject ZoomOut;
    public Camera Camera;
    public float MinFov = 10f;
    public float MaxFov = 90f;
    public float Step;

    private void Zoom(bool zoomOut)
    {
        float fov = Camera.fieldOfView;
        if (zoomOut)
        {
            if (fov < MaxFov)
                fov += Step;
        }
        else
        {
            if (fov > MinFov)
                fov -= Step;
        }
        Camera.fieldOfView = fov;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.pointerCurrentRaycast.gameObject == ZoomIn)
            Zoom(false);
        else if (eventData.pointerCurrentRaycast.gameObject == ZoomOut)
            Zoom(true);
    }
}
