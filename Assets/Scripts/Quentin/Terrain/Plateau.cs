using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plateau 
{
    int _hauteur;
    int _largeur;
    List<Case> _cases;

    public Plateau(int hauteur, int largeur, List<Case> cases)
    {
        _hauteur = hauteur;
        _largeur = largeur;
        _cases = cases;
    }
}
