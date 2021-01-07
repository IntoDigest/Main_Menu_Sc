// ใส่ใน Boss
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deduct : MonoBehaviour
{  
    public int MxHealth;
    public static int boss_hp; //ไม่ต้องสนใจ
    void Update(){
        if(boss_hp <= 0){
            //GameOver
        }
    }
}