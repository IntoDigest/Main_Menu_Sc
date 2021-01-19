  
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
    
    public List<GameObject> health_items;
    void Start(){
        SetHealth(MaxHealth);
    }
    void OnCollisionEnter(Collision other){
        if(other.gameObject.tag == "Bullet"){
            Destroy(other.gameObject);
            health -= damage;
            remove_(health);
        }
    }

    void SetHealth(int MaxHealth){
        health = MaxHealth;
        gameObject.transform.position = new Vector3(x,y,z);
        create();
    }

    void remove_(int it){
        health_items[it].SetActive(false);
    }
    void create(){
        int naz = 8;
        for(int i=0;i<naz;++i){
            health_items[i].SetActive(true);
        }

    }
}
