using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    [Header("Particles")]
    [SerializeField] private GameObject mineParticle = null;
    [SerializeField] private Vector3 offset = new Vector3(0, 1, 0);

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            GameObject particle = Instantiate(mineParticle, transform.position + offset, Quaternion.identity);
            Destroy(particle, 3);
            gameObject.SetActive(false);
        }
    }

}
