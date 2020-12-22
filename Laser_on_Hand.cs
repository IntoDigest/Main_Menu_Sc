using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Valve.VR;

public class Laser_on_Hand : MonoBehaviour
{
    public GameObject Laser;
    public SteamVR_Input_Source Hand_Type;
    public SteamVR_Action_Boolean Finger;
    void Start(){
        Laser.SetActive(false);
    }
    void Update(){
        if(Finger.GetLastState(Hand_Type)){
            Laser.SetActive(true);
        }
        else{
            Laser.SetActive(false);
        }
    }
}
