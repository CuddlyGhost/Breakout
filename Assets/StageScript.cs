using UnityEngine;

public class StageScript : MonoBehaviour
{

    public GameObject block;
    public GameObject ball;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // Spawning Blocks
        for (int i = 0; i < 8; i++)
        {
            for (int y = 0; y < 8; y++)
            {
                SpawnEntity(block,new Vector2(-7.4f + (i*2.125f), 4.3f - (y*0.6f)));
                Debug.Log("Spawned block!");
            }
        }

        // Spawn ball

        SpawnEntity(ball, new Vector2(0f, -2f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEntity(GameObject entity, Vector2 position)
    {
        Instantiate(entity, position, Quaternion.identity);
    }
}
