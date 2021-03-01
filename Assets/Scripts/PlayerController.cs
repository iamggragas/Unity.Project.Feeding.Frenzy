using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectilePrefab;
    private float horizontalInput;
    private float Speed = 15.0f;
    private float xRange = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (transform.position.x < -xRange)
		{
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
		{
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * Speed * horizontalInput);

        if (Input.GetKeyDown(KeyCode.Space))
		{
            // Fire projectiles 
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
		}
    }
}
