using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldCam : MonoBehaviour
{
    //[SerializeField] private TurnManager manager;
    [SerializeField] private Vector3 distanceFromThePlayer;
    [SerializeField] private float speed;
    //[SerializeField] private float speedH = 2.0f;
    //[SerializeField] private float speedV = 2.0f;
    //private float yaw = 0.0f;
    //private float pitch = 0.0f;
    //[SerializeField] private float pitchClamp = 90;


    //public Transform camTarget;


    //public float pLerp = .01f;
    //public float rLerp = .02f;


    void Update()
    {
        //Vector3 targetPosition = manager.GetCurrentPlayer().transform.position + distanceFromThePlayer;
        //Debug.Log("showingThis : " + TurnManager.ActiveObject());
        //Debug.Log("showingThis : " + GameObject.Find(TurnManager.ActiveObject()).transform.position + distanceFromThePlayer);
        Vector3 targetPosition = GameObject.Find(TurnManager.ActiveObject()).transform.position + distanceFromThePlayer;
        //Debug.Log("showingThis " + targetPosition);

        //transform.rotation = Quaternion.Euler(GameObject.Find(TurnManager.ActiveObject()).transform.position);


        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);
        //transform.rotation = Quaternion.Lerp(transform.rotation, camTarget.rotation, rLerp);
        //transform.forward = GameObject.Find(TurnManager.ActiveObject()).transform.forward ;w

        //ReadRotationInput();
    }

    //private void ReadRotationInput()
    //{
    //    yaw += speedH * Input.GetAxis("Mouse X");
    //    pitch -= speedV * Input.GetAxis("Mouse Y");
    //    pitch = Mathf.Clamp(pitch, -pitchClamp, pitchClamp);

    //    transform.localEulerAngles = new Vector3(pitch, 0.0f, 0.0f);
    //    transform.eulerAngles = new Vector3(0.0f, yaw, 0.0f);
    //}


    //private void ReadRotationInput()
    //{
    //    yaw += speedH * Input.GetAxis("Mouse X");
    //    pitch -= speedV * Input.GetAxis("Mouse Y");
    //    pitch = Mathf.Clamp(pitch, -pitchClamp, pitchClamp);

    //    transform.localEulerAngles = new Vector3(pitch, 0.0f, 0.0f);
    //    transform.eulerAngles = new Vector3(0.0f, yaw, 0.0f);
    //}

}














//public class WorldCam : MonoBehaviour
//{
//    //Assign this Camera in the Inspector
//    public Camera m_OrthographicCamera;
//    //These are the positions and dimensions of the Camera view in the Game view
//    float m_ViewPositionX, m_ViewPositionY, m_ViewWidth, m_ViewHeight;

//    [SerializeField] private float speedH = 2.0f;
//    [SerializeField] private float speedV = 2.0f;

//    private float yaw = 0.0f;
//    private float pitch = 0.0f;

//    [SerializeField] private float pitchClamp = 10;
//    Vector3 pos = new Vector3(200, 200, 0);


//    [SerializeField] private TurnManager manager;
//    [SerializeField] private Vector3 distanceFromThePlayer;
//    [SerializeField] private float speed;



//    private void Start()
//    {
//        //m_ViewPositionX = 0;
//        //m_ViewPositionY = 0;

//        //m_OrthographicCamera = GetComponent<Camera>();
//    }
//    void Update()
//    {
//        //This sets the Camera view rectangle to be in the bottom corner of the screen


//        //This sets the Camera view rectangle to be smaller so you can compare the orthographic view of this Camera with the perspective view of the Main Camera
//        //m_ViewWidth = 1f;
//        //m_ViewHeight = 1f;

//        ////This enables the Camera (the one that is orthographic)
//        //m_OrthographicCamera.enabled = true;

//        ////If the Camera exists in the inspector, enable orthographic mode and change the size
//        //if (m_OrthographicCamera)
//        //{
//        //    //This enables the orthographic mode
//        //    m_OrthographicCamera.orthographic = true;
//        //    //Set the size of the viewing volume you'd like the orthographic Camera to pick up (5)
//        //    m_OrthographicCamera.orthographicSize = 5.0f;
//        //    //Set the orthographic Camera Viewport size and position
//        //    m_OrthographicCamera.rect = new Rect(m_ViewPositionX, m_ViewPositionY, m_ViewWidth, m_ViewHeight);
//        //}

//        //ReadRotationInput();

//        //Ray ray = m_OrthographicCamera.ScreenPointToRay(pos);
//        //Debug.DrawRay(ray.origin, ray.direction * 10, Color.yellow);



//        Vector3 targetPosition = manager.gameObject.transform.position + distanceFromThePlayer;

//        float step = speed * Time.deltaTime;
//        transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);


//    }

//    private void ReadRotationInput()
//    {
//        yaw += speedH * Input.GetAxis("Mouse X");
//        pitch -= speedV * Input.GetAxis("Mouse Y");
//        pitch = Mathf.Clamp(pitch, -pitchClamp, pitchClamp);

//        m_OrthographicCamera.transform.localEulerAngles = new Vector3(pitch, 0.0f, 0.0f);
//        transform.eulerAngles = new Vector3(0.0f, yaw, 0.0f);
//    }

//}
