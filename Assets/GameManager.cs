using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour


{
    public List<GameObject> targets;
    // Start is called before the first frame update
    private float spawnRate = 1.0f;
    void Start() { StartCoroutine(SpawnTarget());; }
    
    IEnumerator SpawnTarget (){
        while (true) {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
