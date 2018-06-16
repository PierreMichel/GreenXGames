using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitialisationSauvegarde : MonoBehaviour {

	private int LaSauvegardeExiste;
    public InputField Mail;
    public InputField Mdp;

	void Start ()
	{	
		Sauvegarde.CheckSave ();
		LaSauvegardeExiste = Sauvegarde.Initialisation.SauvegardeExiste;

        if (LaSauvegardeExiste == 0)
        {
            Sauvegarde.Reinitialiser();
            Debug.Log("Sauvegarde Initialisée");
        }
    }
}
