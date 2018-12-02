using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
    
public class PieceManager : MonoBehaviour
{
    // Keeps track of the players progress 

    public int NumPieces = 5;
    private int DestroyedAmmount = 0;

    public void destoyed(string piece)
    {
        DestroyedAmmount = DestroyedAmmount + 1;

        if (DestroyedAmmount == NumPieces)
        {
            SceneManager.LoadScene(2);
        }
    }

    // Times out player after set time if they dont complete the game in time.

    public int Timeout = 600;
    private int CurrentTime = 0;

    private void FixedUpdate()
    {
        CurrentTime += 1;

        if (CurrentTime == Timeout)
        {
            SceneManager.LoadScene(3);
        }
    }
}
