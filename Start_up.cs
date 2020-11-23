using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change_Scene : MonoBehaviour
{
  public GameObject name;
  void OnCollisionEnter(Collision other){
    name.activeSelf(true);
 }
}
