using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform oyuncu;
    public float takipHizi = 5f;

    void Update()
    {
        if (oyuncu != null)
        {
            TakipEt();
        }
    }

    void TakipEt()
    {
        
        Vector3 hedefKonum = oyuncu.position;

        
        hedefKonum.z = transform.position.z;

        
        transform.position = Vector3.Lerp(transform.position, hedefKonum, takipHizi * Time.deltaTime);
    }
}