using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outils : MonoBehaviour
{
    int _niveau = 0;

    public Outils(int niveau)
    {
        _niveau = niveau;
    }
    
    public void Gain_Niveau()
    {
        _niveau++;
    }
}
