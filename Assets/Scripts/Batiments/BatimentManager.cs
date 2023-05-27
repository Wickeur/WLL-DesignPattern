using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatimentManager : MonoBehaviour
{
    public static BatimentManager _instance;
    public List<Batiments> _batiments = new List<Batiments>();

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

    public void PlayTurnBatiments()
    {
        for (int i = 0; i < _batiments.Count; i++)
        {
            _batiments[i].PlayTurn();
        }
    }
}
