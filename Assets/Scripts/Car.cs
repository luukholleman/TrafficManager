using UnityEngine;
using System.Collections;

public class Car : MonoBehaviour
{

    private bool _stop = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        
        Debug.DrawRay(transform.position, fwd, Color.blue, 1);
        _stop = Physics.Raycast(transform.TransformPoint(new Vector3(-0.5f, 0, 0)), fwd, 3);

        //Debug.Log(_stop);

        if (!_stop)
	        GetComponent<Rigidbody>().MovePosition(transform.position + transform.TransformDirection(Vector3.forward) * 5 * Time.deltaTime);
	}
}
