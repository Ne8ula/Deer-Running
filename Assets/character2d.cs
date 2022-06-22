using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character2d : MonoBehaviour
{
    // Start is called before the first frame update
    public float MovementSpeed = 1;
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            transform.localScale = new Vector3(-1.410804f, 1.410804f, 1.410804f);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            transform.localScale = new Vector3(1.410804f, 1.410804f, 1.410804f);
        }
    }
}
