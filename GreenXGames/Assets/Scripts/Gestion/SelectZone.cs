using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectZone : MonoBehaviour
{
    [Header("Paramètres")]
    public GameObject UIBatiments;

    private void OnMouseUp() // Si l'on appuis sur l'objet, la fonction s'execute.
    {
        if (GetComponentInParent<TouchMovePlanete>().dragbool == false)
        {
            UIBatiments.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
