using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterSlot : MonoBehaviour
{
    public CharacterManager selectionManager; // Reference to the CharacterManager
    [Header("Character Data")]
    public Character characterData; // Drag your ScriptableObject here in the Inspector

    [Header("UI References")]
    public Image portrait;
    public TMP_Text nameText;
    public TMP_Text descriptionText;
    public TMP_Text strengthText;
    public TMP_Text intelligenceText;
    public TMP_Text staminaText;
    public TMP_Text vitalityText;
    public Button selectButton;

    [Header("Reference to the selected character panel")]
    public SelectedCharacterPanel selectedCharacterPanel;

    private void Start()
    {
        if (characterData == null)
        {
            Debug.LogError($"{gameObject.name} has no Character ScriptableObject assigned.");
            return;
        }

        ApplyData();
        selectButton.onClick.AddListener(SelectCharacter);
    }

    void ApplyData()
    {
        portrait.sprite = characterData.portrait;
        nameText.text = characterData.characterName;
        descriptionText.text = characterData.description;
        strengthText.text = $"STR: {characterData.strength}";
        intelligenceText.text = $"INT: {characterData.intelligence}";
        staminaText.text = $"STA: {characterData.stamina}";
        vitalityText.text = $"VIT: {characterData.vitality}";
    }

    void SelectCharacter()
    {
        Debug.Log($"Selected Character: {characterData.characterName}");

        // Notify selected character panel
        if (selectedCharacterPanel != null && characterData != null)
        {
            selectionManager.SelectCharacter(this);
        }
    }

    private void OnDestroy()
    {
        selectButton.onClick.RemoveAllListeners();
    }
}
