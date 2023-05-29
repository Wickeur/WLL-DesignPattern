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

    [SerializeField] private List<GameObject> _cases = new List<GameObject>();

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
        _cases = cases;;
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
                    GameObject NewCase = CreerCase(_case_vide_prefab, x, y);
                    NewCase.gameObject.transform.parent = _stockage_cases_vides.transform;
                    NewCase.GetComponent<Case>().SetCase(x, y, false);
                    AjouterCaseListe(_cases, NewCase);
                }
                else
                {
                    GameObject NewCase = CreerCase(_case_pleine_prefab, x, y);
                    NewCase.gameObject.transform.parent = _stockage_cases_ressources.transform;
                    NewCase.GetComponent<Case>().SetCase(x, y, true);
                    AjouterCaseListe(_cases, NewCase);
                }
            }
        }
    }

    public GameObject CreerCase(GameObject prefab, int x, int y)
    {
        return Instantiate(prefab, new Vector3(x, y, 0), Quaternion.identity);
    }

    public void AjouterCaseListe(List<GameObject> _cases, GameObject casePlateau)
    {
        _cases.Add(casePlateau);
    }
    
    public List<Case> GetCasesNonOccupe()
    {
        List<Case> casesNonOccupe = new List<Case>();
        for (int i = 0; i < _cases.Count; i++)
        {
            if(!_cases[i].GetComponent<Case>().GetEstOccupe())
            {
                casesNonOccupe.Add(_cases[i].GetComponent<Case>());
            }
        }
        return casesNonOccupe;
    }

    public void deplacerSurPlateau(GameObject gameObject, Case case_cible)
    {
        gameObject.transform.position = case_cible.transform.position;
    }

    public Case checkCaseProche(Case _case, List<TypeRessource> TypesRessources)
    {
        Case caseLaPlusProche = null;
        int distanceCaseLaPlusProche = 999999; // Valeur absurbe
        
        for (int i = 0; i < _cases.Count; i++)
        {
            RessourceCase CaseRessource = _cases[i].GetComponent<RessourceCase>();
            if (CaseRessource != null)
            {
                for (int ressource = 0; ressource < TypesRessources.Count; ressource++)
                {
                    if (CaseRessource.getTypeRessource() == TypesRessources[ressource])
                    {
                        Case caseCible = _cases[i].GetComponent<Case>();
                        int distance = CalculDistanceEntreDeuxCases(_case, _cases[i].GetComponent<Case>());
                            
                        if (distance < distanceCaseLaPlusProche)
                        {
                            distanceCaseLaPlusProche = distance;
                            caseLaPlusProche = _cases[i].GetComponent<RessourceCase>();
                        }
                    }
                }
            }
        }
        return caseLaPlusProche;
    }

    public int CalculDistanceEntreDeuxCases(Case depart, Case cible)
    {
        int difference = Mathf.Abs(cible.GetX() - depart.GetX());
        difference += Mathf.Abs(cible.GetY() - depart.GetY());
        return difference;
    }

    public Case trouverCaseParCoordonnees(int x, int y)
    {
        for (int i = 0; i < _cases.Count; i++)
        {
            if (_cases[i].GetComponent<Case>().GetX() == x && _cases[i].GetComponent<Case>().GetY() == y)
            {
                return _cases[i].GetComponent<Case>();
            }
        }
        
        Debug.Log(x + "  :  " + y);
        return null;
    }

    public void changerRessourceCaseEnCase(RessourceCase ressourceCase)
    {
        GameObject NewCase = CreerCase(_case_vide_prefab, ressourceCase.GetX(), ressourceCase.GetY());
        NewCase.GetComponent<Case>().SetCase(ressourceCase.GetX(), ressourceCase.GetY(), true);
        NewCase.gameObject.transform.parent = _stockage_cases_vides.transform;
        UniteManager._instance.ajoutCaseAUniteQuiEnAPas(ressourceCase, NewCase.GetComponent<Case>());
        _cases.Remove(ressourceCase.gameObject);
        Destroy(ressourceCase.gameObject);
        _cases.Add(NewCase);
        
    }

    public int nbRessourceCaseRestantes()
    {
        int compteur = 0;
        for (int i = 0; i < _cases.Count; i++)
        {
            if(_cases[i].GetComponent<RessourceCase>() != null)
            {
                compteur++;
            }
        }
        return compteur;
    }

    public void checkGameOver()
    {
        if (nbRessourceCaseRestantes() == 0)
        {
            Debug.Log("Vous avez perdu !! Vous n'avez plus d'unitées.");
            GameManager._instance.setEnd(true);
        }
    }
}
