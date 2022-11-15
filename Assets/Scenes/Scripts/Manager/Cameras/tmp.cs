//using System;
//public class NewClass
//{
//    public NewClass()
//    {
//    }
//}








//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class ActivePlayerCamera : MonoBehaviour
//{
//    [SerializeField] private ActivePlayerManager manager;
//    [SerializeField] private Vector3 distanceFromThePlayer;
//    [SerializeField] private float speed;

//    void Update()
//    {
//        Vector3 targetPosition = manager.GetCurrentPlayer().transform.position + distanceFromThePlayer;

//        float step = speed * Time.deltaTime;
//        transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);
//    }
//}





//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using TMPro;

//public class ActivePlayerManager : MonoBehaviour
//{
//    [SerializeField] private ActivePlayer player1;
//    [SerializeField] private ActivePlayer player2;
//    [SerializeField] private float maxTimePerTurn;
//    [SerializeField] private float timeBetweenTurns;
//    [SerializeField] private Image clock;
//    [SerializeField] private TextMeshProUGUI seconds;

//    private ActivePlayer currentPlayer;
//    private float currentTurnTime;
//    private float currentDelay;

//    void Start()
//    {
//        player1.AssignManager(this);
//        player2.AssignManager(this);

//        currentPlayer = player1;
//    }

//    private void Update()
//    {
//        if (currentDelay <= 0)
//        {
//            currentTurnTime += Time.deltaTime;

//            if (currentTurnTime >= maxTimePerTurn)
//            {
//                ChangeTurn();
//                ResetTimers();
//            }
//            UpdateTimeVisuals();
//        }
//        else
//        {
//            currentDelay -= Time.deltaTime;
//        }
//    }

//    public bool PlayerCanPlay()
//    {
//        return currentDelay <= 0;
//    }

//    public ActivePlayer GetCurrentPlayer()
//    {
//        return currentPlayer;
//    }

//    public void ChangeTurn()
//    {
//        if (player1 == currentPlayer)
//        {
//            currentPlayer = player2;
//        }
//        else if (player2 == currentPlayer)
//        {
//            currentPlayer = player1;
//        }

//        ResetTimers();
//        UpdateTimeVisuals();
//    }

//    private void ResetTimers()
//    {
//        currentTurnTime = 0;
//        currentDelay = timeBetweenTurns;
//    }

//    private void UpdateTimeVisuals()
//    {
//        clock.fillAmount = 1 - (currentTurnTime / maxTimePerTurn);
//        seconds.text = Mathf.RoundToInt(maxTimePerTurn - currentTurnTime).ToString();
//    }
//}









//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class ActivePlayer : MonoBehaviour
//{
//    private ActivePlayerManager manager;

//    public void AssignManager(ActivePlayerManager theManager)
//    {
//        manager = theManager;
//    }

//    public void FireProjectile()
//    {
//        SetRandomColor();
//        manager.ChangeTurn();
//    }

//    public void SetRandomColor()
//    {
//        GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);
//    }
//}












//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class ActivePlayerInput : MonoBehaviour
//{
//    [SerializeField] private ActivePlayerManager manager;
//    [SerializeField] private float rotationSpeed;
//    [SerializeField] private float walkingSpeed;

//    void Update()
//    {
//        if (manager.PlayerCanPlay())
//        {
//            if (Input.GetAxis("Horizontal") != 0)
//            {
//                ActivePlayer currentPlayer = manager.GetCurrentPlayer();
//                currentPlayer.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), Space.World);
//            }

//            if (Input.GetAxis("Vertical") != 0)
//            {
//                ActivePlayer currentPlayer = manager.GetCurrentPlayer();
//                currentPlayer.transform.Translate(currentPlayer.transform.forward * walkingSpeed * Time.deltaTime * Input.GetAxis("Vertical"), Space.World);
//            }

//            if (Input.GetKeyDown(KeyCode.X))
//            {
//                ActivePlayer currentPlayer = manager.GetCurrentPlayer();
//                currentPlayer.GetComponent<ActivePlayerWeapon>().ShootLaser();
//            }
//        }
//    }
//}
