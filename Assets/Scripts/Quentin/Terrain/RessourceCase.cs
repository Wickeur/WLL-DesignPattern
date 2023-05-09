using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RessourceCase : Case
{
    TypeRessource _type_ressource;
    int _quantite_ressource;

    public RessourceCase(int x, int y, bool occupe, TypeRessource typeRessource, int quantiteRessource) : base(x,y,occupe)
    {
        _type_ressource = typeRessource;
        _quantite_ressource = quantiteRessource;
    }
}
