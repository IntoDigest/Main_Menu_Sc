using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using Valve.VR;

public class UI_3 : MonoBehaviour
{
    public static bool mk_3;
    void Start(){
        gameObject.SetActive(false);
    }

    void Update(){
        if(UI_2.mk_2 == true && mk_3 == false){
            gameObject.SetActive(true);
            StartCoroutine(wait_spawn());
        }
    }

    IEnumerator wait_spawn(){
        yield return new WaitForSenconds(3);

        gameObject.SetActive(false);
        mk_3 = true;
    }
}