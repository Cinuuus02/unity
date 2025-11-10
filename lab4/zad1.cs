using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomCubesGenerator : MonoBehaviour
{
    List<Vector3> positions = new List<Vector3>();
    public float delay = 3.0f;
    int objectCounter = 0;

    public GameObject block;
    public int numberOfObjectsToGenerate = 10;
    public Material[] materials;

    void Start()
    {
        Collider koliderPlatformy = GetComponent<Collider>();
        if (koliderPlatformy == null)
        {
            return;
        }
        Bounds granice = koliderPlatformy.bounds;

        float minX = granice.min.x;
        float maxX = granice.max.x;
        float minZ = granice.min.z;
        float maxZ = granice.max.z;

        float wysokoscGenerowania = 5f;

        for (int i = 0; i < numberOfObjectsToGenerate; i++)
        {
            float losowyX = Random.Range(minX, maxX);
            float losowyZ = Random.Range(minZ, maxZ);

            this.positions.Add(new Vector3(losowyX, wysokoscGenerowania, losowyZ));
        }

        StartCoroutine(GenerujObiekt());
    }

    void Update()
    {

    }

    IEnumerator GenerujObiekt()
    {
        foreach (Vector3 pozycja in positions)
        {
            GameObject nowyBlok = Instantiate(this.block, pozycja, Quaternion.identity);

            if (materials.Length > 0)
            {
                int losowyIndeks = Random.Range(0, materials.Length);

                Renderer renderer = nowyBlok.GetComponent<Renderer>();
                if (renderer != null)
                {
                    renderer.material = materials[losowyIndeks];
                }
            }

            yield return new WaitForSeconds(this.delay);
        }
        StopCoroutine(GenerujObiekt());
    }
}