using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_2 : MonoBehaviour
{
    public GameObject Player_;
    private Vector3 pos;
    public static bool mk_2 = false;
    void Start(){
        pos = Player_.transform.position;
        gameObject.SetActive(false);
    }
    void Update(){
        if(UI_1.mk_1 == true && mk_2 == false){
            gameObject.SetActive(true);
        }
        if(pos != Player_.transform.position){
            gameObject.SetActive(false);
            mk_2 = true;
        }
    }
}