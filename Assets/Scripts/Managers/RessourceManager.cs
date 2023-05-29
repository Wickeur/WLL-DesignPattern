using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RessourceManager : MonoBehaviour
{
    public static RessourceManager _instance;

    [SerializeField] private List<Ressource> _ressources = new List<Ressource>(); // Liste des ressources
    [SerializeField] private int _quantite_ressource_initiale = 50; // Quantité de ressource de départ

    public List<Ressource> getRessources()
    {
        return _ressources;
    }


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

    private bool PeuxAchetter(Cout cout)
    {
        bool succes = true;

        for (int j = 0; j < _ressources.Count; j++)
        {
            if (cout.type == _ressources[j].GetTypeRessource() && !_ressources[j].PossedeRessource(cout.cout))
            {
                 succes = false;
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

    public bool Achetter(Cout cout)
    {
        if (PeuxAchetter(cout))
        {
            for (int j = 0; j < _ressources.Count; j++)
            {
                if (cout.type == _ressources[j].GetTypeRessource())
                {
                    _ressources[j].Consommer(cout.cout);
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
