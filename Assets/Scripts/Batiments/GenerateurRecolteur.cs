using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateurRecolteur : Batiments
{
    [SerializeField] private List<TypeRessource> typeRessourcesRecolteur = new List<TypeRessource>();
    
    public GenerateurRecolteur(int Intervalle, List<Cout> CoutsProduction) : base(Intervalle,CoutsProduction)
    {
        
    }

    public void CreerRecolteur()
    {
        GameObject Recolteur = Instantiate(UniteManager._instance.GetRecolteur(), Vector3.zero, Quaternion.identity);
        
        Recolteur RecolteurScript = Recolteur.GetComponent<Recolteur>();
        RecolteurScript.SetTypeRessources(typeRessourcesRecolteur);
        
        UniteManager._instance.AjouterUnite(Recolteur);
        
        Debug.Log("Un recolteur vien d'être crée");
    }

    public override void PlayTurn()
    {
        _nbTourAvantProduction --;
        if (_nbTourAvantProduction <= 0)
        {
            Produire();
            _nbTourAvantProduction = _intervalle;
        }
    }
    
    public override void Produire()
    {
        if (RessourceManager._instance.Achetter(_coutsProduction))
        {
            CreerRecolteur();
        }
    }
}
