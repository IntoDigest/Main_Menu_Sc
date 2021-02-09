using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;

public class M_1 : MonoBehaviour
{
    public string nex;
    void Start(){
        gameObject.SetActive(false);
    }
    void Update(){
        if(Q_1.owo == true){
            gameObject.SetActive(false);
            StartCouroutine(ws());
        }
    }
    IEnumerator ws()
    {
        while (true)
        {
            yield return WaitForSeconds(2);
            Scenemanager.LoadScene(nex);
        }
    }
}