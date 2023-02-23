using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkScript : MonoBehaviour
{
    private Rigidbody2D r2d;
    private float TocDo = 0;
    private float VanToc = 4;
    private bool QuayPhai = true;
    private bool ChuyenHuong = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        DiChuyen();
    }
    void DiChuyen()
    {
        //Chon phim di chuyen cho Mario (Phim <- va -> hoac phim A va D)
        float PhimNhanPhaiTrai = Input.GetAxis("Horizontal");//Chi nhan phim A -1 0 1 D
        r2d.velocity = new Vector2(VanToc * PhimNhanPhaiTrai, r2d.velocity.y);
        TocDo = Mathf.Abs(VanToc * PhimNhanPhaiTrai);
        if (PhimNhanPhaiTrai > 0 && !QuayPhai) HuongMat();
        if (PhimNhanPhaiTrai < 0 && QuayPhai) HuongMat();
    }
    void HuongMat()
    {
        //Neu Mario khong quay phai thi
        QuayPhai = !QuayPhai;
        Vector2 HuongQuay = transform.localScale;
        HuongQuay.x *= -1;
        transform.localScale = HuongQuay;
        if (TocDo > 1) StartCoroutine(SharkChuyenHuong());
    }
    IEnumerator SharkChuyenHuong()
    {
        ChuyenHuong = true;
        yield return new WaitForSeconds(0.2f);
        ChuyenHuong = false;
    }
}
