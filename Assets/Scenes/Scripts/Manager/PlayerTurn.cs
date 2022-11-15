using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurn : MonoBehaviour
{
    [SerializeField] private TurnManager playerActive;
    private int playerIndex;
    private bool followThisPlayer;

    public void SetPlayerTurn(int index)
    {
        playerIndex = index;
        //Debug.Log("This instance 6 :  " + index);
    }

    public bool IsPlayerTurn()
    {
        Debug.Log("This instance 004 from PTurn :  " + playerIndex + " _this_ >" + TurnManager.GetInstance().IsItPlayerTurn(playerIndex));
        //Debug.Log("This instance 5 :  " + TurnManager.GetInstance().IsItPlayerTurn(playerIndex));
        followThisPlayer = TurnManager.GetInstance().IsItPlayerTurn(playerIndex);

        if (followThisPlayer)
        {
            GetCurrentPlayer();
        }
        else
            Debug.Log("nottrue" + followThisPlayer);

       
        return TurnManager.GetInstance().IsItPlayerTurn(playerIndex);
    }

    public void GetCurrentPlayer()
    {
        //followThisPlayer = playerActive;
        //Debug.Log("Active 000:                              " + followThisPlayer);
        //Debug.Log("Active 000" + followThisPlayer);
    }
}
