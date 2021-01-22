using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;

public class UI_3 : MonoBehaviour
{
    public SteamVR_Input_Source hand_t;
    public SteamVR_Action_Boolean Finger;
    public static bool mk_3 = false;

    void Start(){
        SetActive(false);
    }
    void Update(){
        if(UI_2.mk_2 == true && mk_3 == false){
            SetActive(true);
        }
        if(Finger.GetLastState(hand_t)){
            SetActive(false);
            mk_3 = true;
        }
    }
}