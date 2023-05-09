using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ressource : MonoBehaviour
{
    [SerializeField] private int _quantite = 0;
    [SerializeField] private TypeRessource _type_ressource;

    public Ressource(int quantite, TypeRessource typeRessource)
    {
        _quantite = quantite;
        _type_ressource = typeRessource;
    }

    public void InitialiserRessource(int quantite)
    {
        _quantite = quantite;
    }

    public void Ajouter(int valeur)
    {
        _quantite += valeur;
    }

    public void Consommer(int valeur)
    {
        _quantite -= valeur;
    }
}
