using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using TMPro;


public class ChangeScene : MonoBehaviour
{
    public Image fadeImage;
    public TextMeshProUGUI dayText;
    public float fadeTime;

    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void ChangeScenes(int numScene)
    {
        StartCoroutine(FadeAndLoad(numScene));
    }

    private IEnumerator FadeAndLoad(int numScene)
    {
        fadeImage.gameObject.SetActive(true);
        dayText.gameObject.SetActive(true);

        int day = Mathf.Clamp(numScene, 1, 3);
        dayText.text = "Dia " + day;

        for (float t = 0; t < fadeTime; t += Time.deltaTime)
        {
            fadeImage.color = new Color(0,0,0, t / fadeTime);
            yield return null;
        }
        fadeImage.color = Color.black;

        yield return new WaitForSeconds(fadeTime);

        AsyncOperation op = SceneManager.LoadSceneAsync(numScene);
        while (!op.isDone)
            yield return null;

        for (float t = 0; t < fadeTime; t += Time.deltaTime)
        {
            fadeImage.color = new Color(0,0,0,1 - (t / fadeTime));
            yield return null;
        }
        fadeImage.color = new Color(0, 0, 0, 0);

        fadeImage.gameObject.SetActive(false);
        dayText.gameObject.SetActive(false);
    }
}
