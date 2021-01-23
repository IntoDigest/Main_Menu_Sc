using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;

public class UI_4 : MonoBehaviour
{
    private bool act = false;
    public GameObject obj;
    public int x,y,z;
    void Start(){
        gameObject.SetActive(false);
    }
    private Vector3 pos ;
    void Update(){
        if(UI3.mk_3 == true && act == true){
            gameObject.SetActive(true);
            act = true;
            Instantiate(obj,new Vector3(x,y,z),Quaternion.identity);
            pos = obj.transform.psoition;
        }
        if(pos!=obj.transform.position){
            gameObject.SetActive(false);
        }
    }
}