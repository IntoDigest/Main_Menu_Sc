using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class hand_spawn : MonoBehaviour
{
  public GameObject Bullet;
  public GameObject emp_hand;
  public SteamVR_Input_Source Hand_Type;
  public SteamVR_Action_Boolean Finger;
  void Update(){
    if(Finger.GetlastState(Hand_Type){
      Instantiate(Bullet,emp_hand.transform.position);
    }
  }
}
