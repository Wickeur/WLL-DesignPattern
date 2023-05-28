using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniteManager : MonoBehaviour
{
    public static UniteManager _instance;
    [SerializeField] private GameObject _recolteur;
    private List<GameObject> _unites = new List<GameObject>();

    public void Awake()
    {
        // Si l'instance est null, alors l'instance est cette instance
        if (_instance == null)
        {
            _instance = this;
        }

        // Si l'instance est différente de cette instance, alors détruire cette instance
        if (_instance != this)
        {
            Destroy(this);
        }
    }

    public GameObject GetRecolteur()
    {
        return _recolteur;
    }

    public void AjouterUnite(GameObject unite)
    {
        _unites.Add(unite);
        unite.GetComponent<Unite>().InitCaseDepart();
    }

    public void PlayTurnUnites()
    {
        for (int i = 0; i < _unites.Count; i++)
        {
            _unites[i].GetComponent<Unite>().PlayTurn();
        }
        
    }

    public void ActualiserPositionVisuelUnites()
    {
        for (int i = 0; i < _unites.Count; i++)
        {
            Unite myUnite = _unites[i].GetComponent<Unite>();
            _unites[i].transform.position = new Vector3(myUnite._case.GetX(), myUnite._case.GetY(), 0);
        }
    }

    public void AmeliorerUnOutil()
    {
        
    }

    public void tuerUnite(Unite cible)
    {
        _unites.Remove(cible.gameObject);
        Destroy(cible.gameObject);
        checkGameOver();
    }

    public void checkGameOver()
    { 
        if (_unites.Count == 0)
        {
            Debug.Log("Vous avez perdu !! Vous n'avez plus d'unitées.");
            GameManager._instance.setEnd(true);
        }
    }

    public void ajoutCaseAUniteQuiEnAPas(Case cible, Case remplacant)
    {
        for (int i = 0;  i <_unites.Count; i++)
        {
            if (_unites[i].GetComponent<Unite>()._case == null)
            {
                _unites[i].GetComponent<Unite>()._case = remplacant;
            }
        }
    }
}
