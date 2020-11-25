using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Quit : MonoBehaviour
{
    public Button ExitButton;
    void Start()
    {
        Button x = ExitButton.GetComponent<Button>();
        x.onClick.AddListener(Task);
    }
    void Task()
    {
        Debug.Log("Exit!~~~~");
        Application.Quit();
    }
}
