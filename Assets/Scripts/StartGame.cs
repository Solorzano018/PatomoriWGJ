using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public int numScene;


    public void Jugar()
    {
        SceneManager.LoadScene(numScene);
    }

    public void Salir()
    {
        Debug.Log("Saliendo..");
        Application.Quit();
    }
}
