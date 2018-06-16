using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitialisationSauvegarde : MonoBehaviour
{

	private int LaSauvegardeExiste;

	void Awake ()
	{	
		Sauvegarde.CheckSave ();
		LaSauvegardeExiste = Sauvegarde.Initialisation.SauvegardeExiste;

        if (LaSauvegardeExiste == 0)
        {
            Sauvegarde.Reinitialiser();
            Debug.Log("Sauvegarde Initialisée");
        }
        else
        {
            Debug.Log("pas besoin d'initialiser la sauvegarde");
        }
    }
}
