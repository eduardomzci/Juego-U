using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetearPanelCambiarContenido : MonoBehaviour
{
    public Text SobreCarrera;
    public Text Pregunta;

    //public Text Inciso1;
    //public Text Inciso2;
    //public Text Inciso3;

    public Toggle Inciso1Toggle;
    public Toggle Inciso2Toggle;
    public Toggle Inciso3Toggle;

    public Text NumeroPregunta;
    public Text NumeroAfinidad;
    //public Image ImagenPrincipal;

    public GameObject Salir;
    public GameObject SiguienteOriginal;
    public GameObject Siguientepregunta1;
    public GameObject Siguientepregunta2;
    public GameObject AtrasPreguntaOriginal;
    public GameObject AtrasPregunta1;
    public GameObject AtrasPregunta2;
    public GameObject Finalizar;

    //public int contadorPreguntas = 1;
    //public int TotalPreguntas = 3;

    void Start()
    {
        pregunta0();
    }

    
    void Update()
    {
            
    }

    //public void ResetearContenido()
    //{
    //    //if (contadorPreguntas<TotalPreguntas)
    //    //{
    //    //    SobreCarrera.text = "";
    //    //    Pregunta.text = "";
    //    //    Inciso1.text = "";
    //    //    Inciso2.text = "";
    //    //    Inciso3.text = "";
    //    //    NumeroPregunta.sprite = null;
    //    //    NumeroPregunta.color = new Color(NumeroPregunta.color.r, NumeroPregunta.color.g, NumeroPregunta.color.b, 0f);
    //    //    ImagenPrincipal.sprite = null;
    //    //    ImagenPrincipal.color = new Color(NumeroPregunta.color.r, NumeroPregunta.color.g, NumeroPregunta.color.b, 0f);

    //    //    contadorPreguntas++;
    //    //}
    //    //else
    //    //{
    //    //    //Codigo para animacion final y regreso al juego
    //    //}

    //    if (contadorPreguntas == 1)
    //    {
    //        SobreCarrera.text = "SOBRE LA CARRERA";
    //        Pregunta.text = "Tener solidos conocimientos para la interpretacion del ingreso, la transformacion y eliminacion de los farmacos.";
    //        //Inciso1.text = "";
    //        //Inciso2.text = "";
    //        //Inciso3.text = "";
    //        NumeroPregunta.sprite = Test_Dos;
    //        //NumeroPregunta.color = new Color(NumeroPregunta.color.r, NumeroPregunta.color.g, NumeroPregunta.color.b, 0f);
    //        //ImagenPrincipal.sprite = null;
    //        //ImagenPrincipal.color = new Color(NumeroPregunta.color.r, NumeroPregunta.color.g, NumeroPregunta.color.b, 0f);

    //        contadorPreguntas++;
    //    }
    //    if (contadorPreguntas == 2)
    //    {
    //        SobreCarrera.text = "SOBRE LA CARRERA";
    //        Pregunta.text = "Realizar analisis laboratoriales que contribuyan a la prevencion, diagnostico, tratamiento, control y pronostico de las enfermedades.";
    //        //Inciso1.text = "";
    //        //Inciso2.text = "";
    //        //Inciso3.text = "";
    //        NumeroPregunta.sprite = Test_Tres;
    //        //NumeroPregunta.color = new Color(NumeroPregunta.color.r, NumeroPregunta.color.g, NumeroPregunta.color.b, 0f);
    //        //ImagenPrincipal.sprite = null;
    //        //ImagenPrincipal.color = new Color(NumeroPregunta.color.r, NumeroPregunta.color.g, NumeroPregunta.color.b, 0f);

    //        contadorPreguntas++;
    //    }
    //    if (contadorPreguntas == 3)
    //    {
    //        SobreCarrera.text = "ACERCA DE MI PERFIL";
    //        Pregunta.text = "Me gusta investigar sobre la composicion de los medicamentos";
    //        //Inciso1.text = "";
    //        //Inciso2.text = "";
    //        //Inciso3.text = "";
    //        NumeroPregunta.sprite = Test_Uno;
    //        //NumeroPregunta.color = new Color(NumeroPregunta.color.r, NumeroPregunta.color.g, NumeroPregunta.color.b, 0f);
    //        //ImagenPrincipal.sprite = null;
    //        //ImagenPrincipal.color = new Color(NumeroPregunta.color.r, NumeroPregunta.color.g, NumeroPregunta.color.b, 0f);

    //        contadorPreguntas++;
    //    }
    //    if (contadorPreguntas > 3)
    //    {
    //        contadorPreguntas = 0;
    //    }
    //}

    public void pregunta0()
    {
        SobreCarrera.text = "SOBRE LA CARRERA";
        Pregunta.text = "Diseñar y elaborar productos farmaceuticos, cosmeticos, realizar el control de madecamentos y sus ensayos biologicos.";
        NumeroPregunta.text = "01";
        NumeroAfinidad.text = "0";
        //--------------------------------------
        Salir.SetActive(true);
        SiguienteOriginal.SetActive(true);

        Siguientepregunta1.SetActive(false);
        AtrasPreguntaOriginal.SetActive(false);

        Siguientepregunta2.SetActive(false);
        AtrasPregunta1.SetActive(false);

        AtrasPregunta2.SetActive(false);
        Finalizar.SetActive(false);
        //--------------------------------------
        Inciso1Toggle.isOn = false;
        Inciso2Toggle.isOn = false;
        Inciso3Toggle.isOn = false;
    }

    public void pregunta1()
    {
        SobreCarrera.text = "SOBRE LA CARRERA";
        Pregunta.text = "Tener solidos conocimientos para la interpretacion del ingreso, la transformacion y eliminacion de los farmacos.";
        NumeroPregunta.text = "02";
        NumeroAfinidad.text = "30";
        //--------------------------------------
        Salir.SetActive(false);
        SiguienteOriginal.SetActive(false);

        Siguientepregunta1.SetActive(true);
        AtrasPreguntaOriginal.SetActive(true);

        Siguientepregunta2.SetActive(false);
        AtrasPregunta1.SetActive(false);

        AtrasPregunta2.SetActive(false);
        Finalizar.SetActive(false);
        //--------------------------------------
        Inciso1Toggle.isOn = false;
        Inciso2Toggle.isOn = false;
        Inciso3Toggle.isOn = false;
    }
    public void pregunta2()
    {
        SobreCarrera.text = "SOBRE LA CARRERA";
        Pregunta.text = "Realizar analisis laboratoriales que contribuyan a la prevencion, diagnostico, tratamiento, control y pronostico de las enfermedades.";
        NumeroPregunta.text = "03";
        NumeroAfinidad.text = "50";
        //--------------------------------------
        Salir.SetActive(false);
        SiguienteOriginal.SetActive(false);

        Siguientepregunta1.SetActive(false);
        AtrasPreguntaOriginal.SetActive(false);

        Siguientepregunta2.SetActive(true);
        AtrasPregunta1.SetActive(true);

        AtrasPregunta2.SetActive(false);
        Finalizar.SetActive(false);
        //--------------------------------------
        Inciso1Toggle.isOn = false;
        Inciso2Toggle.isOn = false;
        Inciso3Toggle.isOn = false;
    }
    public void pregunta3()
    {
        SobreCarrera.text = "ACERCA DE MI PERFIL";
        Pregunta.text = "Me gusta investigar sobre la composicion de los medicamentos";
        NumeroPregunta.text = "01";
        NumeroAfinidad.text = "65";
        //--------------------------------------
        Salir.SetActive(false);
        SiguienteOriginal.SetActive(false);

        Siguientepregunta1.SetActive(false);
        AtrasPreguntaOriginal.SetActive(false);

        Siguientepregunta2.SetActive(false);
        AtrasPregunta1.SetActive(false);

        AtrasPregunta2.SetActive(true);
        Finalizar.SetActive(true);
        //--------------------------------------
        Inciso1Toggle.isOn = false;
        Inciso2Toggle.isOn = false;
        Inciso3Toggle.isOn = false;
    }
}
