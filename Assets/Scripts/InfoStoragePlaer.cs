using UnityEngine;

public class InfoStoragePlaer : MonoBehaviour
{
    public int totalPoints = 0;

    public void AddPoints(int pointsToAdd)
    {
        totalPoints += pointsToAdd;
        Debug.Log("Hay " +  totalPoints + "puntos");
    }




}
