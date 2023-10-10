using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Buscaminas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PresionarButton(object sender, RoutedEventArgs e) //funcion que muestra cuando esta super serca de la bomba un colo emoticono y un valor
        {
            Button tb = e.Source as Button; //Creo una variable button donde almaceno el valor enviado al presionar el boton
            tb.Background = Brushes.Red; //pongo el fondo del boton de colo rojo
            tb.Content = "3"; //Pongo un valor numerico de proximidad en el boton
            tb.Foreground = Brushes.White; //pongo de color blanco el color del valor numerico
            SercaRojo(); //Funcion que controla el emoticono adecuado 
        }

        private void PresionarBomba(object sender, RoutedEventArgs e)
        {
            Button tb = e.Source as Button;//Creo una variable button donde almaceno el valor enviado al presionar el boton
            tb.Background = Brushes.Black;//pongo el fondo del boton de colo negro
            MessageBox.Show("BOOOOOM"); //Mensaje atraves de una ventana imitando el sonido de la bomba al explotar
            tb.Content = "B";//Pongo el valor de bomba en el boton
            tb.Foreground = Brushes.White;//pongo de color blanco el color del valor de bomba
            Boom();//Funcion que controla el emoticono adecuado

        }

        private void PresionarLejos(object sender, RoutedEventArgs e)
        {
            Button tb = e.Source as Button;//Creo una variable button donde almaceno el valor enviado al presionar el boton
            tb.Background = Brushes.Blue;//pongo el fondo del boton de colo Azul
            tb.Content = "1";//Pongo un valor numerico de proximidad en el boton
            tb.Foreground = Brushes.White;//pongo de color blanco el color del valor numerico
            Lejos();//Funcion que controla el emoticono adecuado
        }

        private void PresionarSerca(object sender, RoutedEventArgs e)
        {
            Button tb = e.Source as Button;//Creo una variable button donde almaceno el valor enviado al presionar el boton
            tb.Background = Brushes.Green;//pongo el fondo del boton de colo verde
            tb.Content = "2";//Pongo un valor numerico de proximidad en el boton
            tb.Foreground = Brushes.White;//pongo de color blanco el color del valor numerico
            Serca();//Funcion que controla el emoticono adecuado

        }

        private void PresionarNada(object sender, RoutedEventArgs e)
        {
            Button tb = e.Source as Button;//Creo una variable button donde almaceno el valor enviado al presionar el boton
            tb.Background = Brushes.White;//pongo de color blanco el color de fondo del boton
            Nada();//Funcion que controla el emoticono adecuado

        }

        private void Lejos() //Funcion que controla el emoticono lejano
        {
            BitmapImage bi3 = new BitmapImage(); //Creo una variable Bitmap 
            bi3.BeginInit(); //Inicializo el bitmap
            bi3.UriSource = new Uri("Iconos/Lejos.bmp", UriKind.Relative); //Le pongo el Source relativo del icono
            bi3.EndInit(); //Finalizo la inicializacion
            Icon.Stretch = Stretch.Fill; //Le ponemos de tamaño lo mismo que el contenedor de Image en XAML
            Icon.Source = bi3; //Asigno el Source al icon

        }

        private void Serca()
        {
            BitmapImage bi3 = new BitmapImage();//Creo una variable Bitmap 
            bi3.BeginInit();//Inicializo el bitmap
            bi3.UriSource = new Uri("Iconos/Serca.bmp", UriKind.Relative);//Le pongo el Source relativo del icono
            bi3.EndInit(); //Finalizo la inicializacion
            Icon.Stretch = Stretch.Fill;//Le ponemos de tamaño lo mismo que el contenedor de Image en XAML
            Icon.Source = bi3;//Asigno el Source al icon

        }

        private void SercaRojo()
        {
            BitmapImage bi3 = new BitmapImage();//Creo una variable Bitmap 
            bi3.BeginInit();//Inicializo el bitmap
            bi3.UriSource = new Uri("Iconos/SercaRojo.bmp", UriKind.Relative);//Le pongo el Source relativo del icono
            bi3.EndInit(); //Finalizo la inicializacion
            Icon.Stretch = Stretch.Fill;//Le ponemos de tamaño lo mismo que el contenedor de Image en XAML
            Icon.Source = bi3;//Asigno el Source al icon

        }

        private void Nada()
        {
            BitmapImage bi3 = new BitmapImage();//Creo una variable Bitmap 
            bi3.BeginInit();//Inicializo el bitmap
            bi3.UriSource = new Uri("Iconos/Nada.bmp", UriKind.Relative);//Le pongo el Source relativo del icono
            bi3.EndInit(); //Finalizo la inicializacion
            Icon.Stretch = Stretch.Fill;//Le ponemos de tamaño lo mismo que el contenedor de Image en XAML
            Icon.Source = bi3;//Asigno el Source al icon

        }
        private void Boom()
        {
            BitmapImage bi3 = new BitmapImage();//Creo una variable Bitmap 
            bi3.BeginInit();//Inicializo el bitmap
            bi3.UriSource = new Uri("Iconos/boom.jpg", UriKind.Relative);//Le pongo el Source relativo del icono
            bi3.EndInit(); //Finalizo la inicializacion
            Icon.Stretch = Stretch.Fill;//Le ponemos de tamaño lo mismo que el contenedor de Image en XAML
            Icon.Source = bi3;//Asigno el Source al icon

        }
    }
}
