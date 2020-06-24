using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManMove : MonoBehaviour
{
    public float speed = 2.0f;
    public Transform goal;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = goal.position - this.transform.position;
        //DrawRay(this.transform.position, direction, Color.red);
        if (direction.magnitude > 0.01f)
            this.transform.Translate(direction.normalized * speed * Time.deltaTime);

        
    }
}
