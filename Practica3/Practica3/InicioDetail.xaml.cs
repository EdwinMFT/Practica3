using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InicioDetail : ContentPage
    {
        public InicioDetail()
        {
            InitializeComponent();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            
            nom.IsEnabled = true;
            ap.IsEnabled = true;
            dir.IsEnabled = true;
            tel.IsEnabled = true;
            sem.IsEnabled = true;
            carre.IsEnabled = true;
            mat.IsEnabled = true;
            cor.IsEnabled = true;
            git.IsEnabled = true;
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            var nombre = nom.Text;
            var apellidos = ap.Text;
            var direccion = dir.Text;
            var telefono = tel.Text;
            //datos escolares
            var carrera = carre.Text;
            var semestre = sem.Text;
            var matricula = mat.Text;
            //Datos Sociales
            var correo = cor.Text;
            var github = git.Text;
            
            if (!string.IsNullOrEmpty(matricula) || !string.IsNullOrEmpty(nombre))
            {
                var parametros = new nuevosParametros { nom = nombre, ap = apellidos, dire = direccion, tele = telefono, car = carrera, se = semestre, mat = matricula, cor = correo, gith = github };

                //DisplayAlert("Edad", edad, "OK");
                //DisplayAlert("Apellido Materno", aMaterno, "OK");
                //DisplayAlert("Apellido Paterno", aPaterno, "OK");
                //DisplayAlert("Nombre", nombre, "OK");
                
                nom.IsEnabled = false;
                ap.IsEnabled = false;
                dir.IsEnabled = false;
                tel.IsEnabled = false;
                sem.IsEnabled = false;
                carre.IsEnabled = false;
                mat.IsEnabled = false;
                cor.IsEnabled = false;
                git.IsEnabled = false;
                

                DisplayAlert("Datos Guardados", "Nombre:" + nom.Text + " \n Apellidos:" + ap.Text + "\n" + "Direccion:" + dir.Text + "\n" + "Telefono:" + tel.Text + "\n" +"Carrera:"+carrera+"\n"+"Semestre:"+semestre+"\n"+"Matricula:" + mat.Text + "\n"+"Correo:"+correo+"\n"+"GitHub:"+github+".", "OK");
                this.Navigation.PushModalAsync(new Datos(parametros));
            }
            else
            {
                DisplayAlert("", "Captura todos los datos", "OK");
            }
        }
    }
}