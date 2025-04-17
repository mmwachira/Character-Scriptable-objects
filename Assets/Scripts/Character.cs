using UnityEngine;

[CreateAssetMenu(fileName = "NewCharacter", menuName = "Characters/Character")]
public class Character : ScriptableObject
{
    public string characterName;
    [TextArea] public string description;

    public int strength;
    public int intelligence;
    public int stamina;
    public int vitality;

    public Sprite portrait;
}
