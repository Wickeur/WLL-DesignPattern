using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outils
{
    int _niveau = 0;

    public Outils(int niveau)
    {
        _niveau = niveau;
    }

    public void Affecter_Unite()
    {

    }

    public void Gain_Niveau()
    {
        _niveau++;
    }
}
