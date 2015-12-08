using UnityEngine;
using System.Collections;

public class CarSpawner : MonoBehaviour
{
    public GameObject Car;

	// Use this for initialization
	void Start ()
	{
	    StartCoroutine(Spawn());
	}

    private IEnumerator Spawn()
    {
        for (;;)
        {
            Instantiate(Car, transform.position, transform.rotation);
            yield return new WaitForSeconds(Random.value * 5 + 1);
        }
    }

    // Update is called once per frame
	void Update () {
	
	}
}
