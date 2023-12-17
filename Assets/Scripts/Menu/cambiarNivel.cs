using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambiarNivel : MonoBehaviour
{
    public void CambiarEscena(string nombre) {
        if(nombre == "Level1")
        {
            Debug.Log("hola");
            var audio = FindObjectOfType<AudioManager>();
            Destroy(audio);
        }
        SceneManager.LoadScene(nombre);
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
    }
    /*
    public void Volver()
    {
        SceneManager.LoadScene("Menu");
    }
    */
}
