using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unite : MonoBehaviour
{
    [SerializeField] private int _vitesse;
    [SerializeField] private Cout _cout_par_tour;
    private bool _nourri;
    private int _quantite_experience;
    private Case _case;

    public Unite(int vitesse, Cout coutParTour, Case la_case)
    {
        _vitesse = vitesse;
        _cout_par_tour = coutParTour;
        _case = la_case;

        _nourri = true;
        _quantite_experience = 0;
    }

    public void InitCaseDepart()
    {
        List<Case> casesNonOccupe = Plateau.instance.GetCasesNonOccupe();
        int randomCase = Random.Range(0, casesNonOccupe.Count);
        _case = casesNonOccupe[randomCase];
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
