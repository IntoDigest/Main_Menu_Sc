/*
 * ใส่ใน OBJ ที่ใช้เป็นกุญแจ
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class key : MonoBehaviour
{
    public GameObject keyhole;
    void OnCollisionEnter(Collision other) {
        if(other.gameObject == keyhole){
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
