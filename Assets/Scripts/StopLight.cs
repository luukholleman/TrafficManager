using UnityEngine;
using System.Collections;

public class StopLight : MonoBehaviour
{
    private bool _stop;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnMouseDown()
    {
        _stop = !_stop;

        if (_stop)
        {
            GetComponent<BoxCollider>().center = new Vector3(1, 0, 0);
        }
        else { GetComponent<BoxCollider>().center = new Vector3(-1, 0,0);}
        Debug.Log("test");
        //Destroy(GetComponent<BoxCollider>());
        //enabled = !GetComponent<BoxCollider>().enabled;
    }
}
