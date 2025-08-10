using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using TMPro;


public class ChangeScene : MonoBehaviour
{
    LoadingScreen fadeout;
    public void LoadNextScene()
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        int totalScenes = SceneManager.sceneCountInBuildSettings;
        int nextIndex = currentIndex + 1;

        if (nextIndex < totalScenes)
        {
            SceneManager.LoadScene(nextIndex);
        }
        else
        {
            Debug.Log("No hay más escenas para cargar.");
        }
        
       
    }

    /*
    public FadeOut fadeOut;
    private static SceneController instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    public void LoadSceneWithFade(int sceneIndex)
    {
        StartCoroutine(LoadSceneRoutine(sceneIndex));
    }

    private IEnumerator LoadSceneRoutine(int sceneIndex)
    {
        // Setear el texto del día ANTES de cambiar de escena
        int day = Mathf.Clamp(sceneIndex, 1, 99);
        fadeController.SetDayText("Día " + day);

        // Cargar la escena inmediatamente
        AsyncOperation op = SceneManager.LoadSceneAsync(sceneIndex);
        while (!op.isDone)
            yield return null;

        // Esperar un momento por seguridad
        yield return new WaitForSeconds(0.2f);

        // Iniciar el fade out
        fadeController.StartFadeOut();
    }
    /*
    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void ChangeScenes(int numScene)
    {
        StartCoroutine(FadeAndLoad(numScene));
    }
    */

}
