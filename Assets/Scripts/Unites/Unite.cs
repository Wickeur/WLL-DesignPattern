using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unite : MonoBehaviour
{
    [SerializeField] protected int _vitesse;
    [SerializeField] private Cout _cout_par_tour;
    private bool _nourri;
    private int _quantite_experience;
    public Case _case;

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
        _case.SetEstoccupe(true);
    }

    public void Ameliorer()
    {

    }

    public void SeDeplacer(Case la_case)
    {
        _case.SetEstoccupe(false);
        la_case.SetEstoccupe(true);
        _case = la_case;
    }

    public void seNourrir()
    {
        List<Cout> couts = new List<Cout>();
        if (!RessourceManager._instance.Achetter(_cout_par_tour))
        {
            mourir();
        }
        _quantite_experience++;
    }

    public void mourir()
    {
        UniteManager._instance.tuerUnite(this);
    }

    public void DevenirExpert()
    {

    }

    public virtual void PlayTurn()
    {
        seNourrir();
    }

    public int getVitesse()
    {
        return _vitesse;
    }
}
