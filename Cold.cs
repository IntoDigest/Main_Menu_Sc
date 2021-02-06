using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cold : MonoBehaviour
{
    public GameObject Ob;
    public string nextScene;
    void OnCollisionEnter(Collision other) {
        if(other.gameObject == Ob){
            SceneManager.LoadScene(nextScene);
        }
    }
}
