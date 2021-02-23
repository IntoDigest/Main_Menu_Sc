using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class correct_answer : MonoBehaviour
{
    public string nex;
    void Start()
    {
        //gameObject.SetActive(false);
    }
    void OnCollisionEnter(Collision other)
    {
        SceneManager.LoadScene(nex);
    }
}