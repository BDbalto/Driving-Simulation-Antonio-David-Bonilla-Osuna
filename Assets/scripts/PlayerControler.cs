using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // el coche se mueve hacia delante
        transform.Translate(40 * Time.deltaTime * Vector3.forward);
    }
}
