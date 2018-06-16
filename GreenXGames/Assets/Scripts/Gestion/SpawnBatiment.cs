using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBatiment : MonoBehaviour
{
    public GameObject Batiment;
    public GameObject SpawnPosition;
    public GameObject PanelActuel;

	public void Spawn()
    {
        GameObject.Destroy(SpawnPosition.transform.GetChild(0).gameObject);
        GameObject bat = Instantiate(Batiment);
        bat.transform.parent = SpawnPosition.transform;
        bat.transform.position = SpawnPosition.transform.position;
        bat.transform.rotation = SpawnPosition.transform.rotation;
        PanelActuel.SetActive(false);
    }
}