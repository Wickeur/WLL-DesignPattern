using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniteMonture : Unite
{
    int _Bonus_Deplacement;
    int _Consommation_Supplementaire;

    public UniteMonture(int vitesse, int coutParTour, Case la_case, int BonusDep, int ConsommationSupp) : base(vitesse, coutParTour, la_case)
    {
        _Bonus_Deplacement = BonusDep;
        _Consommation_Supplementaire = ConsommationSupp;
    }
}
