using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateurRecolteur : Batiments
{
    [SerializeField] private List<TypeRessource> typeRessourcesRecolteur;
    
    public GenerateurRecolteur(int Intervalle, List<Cout> CoutsAmelioration) : base(Intervalle,CoutsAmelioration)
    {
        
    }

    public void CreerRecolteur()
    {
        GameObject Recolteur = Instantiate(UniteManager._instance.GetRecolteur(), Vector3.zero, Quaternion.identity);
        
        Recolteur RecolteurScript = Recolteur.GetComponent<Recolteur>();
        RecolteurScript.SetTypeRessources(typeRessourcesRecolteur);
        
        UniteManager._instance.AjouterUnite(Recolteur);
    }
}
