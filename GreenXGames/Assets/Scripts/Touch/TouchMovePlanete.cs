using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMovePlanete : MonoBehaviour
{
    public float vitesse = 0.01f;
    public bool dragbool;
    public float perspectiveZoomvitesse = 0.1f;
    public GameObject Planete;

    public void DragStart()
    {
        dragbool = true;
        if (GetComponentInChildren<BoxCollider>() != null)
        {
            GetComponentInChildren<BoxCollider>().enabled = false;
        }
    }

    public void Drag()
    {
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {

            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

            Planete.transform.RotateAround(Vector3.up, -touchDeltaPosition.x * vitesse);
            Planete.transform.RotateAround(Vector3.right, touchDeltaPosition.y * vitesse);
        }
    }

    public void DragEnd()
    {
        dragbool = false;
        if (GetComponentInChildren<BoxCollider>() != null)
        {
            GetComponentInChildren<BoxCollider>().enabled = true;
        }
    }

    void Update()
    {
        if (Input.touchCount == 2)
        {
            dragbool = true;
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);
            
            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;
            
            float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;
            
            float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;
            
            Camera.main.fieldOfView += deltaMagnitudeDiff * perspectiveZoomvitesse;
            
            Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView, 20f, 110f);
        }
        else
        {
            dragbool = false;
        }
    }
}