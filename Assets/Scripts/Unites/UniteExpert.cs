using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniteExpert : Unite
{
    int _Bonus_Efficacite;

    public UniteExpert(int vitesse, Cout coutParTour, Case la_case, int BonusEff) : base (vitesse, coutParTour, la_case)
    {
        _Bonus_Efficacite = BonusEff;
    }
}
