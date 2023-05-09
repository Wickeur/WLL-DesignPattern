using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void demarrerUnePartie()
    {
        Debug.Log("La partie a démarée");
    }

    // Start is called before the first frame update
    void Start()
    {
        demarrerUnePartie();
        RessourceManager._instance.InitialiserRessources();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
