using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unite
{
    int _vitesse;
    int _cout_par_tour;
    bool _nourri;
    int _quantite_experience;
    Case _case;

    public Unite(int vitesse, int coutParTour, Case la_case)
    {
        _vitesse = vitesse;
        _cout_par_tour = coutParTour;
        _case = la_case;

        _nourri = true;
        _quantite_experience = 0;
    }

    public void Ameliorer()
    {

    }

    public void SeDeplacer(Case la_case)
    {

    }

    public void DevenirExpert()
    {

    }
}
