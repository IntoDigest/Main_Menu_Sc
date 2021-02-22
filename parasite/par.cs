using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class par : MonoBehaviour
{
	public string st;
	public GameObject answer,wrong;
	void Start()
	{
		wrong.SetActive(false);
	}

	void OnCollisionEnter(Collision other)	
	{
		if(other.gameObject == answer){
			SceneManager.LoadScene(st);	
		}	
		else{
			//SceneManager.LoadScene(Reload);
			wrong.SetActive(true);			
			yield WaitForSeconds(3);
			wrong.SetActive(false);	
		}
	}
}
