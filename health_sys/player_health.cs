/*
 * ใส่ใน Player
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_health : MonoBehaviour
{
    public int damage; //ดาเมจของกระสุน
    public int MaxHealth;
    public int x,y,z; //จุดเริ่มต้นของ Player
    private int health;
    void Start(){
        SetHealth(MaxHealth);
    }
    void OnColliderEnter(Collsion other){
        if(other.gameObejct.tag == "Bullet"){
            Destroy(other.gameObject);
            health -= damage;
        }
    }

    void SetHealth(int MaxHealth){
        health = MaxHealth;
        gameObject.transform.position = new Vector3(x,y,z);
    }
}