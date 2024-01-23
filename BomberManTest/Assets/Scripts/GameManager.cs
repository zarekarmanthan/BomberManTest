using UnityEngine;
using UnityEngine.Tilemaps;

public class GameManager : MonoBehaviour
{
    public Tilemap tilemap; 

    public Tile destructibleTile;

    public GameObject enemyPrefab;

   
    public int numberOfEnemies = 5;

    public bool changeEnemySpeed = false;
    public float newEnemySpeed = 0;

    void Start()
    {
        ///Randomly spawn destructible tiles and enemies

        System.Random rnd = new System.Random();
        SpawnEnemies(rnd);
    }

   

    void SpawnEnemies(System.Random rnd)
    {
        ///Spawn enemies at empty locations
        ///Optional: change speed of enemies

        int enemies = 0;
        while (enemies < numberOfEnemies)
        {
            int x = rnd.Next(-9, 12);
            int y = rnd.Next(-9, 2);
            if ((x != -9 && x != -8) || (y != 1 && y != 0))
            {
                Vector3Int pos = new Vector3Int(x, y, 0);
                if (tilemap.GetTile(pos) == null)
                {
                    Vector3 cellCenterPos = tilemap.GetCellCenterWorld(pos);
                    GameObject enemy = Instantiate(enemyPrefab, cellCenterPos, Quaternion.identity);
                    enemy.GetComponent<EnemyAI>().tilemap = tilemap;
                    if (changeEnemySpeed)
                    {
                        SetEnemySpeed(enemy);
                    }
                    enemies++;
                }
            }
        }
    }

    void SetEnemySpeed(GameObject enemy)
    {
        ///Change the actual enemy speed

        enemy.GetComponent<EnemyAI>().moveSpeed = newEnemySpeed;
    }

}
