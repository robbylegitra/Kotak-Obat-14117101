using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Controller : MonoBehaviour
{
    
    public string scene;

    public void LoadScene()
    {
        SceneManager.LoadScene(scene);
    }


}
