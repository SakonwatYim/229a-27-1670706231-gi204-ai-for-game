using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 10f;
    public PlayerController playerController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerController = FindAnyObjectByType<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {

        if (playerController.isGameOver)
        {
            speed = 0;
        }
        transform.Translate(speed * Vector3.left * Time.deltaTime);
    }
}
