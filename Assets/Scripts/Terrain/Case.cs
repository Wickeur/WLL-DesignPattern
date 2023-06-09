using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Case : MonoBehaviour
{
    private int _position_x;
    private int _position_y;
    private bool _est_occupe;

    public Case(int x, int y, bool occupe)
    {
        _position_x = x;
        _position_y = y;
        _est_occupe = occupe;
    }

    public int GetX()
    {
        return _position_x;
    }

    public int GetY()
    {
        return _position_y;
    }

    public void SetCase(int x, int y, bool occupe)
    {
        _position_x = x;
        _position_y = y;
        _est_occupe = occupe;
    }

    public Vector2 GetPosition()
    {
        return new Vector2(_position_x, _position_y);
    }

    public bool GetEstOccupe()
    {
        return _est_occupe;
    }

    public void SetEstoccupe(bool occupe)
    {
        _est_occupe = occupe;
    }

    public void SetEstOccupe(bool etat)
    {
        _est_occupe = etat;
    }
}
