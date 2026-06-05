using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{

    int contador = 0;
    UIManager uimgr;

    // Start is called before the first frame update
    void Start()
    {
        uimgr = GameObject.FindObjectOfType<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider col){
        
        if(col.gameObject.CompareTag("Coleccionable")){
            contador = contador + 1;
            Destroy(col.gameObject);
            uimgr.UpdateScore(contador);
        }
   }
}
