using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolenler : MonoBehaviour
{
    [SerializeField] public int s=0,Sayac;
    [SerializeField] public int[] BolenSayilarimiz;
    // Start is called before the first frame update
    void Start()
    {
        BolenSayilarimiz = new int[99999];
        Sayac = 0;
        
    }
    public void BolenSayilar (int BolenSayisi, int Sayi)
    {
        //Verilen Sayinin Bölen sayisina kadar olan bölenlerini gösterir.
        if (Sayi > BolenSayisi)
        {

        for(int i = 1; i <= BolenSayisi; i++)
        {

            if (Sayi % i == 0)
            {
                  
                        BolenSayilarimiz[s] = i;

                   
                 
                    s += 1;

            }



        }

        }
       

        if (BolenSayilarimiz.Length >0)
        {
            for(int a =0; a<=s; a++)
            {

                Debug.Log (Sayi +" Sayýsýný Bölen sayýmýz = "+ BolenSayilarimiz[a]);

            }
           
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Sayac == 0)
        {
            BolenSayilar(55,1508);
            Sayac = 1;
        }





    }


    
}
