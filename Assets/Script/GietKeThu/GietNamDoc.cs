using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GietNamDoc : MonoBehaviour
{
    Vector2 ViTriChet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
     void Update()
    {
        ViTriChet = transform.localPosition;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player" && collision.contacts[0].normal.y < 0)
        {
            Destroy(gameObject);
            GameObject HinhBep = (GameObject)Instantiate(Resources.Load("Prefabs/NamDocBep"));
            HinhBep.transform.localPosition = ViTriChet;
        }
    }
}
