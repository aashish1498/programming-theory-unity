using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] targets;

    private float spawnInterval = 1.5f;
    private float spawnDelay = 1.0f;

    private float yLimit = 3.0f;
    private float xPos = -15;
    private float zpos = -0.5f;
    void Start()
    {
        InvokeRepeating(nameof(SpawnRandomTarget), spawnDelay, spawnInterval);
    }

    void Update()
    {
        
    }

    private void SpawnRandomTarget()
    {
        int index = Random.Range(0, targets.Length);
        var target = targets[index];
        var position = new Vector3(xPos, Random.Range(-1 * yLimit, yLimit), zpos);
        Instantiate(target, position, target.transform.rotation);
    }
}
