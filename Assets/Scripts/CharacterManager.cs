using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public SelectedCharacterPanel selectedCharacterPanel;

    private CharacterSlot currentlySelectedSlot;

    public void SelectCharacter(CharacterSlot newSlot)
    {
        // Re-enable previously selected slot
        if (currentlySelectedSlot != null && currentlySelectedSlot != newSlot)
        {
            currentlySelectedSlot.gameObject.SetActive(true);
        }

        // Update selected character panel
        selectedCharacterPanel.DisplayCharacter(newSlot.characterData);

        // Disable the new one
        newSlot.gameObject.SetActive(false);
        currentlySelectedSlot = newSlot;
    }

    public void DeselectCharacter()
    {
        if (currentlySelectedSlot != null)
        {
            currentlySelectedSlot.gameObject.SetActive(true);
            currentlySelectedSlot = null;
        }

        selectedCharacterPanel.gameObject.SetActive(false);
    }
}
