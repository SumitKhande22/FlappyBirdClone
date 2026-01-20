using UnityEngine;
using UnityEngine.UI;

public class LevelSelectUI: MonoBehaviour
{
    public Button[] levelButtons;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int unlockedLevels = PlayerPrefs.GetInt("levelUnlocked", 3);
        for (int i=0; i< levelButtons.Length; i++)
        {
           
                levelButtons[i].interactable = (i+1 <unlockedLevels);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
