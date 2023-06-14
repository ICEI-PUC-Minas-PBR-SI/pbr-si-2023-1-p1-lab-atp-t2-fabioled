using System.Diagnostics;
using System.IO;
namespace ArquivoForms
{
    public partial class Form1 : Form
    {

        private string strPathFile = @"C:\temp\ArquivoExemplo.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            Criar();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void btnConcatenar_Click(object sender, EventArgs e)
        {
            Concatenar();
        }
        private void Criar()
        {
            try
            {
                //Usarei a cláusula using como boas práticas de programação em todos os métodos
                //Instancio a classe FileStream, uso a classe File e o método Create para criar o
                //arquivo passando como parâmetro a variável strPathFile, que contém o arquivo
                using (FileStream fs = File.Create(strPathFile))
                {
                    //Crio outro using, dentro dele instancio o StreamWriter (classe para gravar os dados)
                    //que recebe como parâmetro a variável fs, referente ao FileStream criado anteriormente
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        //Uso o método Write para escrever algo em nosso arquivo texto
                        sw.Write("Texto adicionado ao exemplo!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //Se tudo ocorrer bem, exibo a mensagem ao usuário.
            MessageBox.Show("Arquivo criado com sucesso!!!");
        }

        private void Abrir()
        {
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(strPathFile)
            {
                UseShellExecute = true
            };
            p.Start();
            try
            {
                //Verifico se o arquivo que desejo abrir existe e passo como parâmetro a respectiva variável
                if (File.Exists(strPathFile))
                {
                    //Se existir "starto" um processo do sistema para abrir o arquivo e, sem precisar
                    //passar ao processo o aplicativo a ser aberto, ele abre automaticamente o Notepad
                    System.Diagnostics.Process.Start(strPathFile);
                }
                else
                {
                    //Se não existir exibo a mensagem
                    MessageBox.Show("Arquivo não encontrado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Concatenar()
        {
            try
            {
                // Verifico se o arquivo que desejo 
                // abrir existe e passo como parâmetro a 
                // respectiva variável
                if (File.Exists(strPathFile))
                {
                    // Crio um using, dentro dele  instancio  StreamWriter, uso a classe File e o  método
                    // AppendText para concatenar o    texto, passando como parâmetro a   variável strPathFile
                    using (StreamWriter sw = File.AppendText(strPathFile))
                    {
                        // Uso o método Write para escrever o arquivo 
                        // que será adicionado no arquivo text
                        sw.Write("\r\nTexto adicionado ao final do arquivo");
                    }
                    // Exibo a mensagem que o arquivo foi atualizado
                    MessageBox.Show("Arquivo atualizado!");
                }
                else
                {
                    // Se não existir exibo a mensagem
                    MessageBox.Show("Arquivo não encontrado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}