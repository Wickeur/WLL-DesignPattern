using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recolteur : Unite
{
    private List<TypeRessource> _typesRessources_Recoltable;
    [SerializeField] private Outils _outil;

    public Recolteur(int vitesse, Cout coutParTour, Case la_case,List<TypeRessource> typesRessources, Outils outil) : base(vitesse, coutParTour, la_case)
    {
        _outil = outil;
        _typesRessources_Recoltable = typesRessources;
    }

    public void SetTypeRessources(List<TypeRessource> TypesRessources)
    {
        _typesRessources_Recoltable = TypesRessources;
    }

    public void SetOutil(Outils Outil)
    {
        _outil = Outil;
    }

    public override void PlayTurn()
    {
        int vitesse_restante = _vitesse;
        Case case_suivante = null;

        while(vitesse_restante > 0)
        {
            if (_case == Plateau.instance.checkCaseProche(_case, _typesRessources_Recoltable))
            {
                Recolter();
            }

            Case cible = Plateau.instance.checkCaseProche(_case, _typesRessources_Recoltable);

            while (_case.GetX() != cible.GetX() && vitesse_restante > 0)
            {
                if (_case.GetX() < cible.GetX())
                {
                    case_suivante = Plateau.instance.trouverCaseParCoordonnees(_case.GetX() + 1, _case.GetY());
                    SeDeplacer(case_suivante);
                    vitesse_restante--;
                }
                else
                {
                    case_suivante = Plateau.instance.trouverCaseParCoordonnees(_case.GetX() - 1, _case.GetY());
                    SeDeplacer(case_suivante);
                    vitesse_restante--;
                }
            }

            while (_case.GetY() != cible.GetY() && vitesse_restante > 0)
            {
                if (_case.GetX() < cible.GetX())
                {
                    case_suivante = Plateau.instance.trouverCaseParCoordonnees(_case.GetX() + 1, _case.GetY());
                    SeDeplacer(case_suivante);
                    vitesse_restante--;
                }
                else
                {
                    case_suivante = Plateau.instance.trouverCaseParCoordonnees(_case.GetX() - 1, _case.GetY());
                    SeDeplacer(case_suivante);
                    vitesse_restante--;
                }
            }
        }
    }

    public void Recolter()
    {

    }
}
