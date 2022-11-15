using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    private static TurnManager instance;
    [SerializeField] private PlayerTurn playerOne;
    [SerializeField] private PlayerTurn playerTwo;
    [SerializeField] private float timeBetweenTurns;

    private int currentPlayerIndex;
    private bool waitingForNextTurn;
    private float turnDelay;

    private void Awake()
    {
        Debug.Log("This instance returning : " + instance);
        if (instance == null)
        {
            instance = this;
            currentPlayerIndex = 1;
            playerOne.SetPlayerTurn(1);
            playerTwo.SetPlayerTurn(2);
            playerTwo.gameObject.transform.GetChild(0).GetComponent<Camera>().enabled = false;
        }

        
        //Debug.Log("This instance 2" + instance);
    }

    private void Update()
    {
        if (waitingForNextTurn)
        {
            turnDelay += Time.deltaTime;
            if (turnDelay >= timeBetweenTurns)
            {
                turnDelay = 0;
                waitingForNextTurn = false;
                ChangeTurn();
            }
        }

        //Debug.Log("This index 00 1   :  " + playerOne);
        //Debug.Log("This index 00 2   :  " + playerTwo.tag);

        //GetPlayerPos();
        ActiveObject();
    }

    //public void GetPlayerPos()
    //{
    //    Debug.Log("This index 00aa 1   :  " + playerOne.tag);
    //    if (playerOne.tag == "True")
    //    {
    //        Debug.Log("This index 00a 1   :  " + playerOne);
    //    }

    //    if (playerTwo)
    //    {
    //        Debug.Log("This index 00a 2   :  " + playerTwo);
    //    }
    //}


    public bool IsItPlayerTurn(int index)
    {
        if (waitingForNextTurn)
        {
            return false;
        }
        return index == currentPlayerIndex;
    }

    public static TurnManager GetInstance()
    {
        return instance;
    }
    
    public void TriggerChangeTurn()
    {
        waitingForNextTurn = true;
    }

    private void ChangeTurn()
    {
        if (currentPlayerIndex == 1)
        {
            currentPlayerIndex = 2;
        }
        else if (currentPlayerIndex == 2)
        {
            currentPlayerIndex = 1;
        }
    }

    public static string ActiveObject()
    {
        //Debug.Log("This instance 3 GetInst : " + instance.currentPlayerIndex);

        if (instance.currentPlayerIndex == 1)
        {
            //Debug.Log("This instance 3 : : " + TurnManager.instance.playerOne.name);
            return TurnManager.instance.playerOne.name;
        }

        else
        {
            Debug.Log("This instance 3 : : " + TurnManager.instance.playerTwo.name);
            return TurnManager.instance.playerTwo.name;
        }
    }

}
