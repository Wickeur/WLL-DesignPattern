using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RessourceManager : MonoBehaviour
{
    // Sigleton = permet de créer une instance unique d'une classe
    //Créer un sigleton
    public static RessourceManager _instance;

    [SerializeField] private List<Ressource> _ressources; // Liste des ressources
    [SerializeField] private int _quantite_ressource_initiale = 50; // Quantité de ressource de départ

    public void InitialiserRessources()
    {
        for(int i = 0; i < _ressources.Count; i++)
        {
            _ressources[i].InitialiserRessource(_quantite_ressource_initiale);
        }
    }

    public void Awake()
    {
        // Si l'instance est null, alors l'instance est cette instance
        if (_instance == null)
        {
            _instance = this;
        }

        // Si l'instance est différente de cette instance, alors détruire cette instance
        if (_instance != this)
        {
            Destroy(this);
        }
    }
}
