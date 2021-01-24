// ใส่ใน อะไรก็ได้ที่อยู่ตลอด
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bac : MonoBehaviour
{
    public static int Count;
    public string cutscene;
    void Start(){
        Count = 6;
    }
    void Update(){
        if(Count == 0){
            SceneManager.LoadScene(cutscene);
        }
    }
}
