using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plateau : MonoBehaviour
{
    [Header("Unity")] 
    public Case caseVidePrefab;
    public RessourceCase casePleinePrefab;

    int _hauteur;
    int _largeur;
    List<Case> _cases;

    public Plateau(int hauteur, int largeur, List<Case> cases)
    {
        _hauteur = hauteur;
        _largeur = largeur;
        _cases = cases;
    }

    private void initPlateau()
    {
        for (int x = 0; x < _largeur; x++)
        {
            for (int y = 0; y < _hauteur; y++)
            {
                int random = Random.Range(0, 2);
                if (random == 0)
                {
                    Instantiate(caseVidePrefab, new Vector3(x, y, 0), Quaternion.identity);
                }
                else
                {
                    Instantiate(casePleinePrefab, new Vector3(x, y, 0), Quaternion.identity);
                }
            }
        }
    }
}
