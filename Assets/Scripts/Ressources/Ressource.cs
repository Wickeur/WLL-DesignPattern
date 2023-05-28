using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ressource : MonoBehaviour
{
    // SerializeField = permet de définir dans unity les variables privées
    [SerializeField] private int _quantite = 0;
    [SerializeField] private TypeRessource _type_ressource;
    [SerializeField] private TextMeshProUGUI _textUI;

    public Ressource(int quantite, TypeRessource typeRessource)
    {
        _quantite = quantite;
        _type_ressource = typeRessource;
    }

    public bool PossedeRessource(int cout)
    {
        if (cout <= _quantite)
        {
            return true;
        }

        return false;
    }

    public TypeRessource GetTypeRessource()
    {
        return _type_ressource;
    }

    public int GetQuantite()
    {
        return _quantite;
    }

    public void InitialiserRessource(int quantite)
    {
        _quantite = quantite;
        ActualiserText();
    }

    public void Ajouter(int valeur)
    {
        _quantite += valeur;
        ActualiserText();
    }

    public void Consommer(int valeur)
    {
        _quantite -= valeur;
        ActualiserText();
    }

    public void ActualiserText()
    {
        _textUI.text = _quantite.ToString();
    }
}
