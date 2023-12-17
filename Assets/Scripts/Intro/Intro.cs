using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("MyFunction", 3);
    }
    
    void MyFunction()
    {
        SceneManager.LoadScene("Menu");
        Debug.Log("cambiar scene");
    }    
}
