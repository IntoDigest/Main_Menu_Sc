using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_up : MonoBehaviour
{
  public GameObject Start_Menu;
  void Start(){
    Start_Menu.SetActive(false);
  }
  void OnCollisionEnter(Collision other){
    Start_Menu.SetActive(true);
 }
}
