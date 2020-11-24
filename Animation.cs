using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Animation : MonoBehaviour
{
    //public List <GameObject> Items;

    // Start is called before the first frame update
    void Start() 
    {
        StartCoroutine(wait_spawn());
    }

    IEnumerator wait_spawn(){
        while(true){
            yield return new WaitForSeconds(5);
            SceneManager.LoadScene("Next_Scene");
        }
    }
}
