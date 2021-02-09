using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quest_Mark : MonoBehaviour
{
  public GameObject name;
  private bool Mark = false;
  void Update(){
  if(!Mark){
    Mark = true;
  }
  name.SetActive(Mark);
  }
}
