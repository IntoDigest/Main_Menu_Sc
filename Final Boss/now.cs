using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Move_to_player : MonoBehaviour
{
    publci GameObject player_ ;
    
    static public Vector3 player;
    void Update(){
      player = player_.transform.position
    }
}
