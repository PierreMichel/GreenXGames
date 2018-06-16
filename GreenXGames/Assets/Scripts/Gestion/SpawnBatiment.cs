using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBatiment : MonoBehaviour {

    public GameObject Batiment;
    public Transform[] SpawnPosition;
    public GameObject PanelActuel;

	public void Spawn()
    {
        GameObject bat = Instantiate(Batiment);
        int SpawnNumber = Random.Range(0, SpawnPosition.Length);
        bat.transform.parent = SpawnPosition[SpawnNumber] ;
        bat.transform.position = SpawnPosition[SpawnNumber].position;
        bat.transform.rotation = SpawnPosition[SpawnNumber].rotation;
        PanelActuel.SetActive(false);

    }
}
