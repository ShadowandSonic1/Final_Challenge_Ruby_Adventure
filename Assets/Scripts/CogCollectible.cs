using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogCollectible : MonoBehaviour
{
    public AudioClip collectedClip;
    ParticleSystem cogGain;

    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if(controller != null)
        {
            if(controller.cogs < controller.maxCogs)
            {
                controller.ChangeCog(2);
                Destroy(gameObject);

                controller.PlaySound(collectedClip);
                controller.PlayEffect(cogGain);
            }
        }
    }
}
