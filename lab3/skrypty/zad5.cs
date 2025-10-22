using UnityEngine;
using System.Collections.Generic;

public class zad5 : MonoBehaviour
{
    public GameObject cubePrefab;
    static int planeSize = 10;
    public int cubesToSpawn = 10;

    public int halfPlane = planeSize / 2;
    public float halfCube = 0.5f;

    void Start()
    {
        HashSet<Vector2Int> usedPositions = new HashSet<Vector2Int>();

        for (int i = 0; i < cubesToSpawn; i++)
        {
            Vector2Int pos;
            do
            {
                int x = Random.Range(-(int)(halfPlane - halfCube), (int)(halfPlane - halfCube));
                int z = Random.Range(-(int)(halfPlane - halfCube), (int)(halfPlane - halfCube));
                pos = new Vector2Int(x, z);
            }
            while (usedPositions.Contains(pos));

            usedPositions.Add(pos);

            Vector3 spawnPosition = new Vector3(pos.x, 0.5f, pos.y);
            Instantiate(cubePrefab, spawnPosition, Quaternion.identity);
        }
    }
}
