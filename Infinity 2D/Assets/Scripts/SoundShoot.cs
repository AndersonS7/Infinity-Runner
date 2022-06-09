using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundShoot : MonoBehaviour
{
    private void OnEnable()
    {
        StartCoroutine(Disabled());
    }
    IEnumerator Disabled()
    {
        yield return new WaitForSeconds(0.1f);
        gameObject.SetActive(false);
    }
}
