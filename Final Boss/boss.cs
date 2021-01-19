// ใส่ใน Boss
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class boss : MonoBehaviour
{
    public int MxHealth;
    public static int boss_hp; //ไม่ต้องสนใจ
    public string next;
    void Start(){
        boss_hp = MxHealth;
    }

    void Update()
    {
        if (boss_hp <= 0)
        {
            SceneManager.LoadScene(next);
        }
    }
}
