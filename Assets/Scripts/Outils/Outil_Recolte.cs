using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outil_Recolte : Outils
{
    string _nom = "";
    [SerializeField] int _rendement = 1;
    TypeRessource _typeRessource;

    public Outil_Recolte(string nom, int rendement, TypeRessource typeRessource, int niveau) : base (niveau)
    {
        _nom = nom;
        _rendement = rendement;
        _typeRessource = typeRessource;
    }

    public int getRendement()
    {
        return _rendement;
    }
}
