using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BroomBite : MonoBehaviour
{

    public GameObject mouthPos;
    public bool inMouth;
    
    private Rigidbody _rb;
    private AudioSource _audioSource;
    
    
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.constraints = RigidbodyConstraints.FreezeAll;

        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inMouth == true)
        {
            this.gameObject.transform.position = mouthPos.transform.position;
            gameObject.transform.rotation = mouthPos.transform.rotation;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            _rb.constraints = RigidbodyConstraints.None;

            inMouth = true;
            
            _audioSource.Play();
        }
    }
}
