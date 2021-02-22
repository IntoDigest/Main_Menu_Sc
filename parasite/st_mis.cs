using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class st_mis : MonoBehaviour
{
	public GameObject q;
	void Start()
	{
		q.SetActive(false);
	}
	void OnCollisionEnter(Collision other){
		q.SetActive(true);
	}
}
