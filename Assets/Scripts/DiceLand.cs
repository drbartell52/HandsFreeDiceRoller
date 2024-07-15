using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceLand : MonoBehaviour
{

    public AudioSource diceSound;

    public GameObject manQuad;
    public Material pushMat;
    public Material yayMat;

    private MeshRenderer _meshRenderer;
    
    // Start is called before the first frame update
    void Start()
    {
        _meshRenderer = manQuad.GetComponent<MeshRenderer>();
        _meshRenderer.material = pushMat;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Dice"))
        {
            _meshRenderer.material = yayMat;
            diceSound.Play();
        }
    }
}
