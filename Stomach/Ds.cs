// ใส่ในกระสุน [Prefab]
// ทำลาย Bacteria
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ds : MonoBehaviour
{
    OnCollisionEnter(Collision other){
        if(other.gameObject.tag == "Bac"){
            Destroy(other.gameObject);
            Bac.Count -= 1;
        }
    }
}