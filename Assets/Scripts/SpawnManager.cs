using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject obstaclePrefab;
   

    void Start()
    {
        InvokeRepeating(nameof(Spawn), 0f, 2f);
    }

    void Spawn()
    {
          
        GameObject playerGo = GameObject.Find("Player");
        PlayerController player = playerGo.GetComponent<PlayerController>();
        if (player.isGameOver == true)
        {
            return;
        }

        Instantiate(
            obstaclePrefab,
            spawnPoint.position,
            obstaclePrefab.transform.rotation
        );
    }
}
