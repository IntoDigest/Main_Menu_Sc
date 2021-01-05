using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Move_to_player : MonoBehaviour
{
    public GameObject player;

    public float speed;

    private Vector3 playerpos;
    private Vector3 objpos;
    void Start() {
        playerpos = now.player;
    }
    
    void Update(){
        //playerpos = now.playing;
        float real_speed = speed * Time.deltaTime;

        
        objpos = transform.position;

        transform.position = Vector3.MoveTowards(objpos, playerpos, real_speed);

    }
}
