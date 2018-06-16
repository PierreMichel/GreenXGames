using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatimentManager : MonoBehaviour
{
    GameManager GM;
    
    public enum Batiments { Centrale1, Centrale2, Scierie1, Scierie2, Station1, Station2 };

    public Batiments Batiment;


    private void Start()
    {
        GM = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
        if (Batiment == Batiments.Centrale1)
        {
            GM.Polueur += 1;
            GM.Energie = 3;
        }
        if (Batiment == Batiments.Scierie1)
        {
            GM.Polueur += 1;
            GM.GainBois += 1;
            GM.PerteEnergie += 1;

        }
        if (Batiment == Batiments.Station1)
        {
            GM.Polueur += 1;
            GM.GainEau += 1;
            GM.PerteEnergie += 1;
        }

    }
}
