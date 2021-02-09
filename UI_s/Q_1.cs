using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Q_1 : MonoBehaviour
{
    public GameObject want;
    public static bool owo = false;
    void onCollisionEnter(Collision other) {
        if(want == other.gameObject){
            owo = true;
        }
    }
}