using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recolteur : Unite
{
    List<TypeRessource> _typesRessources_Recoltable;
    Outils _outil;

    public Recolteur(int vitesse, int coutParTour, Case la_case,List<TypeRessource> typesRessources, Outils outil) : base(vitesse, coutParTour, la_case)
    {
        _outil = outil;
        _typesRessources_Recoltable = typesRessources;
    }

    public void Recolter()
    {

    }
}
