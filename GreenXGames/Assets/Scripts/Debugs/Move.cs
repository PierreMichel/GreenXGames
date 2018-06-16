using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float vitesse = 0.01f;

    private void OnMouseDrag()
    {
        if (Input.touchCount <=1 &&  Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            
            transform.RotateAround(Vector3.up, -touchDeltaPosition.x * vitesse);
            transform.RotateAround(Vector3.right, touchDeltaPosition.y * vitesse);
        }
    }

}
