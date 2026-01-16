using UnityEngine;

public class LevelChangeScript : MonoBehaviour
{
    public GameObject level01;
   

    private GameObject currentLevel;
    private LevelChangeScript levelChangeScript;
    public void changeLevel(GameObject level)
    {
        currentLevel.SetActive(false);
        level.SetActive(true);
        currentLevel = level;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentLevel = level01;
        levelChangeScript = FindAnyObjectByType<LevelChangeScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
