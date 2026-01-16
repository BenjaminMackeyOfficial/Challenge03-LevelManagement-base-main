using UnityEngine;

public class LevelChangeTrigger : MonoBehaviour
{
   
   public GameObject level01;
   public GameObject level02;
   public LevelChangeScript levelChangeScript;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            levelChangeScript = FindAnyObjectByType<LevelChangeScript>();
            levelChangeScript.changeLevel(level02);
        }
    }

    

    void Start()
    {
      levelChangeScript = ServiceHub.Instance.levelManager;  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
