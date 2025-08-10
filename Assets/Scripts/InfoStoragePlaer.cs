using UnityEngine;

public class InfoStoragePlaer : MonoBehaviour
{
    public int totalPoints = 0;

    public void AddPoints(int pointsToAdd)
    {
        totalPoints += pointsToAdd;
        totalPoints = Mathf.Max(totalPoints, 0);
        Debug.Log("Hay " +  totalPoints + "puntos");
    }




}
