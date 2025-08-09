using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonScene : MonoBehaviour
{
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


}
