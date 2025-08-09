using Coffee.UIEffects;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class BotonScene : MonoBehaviour
{
    public void OnButtonPressed()
    {
        ChangeScene controller = FindObjectOfType<ChangeScene>();
        if (controller != null)
        {
            controller.LoadNextScene();
        }
        else
        {
            Debug.LogWarning("No se encontró un SceneController en la escena.");
        }
    }

   



    /*
    public int numScene;
    public ChangeScene changeScene;


    public void LoadScene()
    {

        SceneManager.LoadScene(numScene);
        /*
        ChangeScene controller = FindObjectOfType<ChangeScene>();
        if (controller != null)
        {
            controller.LoadSceneWithFade(numScene);
        }
        else
        {
            Debug.LogWarning("SceneController no encontrado en la escena.");
        }
        */
}


