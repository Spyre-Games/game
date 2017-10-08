using UnityEngine;
using UnityEngine.UI;

public class bowscript : MonoBehaviour
{
    public static float arrowSpeed = 65;
    public Rigidbody arrow;
    public Rigidbody bullet;
    public GameObject equip1;
    public GameObject equip2;
    public static int arrows = 20;
    public static int bullets = 30000;
    public static int totalBullets = 999;
    public static int ammo;
    public static int bulletSpeed = 210;
    public static float shotAFC;
    public static float shotInterval = 0.1f;
    public Text ammoCountText;
    int equipNum = 1;
    string ammoType;
    

    void Fire()
    {
        if (bullets > 0 && equipNum == 1)
        {
            Rigidbody bulletClone = (Rigidbody)Instantiate(bullet, transform.position, transform.parent.rotation);
            bulletClone.position += transform.forward * Time.deltaTime * bulletSpeed;
            bullets--;
        }
        if (arrows > 0 && equipNum == 2)
        {
            Rigidbody arrowClone = (Rigidbody)Instantiate(arrow, transform.position, transform.parent.rotation);
            arrowClone.position += transform.forward * Time.deltaTime * arrowSpeed;
            arrows--;
        }
    }
    void OnCollisionEnter(Collision collision) { GameObject.Destroy(this.gameObject); }
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            equipNum = 1;
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            equipNum = 2;
        }
        if (Input.GetKey(KeyCode.R) && equipNum == 1)
        {
            totalBullets -= (30 - bullets);
            bullets = 30;
        }
        switch (equipNum)
        {
            case 1:
                ammoType = "Bullets";
                ammo = bullets;
                equip1.transform.localScale = new Vector3(1,1,1);
                equip2.transform.localScale = new Vector3(0, 0, 0);
                break;
            case 2:
                ammoType = "Arrows";
                ammo = arrows;
                equip1.transform.localScale = new Vector3(0, 0, 0);
                equip2.transform.localScale = new Vector3(1,1,1);
                break;
            default:
                ammoType = "something breaked";
                return;
        }
        ammoCountText.text = ("" + ammoType + " Remaining: " + ammo + " / " + totalBullets);
        if (Input.GetKey(KeyCode.Mouse0))//(Input.GetButtonDown("Fire1"))
            if (shotAFC > 0)
            {
                shotAFC -= Time.deltaTime;
            }
            else
            {
                Fire();
                Sound.playaudio();
                shotAFC = shotInterval;
            }
            
    }

}
