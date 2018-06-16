using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Paramètre de spawn")]
    public Transform SpawnCentrale;
    public Transform SpawnFerme;
    public Transform SpawnStation;
    public Transform SpawnExploitation;
    public Transform SpawnTutorielUI;


    void Start ()
    {
        Spawn();
    }

    void Spawn()
    {
        if (PlayerPrefs.GetInt(Sauvegarde.cle.KGMcycles) == 0)
        {
            GameObject Centrale = Instantiate(Resources.Load<GameObject>(Sauvegarde.cle.KGMcentrales + PlayerPrefs.GetInt(Sauvegarde.cle.KGMcentraleslvl).ToString()), SpawnCentrale);
            GameObject Tuto = Instantiate(Resources.Load<GameObject>("Tutoriel"),SpawnTutorielUI);
            //Centrale.transform.parent = SpawnCentrale;
            //Centrale.transform.position = SpawnCentrale.position;
        }
        else
        {
            GameObject Centrale = Instantiate(Resources.Load<GameObject>(Sauvegarde.cle.KGMcentrales + PlayerPrefs.GetInt(Sauvegarde.cle.KGMcentraleslvl).ToString()));
            GameObject Fermes = Instantiate(Resources.Load<GameObject>(Sauvegarde.cle.KGMfermes + PlayerPrefs.GetInt(Sauvegarde.cle.KGMfermeslvl).ToString()));
            GameObject Station = Instantiate(Resources.Load<GameObject>(Sauvegarde.cle.KGMstations + PlayerPrefs.GetInt(Sauvegarde.cle.KGMstationslvl).ToString()));
            GameObject Exploitation = Instantiate(Resources.Load<GameObject>(Sauvegarde.cle.KGMexploitations + PlayerPrefs.GetInt(Sauvegarde.cle.KGMexploitationslvl).ToString()));
        } 
    }
	
}
