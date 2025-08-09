using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using TMPro;


public class FadeOut : MonoBehaviour
{

    public Image fadeImage;
    public TextMeshProUGUI dayText;
    public float fadeTime;


    private void Start()
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;

        fadeImage.color = new Color(0, 0, 0, 1);
        dayText.color = new Color(dayText.color.r, dayText.color.g, dayText.color.b, 1);
        dayText.text = "Day " + currentIndex;

        fadeImage.gameObject.SetActive(true);
        dayText.gameObject.SetActive(true);

        StartCoroutine(FadeOutAct());

    }
    /*
    public void Awake()
    {
        fadeImage.color = new Color(0, 0, 0, 1);
        dayText.color = new Color(dayText.color.r, dayText.color.g, dayText.color.b, 1);

        fadeImage.gameObject.SetActive(true);
        dayText.gameObject.SetActive(true);

       
    }
    public void SetDayText(string text)
    {
        //int day = Mathf.Clamp(currentIndex, 1, 3);
        dayText.text = "Dia " + currentIndex;
    }
    
    public void StartFadeOut()
    {
        StartCoroutine(FadeOutAct());
    }*/
    private IEnumerator FadeOutAct()
    {

        for (float t = 0; t < fadeTime; t += Time.deltaTime)
        {
            float alpha = 1 - (t / fadeTime);
            fadeImage.color = new Color(0, 0, 0, alpha);
            dayText.color = new Color(dayText.color.r, dayText.color.g, dayText.color.b, alpha);
            yield return null;
        }

        fadeImage.color = new Color(0, 0, 0, 0);
        dayText.color = new Color(dayText.color.r, dayText.color.g, dayText.color.b, 0);

        fadeImage.gameObject.SetActive(false);
        dayText.gameObject.SetActive(false);
    }

    /*
  fadeImage.gameObject.SetActive(true);
      dayText.gameObject.SetActive(true);

      for (float t = 0; t < fadeTime; t += Time.deltaTime)
      {
          float alpha = 1- (t/fadeTime);
          fadeImage.color = new Color(0, 0, 0, alpha);
          dayText.color = new Color(dayText.color.r, dayText.color.g, dayText.color.b,alpha);
          yield return null;
      }
      fadeImage.color = new Color(0, 0, 0, 0);

      yield return new WaitForSeconds(fadeTime);

      AsyncOperation op = SceneManager.LoadSceneAsync(actualScene);
      while (!op.isDone)
          yield return null;

      for (float t = 0; t < fadeTime; t += Time.deltaTime)
      {
          fadeImage.color = new Color(0, 0, 0, 1 - (t / fadeTime));
          yield return null;
      }
      fadeImage.color = new Color(0, 0, 0, 0);

      fadeImage.gameObject.SetActive(false);
      dayText.gameObject.SetActive(false);
      */

}
