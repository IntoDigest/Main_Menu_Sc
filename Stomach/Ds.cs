// ใส่ในกระสุน [Prefab]
// ทำลาย Bacteria
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ds : MonoBehaviour
{
    public GameObject Part;
    void OnCollisionEnter(Collision other){
        if(other.gameObject.tag == "Bac"){
            Vector3 pos = other.gameObejct.transform.position;
            Destroy(other.gameObject);
            Bac.Count -= 1;
            Instantiate(Part,pos,Quaternion.identity);
        }
        
    }
}