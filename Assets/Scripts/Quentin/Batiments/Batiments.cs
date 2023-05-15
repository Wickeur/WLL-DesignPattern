using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batiments
{
    [SerializeField] private int _intervalle;
    [SerializeField] private List<Cout> _coutsAmelioration;

    public bool Ameliorer()
    {
        return RessourceManager._instance.Achetter(_coutsAmelioration);
    }
    
    public Batiments(int Intervalle)
    {
        _intervalle = Intervalle;
    }
    
}
