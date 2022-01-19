using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowPlayer : MonoBehaviour
{
    public GameObject player;
    public AudioSource crows;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player)
        {
            crows.Play();
            Debug.Log("yess");
        }
    }
}
