using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool _end = false;
    [SerializeField] private float _interval_turn = 2f;
    public void demarrerUnePartie()
    {
        Debug.Log("La partie a démarée");
    }

    // Start is called before the first frame update
    void Start()
    {
        demarrerUnePartie();
        RessourceManager._instance.InitialiserRessources();
        StartCoroutine(SystemTurn());
    }
    
    public IEnumerator SystemTurn()
    {
        int nbTurn = 0;
        UniteManager UM = UniteManager._instance;
        BatimentManager BM = BatimentManager._instance;
        
        while (_end == false)
        {
            yield return new WaitForSeconds(_interval_turn);
            nbTurn++;
            Debug.Log("Le tour " + nbTurn + " vien de débuter !");
            
            UM.PlayTurnUnites();
            BM.PlayTurnBatiments();

            UM.ActualiserPositionVisuelUnites();
        }
    }
}
