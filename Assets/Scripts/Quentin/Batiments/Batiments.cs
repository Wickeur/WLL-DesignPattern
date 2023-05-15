using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batiments : MonoBehaviour
{
    [SerializeField] private int _intervalle;
    [SerializeField] private List<Cout> _coutsAmelioration;

    public bool Ameliorer()
    {
        return RessourceManager._instance.Achetter(_coutsAmelioration);
    }
    
    public Batiments(int Intervalle, List<Cout> CoutsAmelioration)
    {
        _intervalle = Intervalle;
        _coutsAmelioration = CoutsAmelioration;
    }
    
}
