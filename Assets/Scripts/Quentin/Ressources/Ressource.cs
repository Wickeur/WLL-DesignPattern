using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ressource
{
    int _quantite = 0;
    TypeRessource _type_ressource;

    public Ressource(int quantite, TypeRessource typeRessource)
    {
        _quantite = quantite;
        _type_ressource = typeRessource;
    }

    public void Ajouter(int valeur)
    {
        _quantite += valeur;
    }

    public void Consommer(int valeur)
    {
        _quantite -= valeur;
    }
}
