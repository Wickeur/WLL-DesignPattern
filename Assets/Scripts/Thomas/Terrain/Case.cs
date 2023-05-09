using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Case : MonoBehaviour
{
    private int _position_x;
    private int _position_y;
    bool _est_occupe;

    public Case(int x, int y, bool occupe)
    {
        _position_x = x;
        _position_y = y;
        _est_occupe = occupe;
    }


}
