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
        // ajouter set pos pour l'unite
    }

    public void AmeliorerUnOutil()
    {
        
    }
}
