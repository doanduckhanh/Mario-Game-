using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NamDocChet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(NamBepBienMat());
    }

    IEnumerator NamBepBienMat()
    {
        yield return new WaitForSeconds(1.5f);
        Destroy(gameObject);
    }
}
