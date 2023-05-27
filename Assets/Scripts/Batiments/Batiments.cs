using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batiments : MonoBehaviour
{
    [SerializeField] protected int _intervalle;
    protected int _nbTourAvantProduction = 0;
    [SerializeField] protected List<Cout> _coutsProduction;

    public virtual void Produire()
    {
        
    }
    
    public Batiments(int Intervalle, List<Cout> CoutsProduction)
    {
        _intervalle = Intervalle;
        _coutsProduction = CoutsProduction;
    }

    public virtual void PlayTurn()
    {
        
    }
    
}
