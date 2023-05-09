using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RessourceManager : MonoBehaviour
{
    //Créer un sigleton
    private static RessourceManager _instance;

    public void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }

        if (_instance != this)
        {
            Destroy(this);
        }
    }
}
