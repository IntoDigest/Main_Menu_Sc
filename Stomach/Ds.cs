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
            Destroy(other.gameObject);
            Instantiate(Part);
            Bac.Count -= 1;
        }
    }
}
