namespace Notes
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        string caminho = Path.Combine(FileSystem.AppDataDirectory,"arquivo");

        public MainPage()
        {
            InitializeComponent();
            if (File.Exists(caminho))
                CaixaEditor.Text = File.ReadAllText(caminho);
        }

        private void SalvarBtn_Clicked(object sender, EventArgs e)
        {
            string conteudo = CaixaEditor.Text;
            File.WriteAllText(caminho, conteudo);
            DisplayAlert("Salve", $" O arquivo em: {caminho}", "OK");

        }
         
        
        private void ApagarBtn_Clicked(object sender, EventArgs e)
        {
            if (File.Exists(caminho))
            {
                File.Delete(caminho);
                CaixaEditor.Text = null;
                DisplayAlert("O arquivo foi apagado", "Arquivo apagado com sucesso", "OK");
            }
            else
            {
                DisplayAlert("Erro", "O arquivo não existe", "OK");
            }
        }
    }

}
