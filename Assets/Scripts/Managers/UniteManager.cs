using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniteManager : MonoBehaviour
{
    public static UniteManager _instance;
    [SerializeField] private GameObject _recolteur;
    private List<GameObject> _unites;

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
}
