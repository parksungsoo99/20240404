using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exam05_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnCollisionEnter(Collision collision){
        Debug.Log(collision.gameObject.name); 

        if(collision.gameObject.name =="board_1"){
            Destroy(this.gameObject);
            Debug.Log("add 2");
        }
        
        if(collision.gameObject.name =="board_2"){
            Destroy(this.gameObject);
            Debug.Log("add 1");
        }
        
        if(collision.gameObject.name =="board_3"){
            Destroy(this.gameObject);
            Debug.Log("add 3");
        }
    }
}
