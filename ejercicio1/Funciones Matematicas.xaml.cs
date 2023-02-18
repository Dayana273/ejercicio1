using ejercicio1.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ejercicio1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Funciones_Matematicas : ContentPage
    {
        public object Number1Entry { get; private set; }

        public Funciones_Matematicas()
        {
            InitializeComponent();
        }

        private void txtcalcular_Clicked(object sender, EventArgs e)
        {

            var solu = new solucion
            {
               





            };

        }



        private void txtresta_Clicked(object sender, EventArgs e)

        {
           
            
                
        
            

        }

        private void txtdividir_Clicked(object sender, EventArgs e)
        {

        }

        private void txtsuma_Clicked(object sender, EventArgs e)
        {

        }

        private void txtmultiplicar_Clicked(object sender, EventArgs e)
        {

        }
    }
}