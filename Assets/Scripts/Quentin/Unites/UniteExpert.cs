using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniteExpert : Unite
{
    int _Bonus_Efficacite;
    int _Nb_Tour_Affame;

    public UniteExpert(int vitesse, int coutParTour, Case la_case, int BonusEff) : base (vitesse, coutParTour, la_case)
    {
        _Bonus_Efficacite = BonusEff;
        _Nb_Tour_Affame = 0;
    }

    public void IncrementeTourAffame()
    {
        _Nb_Tour_Affame++;
    }
}
