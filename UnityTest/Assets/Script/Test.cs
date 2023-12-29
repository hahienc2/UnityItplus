using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public float speed = 0.01f;

    void Start()
    {
        this.GetComponent<SpriteRenderer>().color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("DOWN");
           // this.transform.position += new Vector3(0, -speed, 0)*Time.deltaTime;
            this.transform.Translate(new Vector3(0, -speed, 0) * Time.deltaTime);   
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.position += new Vector3(0, +speed, 0) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime;
        }

        if (Input.GetMouseButton(0))
        {
            Debug.Log("trai");
        }
        if (Input.GetMouseButton(1))
        {
            Debug.Log("phai");
        }
        if (Input.GetMouseButton(2))
        {
            Debug.Log("giua");

        }
        Input.GetMouseButtonDown(0);
        Input.GetMouseButtonUp(0);
        // Input.mousePosition. = Vector3.zero;
        Debug.Log(Input.mousePosition);
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pos.z = 0;
        this.transform.position = pos;

    }
}
