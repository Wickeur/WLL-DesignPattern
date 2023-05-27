using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoixSpriteRecolteur : MonoBehaviour
{
    [SerializeField] private Recolteur _recolteur;
    [SerializeField] private GameObject _bucheron;
    [SerializeField] private GameObject _mineur;
    [SerializeField] private GameObject _paysan;

    // Start is called before the first frame update
    void Start()
    {
        choisiLeBonSprite();
    }

    public void choisiLeBonSprite()
    {
        if (_recolteur.GetTypeRessources()[0] == TypeRessource.NOURRITURE)
        {
            _bucheron.gameObject.SetActive(false);
            _mineur.gameObject.SetActive(false);
            _paysan.gameObject.SetActive(true);
        }
        if (_recolteur.GetTypeRessources()[0] == TypeRessource.BOIS)
        {
            _bucheron.gameObject.SetActive(true);
            _mineur.gameObject.SetActive(false);
            _paysan.gameObject.SetActive(false);
        }
        if (_recolteur.GetTypeRessources()[0] == TypeRessource.PIERRE && _recolteur.GetTypeRessources()[1] == TypeRessource.OR || _recolteur.GetTypeRessources()[1] == TypeRessource.PIERRE && _recolteur.GetTypeRessources()[0] == TypeRessource.OR)
        {
            _bucheron.gameObject.SetActive(false);
            _mineur.gameObject.SetActive(true);
            _paysan.gameObject.SetActive(false);
        }
    }
}
