using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    Rigidbody2D rigidbody2d;

    // Start is called before the first frame update
    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    public void Launch(Vector2 direction, float force)
    {
        rigidbody2d.AddForce(direction * force);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.magnitude > 1000.0f)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        EnemyController e = other.collider.GetComponent<EnemyController>();
        HardEnemyController h = other.collider.GetComponent<HardEnemyController>();
        HarderEnemyController t = other.collider.GetComponent<HarderEnemyController>();

        if (e != null)
        {
            e.Fix();
            RubyController.robotValue += 1;
            
        }
        else if (h != null)
        {
            h.Fix();
            RubyController.robotValue += 1;
        }
        else if (t != null)
        {
            HarderEnemyController.HP += 1;
            t.Fix();            
        }

        Destroy(gameObject);
    }
}
