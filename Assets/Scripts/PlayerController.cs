using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //aracı ileri doğru hareket ettiriyoruz
        //transform.Translate(0,0,1); ////Her framede 1 metre ilerler
        //transform.Translate(Vector3.forward); //Her framede 1 metre ilerler (yukarıdaki ile aynı)
        //transform.Translate(Vector3.forward * Time.deltaTime); //Her saniyede 1 metre ilerler
        transform.Translate(Vector3.forward * Time.deltaTime * 20); //Her saniyede 20 metre ilerler
    }
}
