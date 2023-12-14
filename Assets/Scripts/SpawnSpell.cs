using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpell : MonoBehaviour
{
    public GameObject spell;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Instantiate(spell, this.transform.position + this.transform.forward*2, this.transform.rotation);//Quaternion.identity);
        }
    }
}
