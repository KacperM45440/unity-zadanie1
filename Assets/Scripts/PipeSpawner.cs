using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float repeatRate = 1;
    private float timer = 0;
    public float height = 5;
    public GameObject prefabPipe;
    public Sprite greenSprite;
    public Sprite redSprite;
    int i;

    // Update is called once per frame
    void Update()
    {
        if (timer > repeatRate)
        {
            timer = 0;
            SpawnPipe();
        }

        timer += Time.deltaTime;
    }

    private void SpawnPipe()
    {
        GameObject newPipe = Instantiate(prefabPipe);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);

        i = Random.Range(1, 3);

        if (i.Equals(1))
        {
            newPipe.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = greenSprite;
            newPipe.transform.GetChild(1).GetComponent<SpriteRenderer>().sprite = greenSprite;
        }
        else
        {
            newPipe.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = redSprite;
            newPipe.transform.GetChild(1).GetComponent<SpriteRenderer>().sprite = redSprite;
        }

        Destroy(newPipe, 10f);
    }
}
