using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigator : MonoBehaviour {

    public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void OpenBox(GameObject box)
    {
        box.SetActive(true);
    }

    public void CloseBox(GameObject box)
    {
        box.SetActive(false);
    }
}
