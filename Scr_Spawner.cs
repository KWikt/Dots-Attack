using UnityEngine;

public class Scr_Spawner : MonoBehaviour
{

    public Scr_PlayerConfig playerConfig;
    public GameObject[] enemyPrefabs;
    private bool canSpawn = true;
    public RectTransform spawnPool;
    public GameObject SpawnerObj;
    public Scr_Score score;
    public Scr_WinOrLoose loose;

    private float firstStart;
    private int howManyChildren;
    
    public int HowManyChildren { get => howManyChildren; set => howManyChildren = value; }

    void Start()
    {
        firstStart = playerConfig.FirstStart;
       
    }

    private void Update()
    {
        HowManyChildren = getChildren(SpawnerObj);
        hardSpawn();
    }

    public void Spawner()
    {
        TooMany();
        if(Time.time > firstStart)
        {
            firstStart += playerConfig.SpawnRate;
            while (canSpawn)
            {
                print(firstStart);
                int whichType = SpawnerGroup();
                GameObject enemyType = enemyPrefabs[whichType];
                GameObject enemy = Instantiate(enemyType, SpawnPlace() + spawnPool.transform.position, Quaternion.identity);
                enemy.transform.parent = GameObject.Find("EnemySpawner").transform;
                canSpawn = false;
            }
        }
       
    }

    public Vector3 SpawnPlace()
    {
       Vector3 position = new Vector3(Random.Range(spawnPool.rect.xMin, spawnPool.rect.xMax), Random.Range(spawnPool.rect.yMin, spawnPool.rect.yMax), 0);

        if(GameObject.Find("Wall").transform.position == position && GameObject.Find("Enemy").transform.position == position && GameObject.Find("Player").transform.position == position)
        {
            SpawnPlace();
        }
        return position;
    }

    private void TooMany()
    {
        if (getChildren(SpawnerObj) < playerConfig.MaxEnemy)
        {
            canSpawn = true;
            
        }
        else if (getChildren(SpawnerObj) >= playerConfig.MaxEnemy)
        {
            canSpawn = false;
            Reset();
            loose.LooseGameScreen();
        }
    }

    private int getChildren(GameObject obj)
    {
        int count = 0;

        for (int i = 0; i < obj.transform.childCount; i++)
        {
            count++;
        }
        return count;
    }

    private int SpawnerGroup()
    {
        if(score.Points % 5 == 0 && score.Points >= 0)
        {
            if (!GameObject.Find("EnemyPrice(Clone)"))
            {
               
                return 1;

            }
            else
            {
                return 0;
            }
        }
        else
        {
            return 0;
        }
    }

    void hardSpawn()
    {
        if(score.Points < 15)
        {
            Spawner();
        }
        else
        {
            Spawner();
            Spawner();
        }
    }

    public void killEnemy()
    {
        for (var i = getChildren(SpawnerObj) - 1; i >= 0; i--)
        {
            GameObject child = SpawnerObj.transform.GetChild(i).gameObject;
            Destroy(child);
        }
    }

    public void Reset()
    {
        killEnemy();
        score.Reset();
        howManyChildren = 0;
        firstStart = playerConfig.FirstStart;
    }

}
