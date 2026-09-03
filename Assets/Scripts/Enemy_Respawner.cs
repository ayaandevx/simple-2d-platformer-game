using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private Transform[] respawnPoints;
    [SerializeField] private float Cooldown = 2f;
    [Space]
    [SerializeField] private float CooldownDecRate = .05f;
    [SerializeField] private float cooldownCap = .7f;
    private float timer;
    private Transform player;

    private void Awake()
    {
        player = FindAnyObjectByType<Player>().transform;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if(timer < 0)
        {
            timer = Cooldown;   
            CreateNewEnemy();

            Cooldown = Mathf.Max(cooldownCap, Cooldown - CooldownDecRate);
        }
    }

    private void CreateNewEnemy()
    {
        int respownPointIndex = Random.Range(0, respawnPoints.Length);
        Vector3 SpawnPoint = respawnPoints[respownPointIndex].position;
        GameObject newEnemy = Instantiate(enemyPrefab,SpawnPoint,Quaternion.identity);

   
        if (newEnemy.transform.position.x > player.transform.position.x)
            newEnemy.GetComponent<Enemy>().Flip();
        
    }
}
