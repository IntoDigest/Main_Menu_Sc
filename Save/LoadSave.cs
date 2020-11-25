using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SpawnItem : MonoBehaviour
{
    private string SceneToLoad;
    void Start(){
        SceneToLoad = PlayerPrefs.GetString("name");
        SceneManager.LoadScene(SceneToLoad);
    }
    public void ResetGame(){
        PlayerPrefs.DeleteKey("name");
    }
}