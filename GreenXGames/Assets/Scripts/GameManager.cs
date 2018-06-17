using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Paramètre de spawn")]
    public Transform SpawnCentrale;
    public Transform SpawnFerme, SpawnStation, SpawnExploitation, SpawnTutorielUI;
    [Space(10)]
    public GameObject NuagePolution;
    [HideInInspector]
    public int Polution, Polueur, Energie,PerteEnergie, Eau, GainEau, Bois, GainBois, Pierre, GainPierre, Metal, Nourriture, Décharge;
    [Header("UI")]
    public GameObject UILeadboard;
    public Text txtEau, txtSapin, txtPomme, txtMetal, txtPierre;
    [Space(10)]
    public Text txtEnergie;
    public Image SliderEnergie;

    
    bool acheter;

    void Start ()
    {
        Spawn();
    }

    private void Update()
    {
        if (Polution == 10)
        {
            acheter = false;
            NuagePolution.SetActive(true);
        }
        else
        {
            acheter = true;
            NuagePolution.SetActive(false);
        }

        UpdateResources();
    }

    void Spawn()
    {
        if (PlayerPrefs.GetInt(Sauvegarde.cle.KGMcycles) == 0)
        {
            GameObject Centrale = Instantiate(Resources.Load<GameObject>(Sauvegarde.cle.KGMcentrales + PlayerPrefs.GetInt(Sauvegarde.cle.KGMcentraleslvl).ToString()), SpawnCentrale);
            Centrale.transform.parent = SpawnCentrale.transform;
            GameObject Tuto = Instantiate(Resources.Load<GameObject>("Tutoriel"),SpawnTutorielUI);

            PlayerPrefs.SetInt(Sauvegarde.cle.KRpolution , 10);
            PlayerPrefs.SetInt(Sauvegarde.cle.KRtraitement, 0);   
            PlayerPrefs.SetInt(Sauvegarde.cle.KReau , 0);
            PlayerPrefs.SetInt(Sauvegarde.cle.KRbois , 0);
            PlayerPrefs.SetInt(Sauvegarde.cle.KRpierre , 0);
            PlayerPrefs.SetInt(Sauvegarde.cle.KRmetal , 0);
            PlayerPrefs.SetInt(Sauvegarde.cle.KRnourriture , 2);

            setRessources();
        }
        else
        {
            GameObject Centrale = Instantiate(Resources.Load<GameObject>(Sauvegarde.cle.KGMcentrales + PlayerPrefs.GetInt(Sauvegarde.cle.KGMcentraleslvl).ToString()));
            GameObject Fermes = Instantiate(Resources.Load<GameObject>(Sauvegarde.cle.KGMfermes + PlayerPrefs.GetInt(Sauvegarde.cle.KGMfermeslvl).ToString()));
            GameObject Station = Instantiate(Resources.Load<GameObject>(Sauvegarde.cle.KGMstations + PlayerPrefs.GetInt(Sauvegarde.cle.KGMstationslvl).ToString()));
            GameObject Exploitation = Instantiate(Resources.Load<GameObject>(Sauvegarde.cle.KGMexploitations + PlayerPrefs.GetInt(Sauvegarde.cle.KGMexploitationslvl).ToString()));

        } 
    }

    void setRessources()
    {
        Polution = PlayerPrefs.GetInt(Sauvegarde.cle.KRpolution);
        Eau = PlayerPrefs.GetInt(Sauvegarde.cle.KReau);
        Pierre = PlayerPrefs.GetInt(Sauvegarde.cle.KRpierre);
        Metal = PlayerPrefs.GetInt(Sauvegarde.cle.KRmetal);
        Nourriture = PlayerPrefs.GetInt(Sauvegarde.cle.KRnourriture);
    }
    
    public void NextDay()
    {
        PlayerPrefs.SetInt(Sauvegarde.cle.KGMcycles, PlayerPrefs.GetInt(Sauvegarde.cle.KGMcycles) + 1);
        
        
    }

    void UpdateResources()
    {
        txtEau.text = Eau.ToString();
        txtSapin.text = Eau.ToString();
        txtPomme.text = Nourriture.ToString();
        txtMetal.text = Metal.ToString();
        txtPierre.text = Pierre.ToString();

        txtEnergie.text = Energie.ToString()+"/10";
        SliderEnergie.fillAmount = Energie / 10;
    }
}
