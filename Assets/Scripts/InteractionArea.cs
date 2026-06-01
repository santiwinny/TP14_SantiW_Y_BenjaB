using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col){
        
        if(col.gameObject.CompareTag("Coleccionable")){
            Debug.Log("Hubo colision con Coleccionable");
            Destroy(col.gameObject);
        }
   }
}
