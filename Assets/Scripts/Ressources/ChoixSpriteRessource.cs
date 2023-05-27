using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoixSpriteRessource : MonoBehaviour
{
    [SerializeField] private RessourceCase _ressourceCase;
    [SerializeField] private GameObject _nourriture;
    [SerializeField] private GameObject _bois;
    [SerializeField] private GameObject _pierre;
    [SerializeField] private GameObject _or;

    // Start is called before the first frame update
    void Start()
    {
        choisiLeBonSprite();
    }

    public void choisiLeBonSprite()
    {
        if (_ressourceCase.getTypeRessource() == TypeRessource.NOURRITURE)
        {
            _nourriture.gameObject.SetActive(true);
            _bois.gameObject.SetActive(false);
            _pierre.gameObject.SetActive(false);
            _or.gameObject.SetActive(false);
        }
        if (_ressourceCase.getTypeRessource() == TypeRessource.BOIS)
        {
            _nourriture.gameObject.SetActive(false);
            _bois.gameObject.SetActive(true);
            _pierre.gameObject.SetActive(false);
            _or.gameObject.SetActive(false);
        }
        if (_ressourceCase.getTypeRessource() == TypeRessource.PIERRE)
        {
            _nourriture.gameObject.SetActive(false);
            _bois.gameObject.SetActive(false);
            _pierre.gameObject.SetActive(true);
            _or.gameObject.SetActive(false);
        }
        if (_ressourceCase.getTypeRessource() == TypeRessource.OR)
        {
            _nourriture.gameObject.SetActive(false);
            _bois.gameObject.SetActive(false);
            _pierre.gameObject.SetActive(false);
            _or.gameObject.SetActive(true);
        }
    }
}
