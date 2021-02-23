using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wrong_answer : MonoBehaviour
{
    public GameObject Wrong_msg ;
    void Start(){
        //gameObject.SetActive(false);
    }
    void OnCollisionEnter(Collision other) {
        Wrong_msg.SetActive(true);

        new WaitForSeconds(3);

        Wrong_msg.SetActive(false);
    }
}