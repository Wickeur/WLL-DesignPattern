using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plateau : MonoBehaviour
{
    [Header("Unity")] 
    [SerializeField] private Case _case_vide_prefab;
    [SerializeField] private RessourceCase _case_pleine_prefab;
    [SerializeField] private GameObject _stockage_cases_vides;
    [SerializeField] private GameObject _stockage_cases_pleines;

    [SerializeField] private int _hauteur;
    [SerializeField] private int _largeur;
    List<Case> _cases;

    // A delete
    private void Start()
    {
        initPlateau();
    }

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
                    GameObject NewCase = Instantiate(_case_vide_prefab, new Vector3(x, y, 0), Quaternion.identity).gameObject;
                    NewCase.transform.parent = _stockage_cases_vides.transform;
                }
                else
                {
                    GameObject NewCase = Instantiate(_case_pleine_prefab, new Vector3(x, y, 0), Quaternion.identity).gameObject;
                    NewCase.transform.parent = _stockage_cases_pleines.transform;
                }
            }
        }
    }
}
