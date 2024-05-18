using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacePieces : MonoBehaviour
{
    [SerializeField]
    private GameObject TuraNeagra;
    [SerializeField]
    private GameObject TuraAlba;
    [SerializeField]
    private GameObject CalNegru;
    [SerializeField]
    private GameObject CalAlb;
    [SerializeField]
    private GameObject NebunNegru;
    [SerializeField]
    private GameObject NebunAlb;
    [SerializeField]
    private GameObject ReginaNeagra;
    [SerializeField]
    private GameObject ReginaAlba;
    [SerializeField]
    private GameObject RegeNegru;
    [SerializeField]
    private GameObject RegeAlb;
    [SerializeField]
    private GameObject PionNegru;
    [SerializeField]
    private GameObject PionAlb;

    // Start is called before the first frame update
    void Start()
    {
        SetPieces();
    }

    void SetPieces()
    {
        GameObject piesa;
        //adaug piese negre
        piesa = Instantiate(TuraNeagra, new Vector3(0, 0.1f, 35), Quaternion.identity);
        piesa = Instantiate(TuraNeagra, new Vector3(35, 0.1f, 35), Quaternion.identity);

        piesa = Instantiate(CalNegru, new Vector3(5, 0.1f, 35), Quaternion.identity);
        piesa = Instantiate(CalNegru, new Vector3(30, 0.1f, 35), Quaternion.identity);

        piesa = Instantiate(NebunNegru, new Vector3(10, 0.1f, 35), Quaternion.identity);
        piesa = Instantiate(NebunNegru, new Vector3(25, 0.1f, 35), Quaternion.identity);

        piesa = Instantiate(RegeNegru, new Vector3(15, 0.1f, 35), Quaternion.identity);
        piesa = Instantiate(ReginaNeagra, new Vector3(20, 0.1f, 35), Quaternion.identity);

        piesa = Instantiate(PionNegru, new Vector3(0, 0.1f, 30), Quaternion.identity);
        piesa = Instantiate(PionNegru, new Vector3(5, 0.1f, 30), Quaternion.identity);
        piesa = Instantiate(PionNegru, new Vector3(10, 0.1f, 30), Quaternion.identity);
        piesa = Instantiate(PionNegru, new Vector3(15, 0.1f, 30), Quaternion.identity);
        piesa = Instantiate(PionNegru, new Vector3(20, 0.1f, 30), Quaternion.identity);
        piesa = Instantiate(PionNegru, new Vector3(25, 0.1f, 30), Quaternion.identity);
        piesa = Instantiate(PionNegru, new Vector3(30, 0.1f, 30), Quaternion.identity);
        piesa = Instantiate(PionNegru, new Vector3(35, 0.1f, 30), Quaternion.identity);

        //adaug piese albe
        piesa = Instantiate(TuraAlba, new Vector3(0, 0.1f, 0), Quaternion.identity);
        piesa = Instantiate(TuraAlba, new Vector3(35, 0.1f, 0), Quaternion.identity);

        piesa = Instantiate(CalAlb, new Vector3(5, 0.1f, 0), Quaternion.identity);
        piesa = Instantiate(CalAlb, new Vector3(30, 0.1f, 0), Quaternion.identity);

        piesa = Instantiate(NebunAlb, new Vector3(10, 0.1f, 0), Quaternion.identity);
        piesa = Instantiate(NebunAlb, new Vector3(25, 0.1f, 0), Quaternion.identity);

        piesa = Instantiate(RegeAlb, new Vector3(15, 0.1f, 0), Quaternion.identity);
        piesa = Instantiate(ReginaAlba, new Vector3(20, 0.1f, 0), Quaternion.identity);

        piesa = Instantiate(PionAlb, new Vector3(0, 0.1f, 5), Quaternion.identity);
        piesa = Instantiate(PionAlb, new Vector3(5, 0.1f, 5), Quaternion.identity);
        piesa = Instantiate(PionAlb, new Vector3(10, 0.1f, 5), Quaternion.identity);
        piesa = Instantiate(PionAlb, new Vector3(15, 0.1f, 5), Quaternion.identity);
        piesa = Instantiate(PionAlb, new Vector3(20, 0.1f, 5), Quaternion.identity);
        piesa = Instantiate(PionAlb, new Vector3(25, 0.1f, 5), Quaternion.identity);
        piesa = Instantiate(PionAlb, new Vector3(30, 0.1f, 5), Quaternion.identity);
        piesa = Instantiate(PionAlb, new Vector3(35, 0.1f, 5), Quaternion.identity);

    }
}
