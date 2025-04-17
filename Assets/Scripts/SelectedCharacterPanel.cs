using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SelectedCharacterPanel : MonoBehaviour
{
    [Header("UI Elements")]
    public Image portrait;
    public TMP_Text nameText;
    public TMP_Text descriptionText;
    public TMP_Text strengthText;
    public TMP_Text intelligenceText;
    public TMP_Text staminaText;
    public TMP_Text vitalityText;

    public void DisplayCharacter(Character characterData)
    {
        if (characterData == null) return;

        portrait.sprite = characterData.portrait;
        nameText.text = characterData.characterName;
        descriptionText.text = characterData.description;
        strengthText.text = $"STR: {characterData.strength}";
        intelligenceText.text = $"INT: {characterData.intelligence}";
        staminaText.text = $"STA: {characterData.stamina}";
        vitalityText.text = $"VIT: {characterData.vitality}";

        gameObject.SetActive(true); // Show the selected panel
    }
}
