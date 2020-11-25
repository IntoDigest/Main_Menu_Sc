using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SpawnItem : MonoBehaviour
{
    void SaveButton(){
        PlayerPrefs.SetString("name",SceneManager.GetActiveScene().name);
        Debug.Log(PlayerPrefs.GetString(name));
    }
}