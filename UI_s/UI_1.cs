using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_1 : MonoBehaviour
{
    public GameOject hud;

    private bool mark = false;
    public static bool mk_1 = false;
    void Start(){
        SetActive(false);
    }
    void Update(){
        if(hud == null && mark == false){
            gameObject.SetActive(true);
            StartCouroutine(ws());
        }
    }
    
    IEnumerator ws(){
        while(true){
            yield return WaitForSeconds(2);
            
            gameObject.SetActive(false);
            mark = true;
            mk_1 = true;
            break;
        }
    }
}