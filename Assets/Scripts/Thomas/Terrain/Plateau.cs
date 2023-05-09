using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plateau : MonoBehaviour
{
    [Header("Unity")] 
    [SerializeField] private GameObject _case_vide_prefab;
    [SerializeField] private GameObject _case_pleine_prefab;
    [SerializeField] private GameObject _stockage_cases_vides;
    [SerializeField] private GameObject _stockage_cases_ressources;

    [SerializeField] private int _hauteur;
    [SerializeField] private int _largeur;

    private List<GameObject> _cases;

    public static Plateau instance;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
        }

        if (instance == null)
        {
            instance = this;
        }
    }

    // A delete plus tard utilisé uniquement pour mes tests
    private void Start()
    {
        initPlateau();
    }

    public Plateau(int hauteur, int largeur, List<GameObject> cases)
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
                    GameObject NewCase = Instantiate(_case_vide_prefab, new Vector3(x, y, 0), Quaternion.identity);
                    NewCase.gameObject.transform.parent = _stockage_cases_vides.transform;
                    NewCase.GetComponent<Case>().SetCase(x, y, false);
                    AjouterCase(NewCase);
                }
                else
                {
                    GameObject NewCase = Instantiate(_case_pleine_prefab, new Vector3(x, y, 0), Quaternion.identity);
                    NewCase.gameObject.transform.parent = _stockage_cases_ressources.transform;
                    NewCase.GetComponent<Case>().SetCase(x, y, true);
                    AjouterCase(NewCase);
                }
            }
        }
    }

    public void AjouterCase(GameObject casePlateau)
    {
        _cases.Add(casePlateau);
    }
}
