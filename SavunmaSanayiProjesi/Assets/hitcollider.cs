using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class hitcollider : MonoBehaviour
{
    public Transform firePoint;
    public float fireRange = 100f;
    public TextMeshProUGUI skorText;
    public int skor;
    public GameObject winPanel;
    public GameObject muzzleFlashPrefab;
    public float mermihizi = 10f;
    public float timer;
    public GameObject losePanel;
    public TextMeshProUGUI suretext;
    public bool kazandýmý;
    public AudioSource PatlamaSesi;
    private void Start()
    {
        timer = 120;
        winPanel.SetActive(false);
        losePanel.SetActive(false);
        kazandýmý = false;
    }
    void Update()
    {
        if (timer > 1 && !kazandýmý)
        {
            timer -= Time.deltaTime;
        }
        if (timer < 1)
        {
            losePanel.SetActive(true);
        }
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
            
        }
        skorText.text ="Skor: " +skor.ToString();
        suretext.text = "Süre: " + timer.ToString();
        if (skor == 10)
        {
            winPanel.SetActive(true);
            kazandýmý = true; 
        }
        
    }

    void Shoot()
    {
        RaycastHit hit;
        PatlamaSesi.Play();
        GameObject muzzleFlash = Instantiate(muzzleFlashPrefab, firePoint.position, firePoint.rotation);
        muzzleFlash.GetComponent<Rigidbody>().velocity = firePoint.forward * mermihizi * 10 * 11;
        Destroy(muzzleFlash, 0.5f);
        if (Physics.Raycast(firePoint.position, firePoint.forward, out hit, fireRange))
        {
            Debug.Log(hit.transform.name);

            

            if (hit.transform.CompareTag("Enemy"))
            {
                Destroy(hit.transform.gameObject);
                skor++;
            }
           
            
        }
    }

}
