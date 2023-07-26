using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUp : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private float _velocidade = 3.5f;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * _velocidade *Time.deltaTime);

    }
}
