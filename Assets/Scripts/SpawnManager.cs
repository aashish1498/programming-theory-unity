using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] targets;

    private float spawnInterval = 1.5f;
    private float spawnDelay = 1.0f;

    private float yLimit = 2.5f;
    private float xPos = -15;
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
        var position = new Vector3(xPos, Random.Range(-1 * yLimit, yLimit), target.transform.position.z);
        Instantiate(target, position, target.transform.rotation);
    }
}
