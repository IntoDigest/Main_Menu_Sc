
// แทนที่ Gen_Obj.cs

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class new_projectile : MonoBehaviour
{
    public int Number_of_item;
    public List <GameObject> Items;
    public float x1;
    public float y1;
    public float z1;
    public float x2;
    public float y2;
    public float z2;
    public int waiting_time;
    // Start is called before the first frame update
    private bool cnt;
    void Start() 
    {
        cnt = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Start_Button.state == true && cnt == false){
            cnt = true;
            StartCoroutine(wait_spawn());
        }
    }
    IEnumerator wait_spawn(){
        while(true){
            yield return new WaitForSeconds(waiting_time);
            Instantiate(Items[Random.Range(0,Number_of_item)],new Vector3(Random.Range(x1,x2),Random.Range(y1,y2),Random.Range(z1,z2)),Quaternion.identity);
        }
    }
}