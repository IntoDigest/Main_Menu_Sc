using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_up : MonoBehaviour
{
  public GameObject name;
  void Start(){
    name.SetActive(false);
  }
  void OnCollisionEnter(Collision other){
    name.SetActive(true);
 }
}
