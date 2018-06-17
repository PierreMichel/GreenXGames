using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tuto : MonoBehaviour
{
    public Text txtTuto;
    public GameObject TutoPanel;
    public GameObject zonedeconstruction;
    public GameObject Licorne;
    public Transform bulle;
    public Transform Positionbulle1;
    public Transform Positionbulle2;
    public AudioSource son;
    public AudioClip pop;
    public AudioClip plip;
    public Color transpar;
    public Color transparMiddle;
    public Sprite uimask1;
    public Sprite imagenormal;
    public Image ImagePaneltuto;


    public Transform Cam;
    int txt = -1;

    private void Awake()
    {
        txtTuto.text = "";
        if (PlayerPrefs.GetInt(Sauvegarde.cle.KGMcycles) != 0)
        {
            Destroy(TutoPanel);
            Destroy(this.gameObject);
        }
        else
        {
            zonedeconstruction.GetComponent<BoxCollider>().enabled = false;  
        }
        Cliclic();
    }
    

    public void Cliclic()
    {
        txt++;
        if (txt == 0)
        {
            ImagePaneltuto.sprite = imagenormal;
            TutoPanel.SetActive(true);
            txtTuto.text = "Bienvenue !";
            son.clip = pop;
            son.Play();
        }
        if (txt == 1)
        {
            ImagePaneltuto.sprite = imagenormal;
            TutoPanel.SetActive(true);
            txtTuto.text = "Je vais t’accompagner dans la découverte de ta planète et de son fonctionnement.";
            son.clip = pop;
            son.Play();
        }
        if (txt == 2)
        {
            ImagePaneltuto.sprite = imagenormal;
            TutoPanel.SetActive(true);
            txtTuto.text = "Je préfère te prévenir tout de suite…";
            son.clip = pop;
            son.Play();
        }
        if (txt == 3)
        {
            ImagePaneltuto.sprite = imagenormal;
            TutoPanel.SetActive(true);
            txtTuto.text = "Ton prédécesseur ne l’a pas laissé en très bon état.";
            son.clip = pop;
            son.Play();
        }
        if (txt == 4)
        {
            ImagePaneltuto.sprite = imagenormal;
            TutoPanel.SetActive(true);
            txtTuto.text = "Mais je suis sûr que tu vas t’en sortir ! N’est-ce pas ?";
            son.clip = pop;
            son.Play();
        }
        if (txt == 5)
        {
            ImagePaneltuto.sprite = imagenormal;
            TutoPanel.GetComponent<Image>().color = transpar;
            Licorne.SetActive(false);
            bulle.transform.position = Positionbulle2.position;
            TutoPanel.SetActive(true);
            txtTuto.text = "… Oh.";
            son.clip = pop;
            son.Play();
        }
        if (txt == 6)
        {
            ImagePaneltuto.sprite = imagenormal;
            TutoPanel.SetActive(true);
            txtTuto.text = "… C’est encore pire que je ne le pensais. ";
            son.clip = pop;
            son.Play();
        }
        if (txt == 7)
        {
            ImagePaneltuto.sprite = imagenormal;
            TutoPanel.SetActive(true);
            txtTuto.text = "Toute la planète est bloquée sous un nuage de pollution !";
            son.clip = pop;
            son.Play();
        }
        if (txt == 8)
        {
            ImagePaneltuto.sprite = imagenormal;
            TutoPanel.SetActive(true);
            txtTuto.text = "Tu ne pourras rien faire dans ses conditions. J’ai une solution : elle est temporaire, mais nous n’avons pas le choix.";
            son.clip = pop;
            son.Play();
        }
        if (txt == 9)
        {
            ImagePaneltuto.sprite = uimask1;
            TutoPanel.GetComponent<Image>().color = transparMiddle;
            Licorne.SetActive(true);
            bulle.transform.position = Positionbulle1.position;
            TutoPanel.SetActive(true);
            txtTuto.text = "	J’ai créé une usine de recyclage. Nous allons y entreposer une grande partie de notre pollution et de nos déchets. ";
            son.clip = plip;
            son.Play();
        }
        if (txt == 10)
        {
            ImagePaneltuto.sprite = imagenormal;
            TutoPanel.GetComponent<Image>().color = transparMiddle;
            TutoPanel.SetActive(true);
            txtTuto.text = "";
            son.clip = pop;
            son.Play();
        }
        if (txt == 11)
        {
            ImagePaneltuto.sprite = imagenormal;
            TutoPanel.SetActive(true);
            txtTuto.text = "";
            son.clip = pop;
            son.Play();
        }

    }
}       
