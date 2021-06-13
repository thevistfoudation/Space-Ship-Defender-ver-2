using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSupportController : MonoBehaviour
{
    public bool straightup;
    public bool Right1;
    public bool Right2;
    public bool Left1;
    public bool Left2;
    public bool Right3;
    public bool left3;
    public GameObject TranShoot;
    public GameObject[] bullet;
    //public Vector3 pos;
    public float delay;
    public float BulletLevel;
    //BulletLevel dựa vào level ng chơi hoặc điểm số
    Transform player;
    //private Rigidbody2D rb;
    // private Vector2 movement;
    public static GunSupportController instance;
    public Vector3 angle;
    // Start is called before the first frame update
    private void Awake()
    {
        if (instance == null) instance = this;
    }

    void Start()
    {

        // player = GameObject.Find("Ship").transform;
        // rb = this.GetComponent<Rigidbody2D>();
        BulletLevel = 1;
    }
    private void OnEnable()
    {
        //dc goi moi khi dc active
        StartCoroutine(shoot());
    }

    public void shooot()
    {
        StartCoroutine(shoot());
        Debug.Log("dkm editor ");
    }
    IEnumerator shoot()
    {
        //ko sử dụng trong update vì gọi liên tục sẽ bị crash
        while (true)
        {
            if(straightup == true)
            {
                Instantiate(bullet[0], TranShoot.transform.position, Quaternion.identity);
            }
            if (Left1 == true)
            {
                Instantiate(bullet[0], TranShoot.transform.position, Quaternion.Euler(angle.x, angle.y, 15));
            }
            if (Right1 == true)
            {
                Instantiate(bullet[0], TranShoot.transform.position, Quaternion.Euler(angle.x, angle.y, -15));
            }
            if (Left2 == true)
            {
                Instantiate(bullet[0], TranShoot.transform.position, Quaternion.Euler(angle.x, angle.y, 49));
            }
            if (Right2 == true)
            {
                Instantiate(bullet[0], TranShoot.transform.position, Quaternion.Euler(angle.x, angle.y, -49));
            }
            if (Right3 == true)
            {
                Instantiate(bullet[0], TranShoot.transform.position, Quaternion.Euler(angle.x, angle.y, -35));
            }
            if (left3 == true)
            {
                Instantiate(bullet[0], TranShoot.transform.position, Quaternion.Euler(angle.x, angle.y, 35));
            }
            //Đạn tỏa
            yield return new WaitForSeconds(delay);
            //delay đạn tránh trường hợp bắn liên tục
        }
    }
    IEnumerator c()
    {
        while (true)
        {

            yield return shoot();
        }
    }
    // Update is called once per frame
}
