using UnityEngine;

[CreateAssetMenu(fileName = "NuevoObjeto", menuName = "Datos/DialogData")]

public class DialogData : ScriptableObject
{
    
    public string[] context;
    
    public string optA;
    public int scoreA;
    
    public string optB;
    public int scoreB;
    public string[] conversationA;
    public string[] conversationB;
}
