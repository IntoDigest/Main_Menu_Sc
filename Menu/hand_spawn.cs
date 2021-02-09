using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Valve.VR;

public class hand_spawn : MonoBehaviour
{
    public GameObject Bullet;
    public GameObject emp_;
    public SteamVR_Input_Source Hand_Type;
    public SteamVR_Action_Boolean Finger;
    void Update(){
        if(Finger.GetLastState(Hand_Type)){
            Instantiate(Bullet,emp_.transform.position);
        }
    }
}
