using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change_Scene : MonoBehaviour
{
  public GameObject name;
  void Start(){
    name.activeSelf(false);
  }
  void OnCollisionEnter(Collision other){
    name.activeSelf(true);
 }
}
