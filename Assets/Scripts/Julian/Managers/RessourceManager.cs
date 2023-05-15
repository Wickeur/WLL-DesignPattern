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

    private bool PeuxAchetter(List<Cout> couts)
    {
        bool succes = true;
        
        for (int i = 0; i < couts.Count; i++)
        {
            for (int j = 0; j < _ressources.Count; j++)
            {
                if (couts[i].type == _ressources[j].GetTypeRessource() && !_ressources[j].PossedeRessource(couts[i].cout))
                {
                    succes = false;
                }
            }
        }

        return succes;
    }

    public bool Achetter(List<Cout> couts)
    {
        if (PeuxAchetter(couts))
        {
            for (int i = 0; i < couts.Count; i++)
            {
                for (int j = 0; j < _ressources.Count; j++)
                {
                    if (couts[i].type == _ressources[j].GetTypeRessource())
                    {
                        _ressources[j].Consommer(couts[i].cout);
                    }
                }
            }
            return true;
        }
        return false;
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
