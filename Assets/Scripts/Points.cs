using UnityEngine;

public class Points : MonoBehaviour
{
    public int infoValue;
    private InfoStoragePlaer playerInfo;

    private void Start()
    {
        playerInfo = FindObjectOfType<InfoStoragePlaer>();
    }


    public void AddScore()
    {
        if (playerInfo != null)
        {
            playerInfo.AddPoints(infoValue);
        }
        else
        {
            Debug.LogWarning("No se encontró InfoStoragePlaer en la escena");
        }
    }

}
