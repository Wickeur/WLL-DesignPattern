using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutilManager : MonoBehaviour
{
    public static OutilManager _instance;
    
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

}
