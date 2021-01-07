// ใส่ใน Bullet
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deduct : MonoBehaviour
{  
    public GameObject Boss;
    void OnCollisionEnter(Collision other) {
        if(other.gameObject == Boss){
            
            boss.boss_hp -= 1;
        }   
        Destroy(gameobject); 
    }
}