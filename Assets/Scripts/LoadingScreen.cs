using System;
using System.Collections;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScreen : MonoBehaviour
{
    public Image fadeImage;
    public TextMeshProUGUI dayText;
    public float fadeTime;

    public void Black()
    {
        fadeImage.gameObject.SetActive(true);
        fadeImage.color = Color.black;
    }
    public void FadeIn(int dayNumber)
    {
        dayText.color = new Color(dayText.color.r, dayText.color.g, dayText.color.b, 1);
        dayText.text = "Day " + dayNumber;
        StartCoroutine(FadeOutAct());
    }

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
    }
}
