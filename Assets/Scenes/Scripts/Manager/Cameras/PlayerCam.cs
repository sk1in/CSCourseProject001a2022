//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class PlayerCam : MonoBehaviour
//{
//    public Camera[] cameras;
//    // Start is called before the first frame update
//    void Start()
//    {
        
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (Input.GetKeyDown(KeyCode.C))
//        {
//            currentCameraIndex++;
//            Debug.Log("C button has been pressed. Switching to the next camera");
//            if (currentCameraIndex < cameras.Length)
//            {
//                cameras[currentCameraIndex - 1].gameObject.SetActive(false);
//                cameras[currentCameraIndex].gameObject.SetActive(true);
//                Debug.Log("Camera with name: " + cameras[currentCameraIndex].gameObject + ", is now enabled");
//            }
//            else
//            {
//                cameras[currentCameraIndex - 1].gameObject.SetActive(false);
//                currentCameraIndex = 0;
//                cameras[currentCameraIndex].gameObject.SetActive(true);
//                Debug.Log("Camera with name: " + cameras[currentCameraIndex].gameObject + ", is now enabled");
//            }
//        }

//    }
//}
