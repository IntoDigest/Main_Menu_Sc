// ใส่ในกระสุน [Prefab]
// ทำลาย Bacteria
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ds : MonoBehaviour
{
    //void Start(){
    //    Part.SetActive(false);
    //}
    //public GameObject Part;
    void OnCollisionEnter(Collision other){
        if(other.gameObject.tag == "Bac"){
            Destroy(other.gameObject);
            //Part.SetActive(true);
            Ba.Ef = true;
            Bac.Count -= 1;
        }
    }
}
