using WMPLib;

namespace MP3
{
    public partial class Form1 : Form
    {
        //objeto q se encarga de reproducir el audio
        private WindowsMediaPlayer reproductor;
        //guardar la ruta del archivo de audio
        private string archivoSeleccionado = "";


        public Form1()
        {
            InitializeComponent();
            //creamos el reproductor
            reproductor = new WindowsMediaPlayer();
            //evita que se reproduzca el audio en bucle
            reproductor.settings.autoStart = false;
            //configurar el openFiledialog
            openFileDialog1.Filter =
                "Archivos de audio (*.mp3)|*.mp3";
            openFileDialog1.Title = "Seleccionar archivo MP3";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            try
            {
                //si no hay un archivo seleccionado
                // abrimos elexplorador de archivos
                if (string.IsNullOrEmpty(archivoSeleccionado))
                {
                    DialogResult resultado =
                        openFileDialog1.ShowDialog();

                    //el usuario cancelo la seleccion
                    if (resultado != DialogResult.OK)
                    {
                        return;
                    }
                    //guardar ruta de archivo
                    archivoSeleccionado =
                        openFileDialog1.FileName;
                    //mostrar nombre del archivo en el label
                    lblarchivo.Text = "Archivo seleccionado: " +
                        Path.GetFileName(archivoSeleccionado);
                }
                //indicamos al reproductor que reproduzca el archivo seleccionado
                reproductor.URL = archivoSeleccionado;
                //Reproducir el audio
                reproductor.controls.play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al reproducir el archivo: " + ex.Message);
            }
        }
    }
}