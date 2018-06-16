using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class Cle
{
    // Resources \\
    public string KReau = "KReau";
    public string KRenergie = "KRenergie";
    public string KRnourriture = "KRnourriture";
    public string KRbois = "KRbois";
    public string KRmetal = "KRmetal";
    public string KRpierre = "KRpierre";
    public string KRpolution = "KRpolution";
    public string KRtraitement = "KRtraitement";

    // GameManager \\

    public string KGMcycles = "KGMcycles";
    public string KGMcentrales = "KGMcentrales";
    public string KGMcentraleslvl = "KGMcentraleslvl";
    public string KGMfermes = "KGMfermes";
    public string KGMfermeslvl = "KGMfermeslvl";
    public string KGMstations = "KGMstations";
    public string KGMstationslvl = "KGMstationslvl";
    public string KGMexploitations = "KGMexploitations";
    public string KGMexploitationslvl = "KGMexploitationslvl";

    // Parametres \\

    public String KSauvegardeExiste = "KeySave";
    public String KLangues = "KeyLangues";
    public String KVolumeMusique = "KeyMusic";
    public String KVolumeFX = "KeyFX";
}

[Serializable]
public class Initial
{
    public int SauvegardeExiste;
}

public class Sauvegarde : MonoBehaviour 
{

	public static Initial Initialisation = new Initial ();
    public static Cle cle = new Cle();

    public static void Sauvegarder ()
    {
        PlayerPrefs.Save();
    }


    public static void CheckSave()
    {
        Sauvegarde.Initialisation.SauvegardeExiste = PlayerPrefs.GetInt(Sauvegarde.cle.KSauvegardeExiste);
        Debug.Log(Sauvegarde.Initialisation.SauvegardeExiste.ToString());
    }

    public static void Reinitialiser ()
	{
        PlayerPrefs.DeleteAll();
        // GameManager \\

        PlayerPrefs.SetInt(Sauvegarde.cle.KGMcycles, 0);
        PlayerPrefs.SetInt(Sauvegarde.cle.KGMcentraleslvl, 0);
        PlayerPrefs.SetInt(Sauvegarde.cle.KGMfermeslvl, 1);
        PlayerPrefs.SetInt(Sauvegarde.cle.KGMstationslvl, 1);
        PlayerPrefs.SetInt(Sauvegarde.cle.KGMexploitationslvl, 1);

        // Parametres \\

        Langues();
        PlayerPrefs.SetInt(Sauvegarde.cle.KSauvegardeExiste,1);
        PlayerPrefs.Save();
    }

    public static void Langues()
    {
        if (Application.systemLanguage == SystemLanguage.French)
        {
            PlayerPrefs.SetInt(Sauvegarde.cle.KLangues, 0);
            PlayerPrefs.Save();
            Debug.Log("Le systeme est en Français.");
        }
        else
        {
            PlayerPrefs.SetInt(Sauvegarde.cle.KLangues, 1);
            PlayerPrefs.Save();
            Debug.Log("Le systeme n'est pas en Français.");
        }
        
    }

    public static void SupprimerKey(string KeyName)
    {
        PlayerPrefs.DeleteKey(KeyName);
        PlayerPrefs.Save();
    }
}
