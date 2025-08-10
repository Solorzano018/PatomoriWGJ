using UnityEngine;

[CreateAssetMenu(fileName = "NuevoObjeto", menuName = "Datos/DialogData")]

public class DialogDataNoOpt : ScriptableObject
{

    public string[] context;

    public string[] conversationA;
    public string[] conversationB;
}
