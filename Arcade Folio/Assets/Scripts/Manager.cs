using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour {

    public string currentScn;

    void Awake()
    {
        DontDestroyOnLoad(this);
        currentScn = SceneManager.GetActiveScene().name;
    }
	
}
