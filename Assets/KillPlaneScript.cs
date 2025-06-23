using UnityEngine;

public class KillPlaneScript : MonoBehaviour
{
    public PlayerScript player;
    public StageScript stage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GetComponent<PlayerScript>();
        stage = GetComponent<StageScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name.ToString());
        if (collision.CompareTag("Ball"))
        {
            Destroy(collision.gameObject);
            Debug.Log("The ball was destroyed!");
            player.RemoveLives(1);
        }
    }
}
