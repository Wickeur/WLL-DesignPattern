using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RessourceCase : Case
{
    [SerializeField] private TypeRessource _type_ressource;
    [SerializeField] private int _quantite_ressource;

    private void Start()
    {
        int _quantite_ressource_init = Random.Range(10, 101);
        _quantite_ressource = _quantite_ressource_init;
        int ressource_aleatoire = Random.Range(0, 4);
        _type_ressource = (TypeRessource)ressource_aleatoire;

    }

    public RessourceCase(int x, int y, bool occupe, TypeRessource typeRessource, int quantiteRessource) : base(x,y,occupe)
    {
        _type_ressource = typeRessource;
        _quantite_ressource = quantiteRessource;
        SetCase(x, y, true);
    }

    public TypeRessource getTypeRessource()
    {
        return _type_ressource;
    }

    public int PerdreRessource(int quantite)
    {
        _quantite_ressource -= quantite;
        if (_quantite_ressource <= 0)
        {
            int valeurAbsolue = _quantite_ressource * -1;
            Plateau.instance.changerRessourceCaseEnCase(this);
            return quantite - valeurAbsolue;
        }

        return quantite;
    }
}
