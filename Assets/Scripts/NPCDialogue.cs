using UnityEngine;

[CreateAssetMenu(fileName ="NewNPCDialogue", menuName ="NPC Dialogue")]
public class BoxDialogue : ScriptableObject
{
    public string npcName;
    public string[] dialogueLines;
    public float typingSpeed = 0.05f;
    public float voicepitch = 1f;
    public bool[] autoProgressLines;
    public float autoProgressDelay = 1.5f;

}
