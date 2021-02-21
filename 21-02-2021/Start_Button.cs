
// ใส่ที่ start button

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Button : MonoBehaviour
{
    public static bool state;
    void Start(){
        gameObject.SetActive(true);
        state = false;
    }

    void OnCollisionEnter(Collision other){
        state = true;
        gameObject.SetActive(false);
    }
}