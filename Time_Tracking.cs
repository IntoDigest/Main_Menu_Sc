using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Time_Tracking : MonoBehaviour
{
    public int time_to_destroy ;
    void Start() 
    {
        StartCoroutine(wait_spawn());
    }

    IEnumerator wait_spawn(){
        while(true){
            yield return new WaitForSeconds(time_to_destroy);

            Destroy(gameobject);
        }
    }
}
