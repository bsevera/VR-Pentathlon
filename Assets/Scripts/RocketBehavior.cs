using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketBehavior : MonoBehaviour
{
    [SerializeField] float _speed = 5f;
    [SerializeField] float _timer = 2f;
    [SerializeField] GameObject _explosionPrefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyTimer());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }

    IEnumerator DestroyTimer()
    {
        yield return new WaitForSeconds(_timer);
        DestroyThisWithExplosion();
    }

    private void OnTriggerEnter(Collider other)
    {
        //print("test");
        Debug.Log("OnTriggerEnter - collider tag = " + other.tag);

        if (other.tag == "Target")
        {
            StartCoroutine(DestroyWithExplosion(other.gameObject));            
        }

        //if (other.CompareTag("Target") || other.CompareTag("Ground"))
        //    DestroyThisWithExplosion();
    }

    void DestroyThisWithExplosion()
    {
        Instantiate(_explosionPrefab, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }

    //void DestroyThisWithExplosion(GameObject other)
    //{
    //    Instantiate(_explosionPrefab, transform.position, Quaternion.identity);
    //    Destroy(other);
    //    Destroy(this.gameObject);
    //}

    IEnumerator DestroyWithExplosion(GameObject other)
    {
        Instantiate(_explosionPrefab, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(0.2f);
        Destroy(other);
        yield return new WaitForSeconds(0.1f);
        Destroy(this.gameObject);
    }

}
